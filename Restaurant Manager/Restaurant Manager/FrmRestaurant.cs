﻿using Business_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Manager
{
    public partial class FrmRestaurant : Form
    {
        public FrmRestaurant()
        {
            InitializeComponent();
        }

        private void FrmRestaurant_Load(object sender, EventArgs e)
        {
            BsRestaurant bsRestaurant= new BsRestaurant();
            dgvRestaurant.DataSource = bsRestaurant.Read("","",0,"ID"); //Caricamento della lista completa

            //La tabella viene settata di default "ReadOnly" e viene nascosta la prima colonnna dedicata all'ID
            dgvRestaurant.ReadOnly = true;
            dgvRestaurant.Columns[0].Visible = false;

            //Viene negata la scrittura all'interno della ComboBox e inizializzata con l'elemento "Tutti i tipi"
            SetComboBox();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmManageRest createForm = new FrmManageRest();
            createForm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CountRows() == 0)
                OperationMessage.GetIsEmpty();

            else
                DeleteElement();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(CountRows() == 0)
                OperationMessage.GetIsEmpty();

            else
                UpdateElement();
        }

        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            BsRestaurant bsRestaurant = new BsRestaurant();
            CheckFilterFields();
            dgvRestaurant.DataSource = bsRestaurant.Read(txtName.Text, txtCity.Text, cmbType.SelectedIndex, cmbOrder.Text);
        }

        private void DeleteElement()
        {
            BsRestaurant bsRestaurant = new BsRestaurant();
            string message = "";
            int idSelected = (int)dgvRestaurant.CurrentRow.Cells[0].Value;

            if (DialogResult.Yes == OperationMessage.GetGenericQuestion())
            {
                bsRestaurant.Delete(idSelected, ref message);
                OperationMessage.GetCustomWarning(message, "Eliminazione Ristorante");
                CheckFilterFields();
                dgvRestaurant.DataSource = bsRestaurant.Read(txtName.Text,txtCity.Text,cmbType.SelectedIndex,cmbOrder.Text);
            }
        }
        private void UpdateElement()
        {
            int idSelected = (int)dgvRestaurant.CurrentRow.Cells[0].Value;
            FrmManageRest editForm = new FrmManageRest(idSelected);

            editForm.ShowDialog();
        }
        private int CountRows()
        {
            return dgvRestaurant.Rows.Count;
        }
        private void CheckFilterFields()
        {
            if (txtName == null)
                txtName.Text = "";

            if (txtCity == null)
                txtCity.Text = "";
        }
        private void SetComboBox()
        {
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.SelectedIndex = 0;
            cmbOrder.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrder.SelectedIndex = 0;
        }
        private void UpdateList()
        {
            BsRestaurant bsRestaurant = new BsRestaurant();
            CheckFilterFields();
            dgvRestaurant.DataSource = bsRestaurant.Read(txtName.Text, txtCity.Text, cmbType.SelectedIndex, cmbOrder.Text);
        }

    }
}
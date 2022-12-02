using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Data_layer
{
    public class DbData
    {
        SqlTransaction sqlTransaction;
        SqlCommand transCommand;
        SqlConnection sqlConnection = new SqlConnection();
        const string connectionString = "Server = LAPTOP-OH2IC4QE\\SQLEXPRESS;Integrated Security = False;Database = restaurantDB;Persist Security Info=False;User ID = sa;Password = Christian11;";

        public DbData()
        {
            sqlConnection.ConnectionString = connectionString;
        }

        public void Open()
        {
            if(sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
        }

        public void Close() 
        { 
            if(sqlConnection.State == ConnectionState.Open)
                sqlConnection.Close();
        }

        public void Create(string query)
        {
            SqlCommand command = new SqlCommand(query, sqlConnection);
            
            Open();
            command.ExecuteScalar();
            Close();

        }

        public DataTable Read(string query)
        {

            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            Open();
            dataAdapter.Fill(dt);
            Close();

            return dt;

        }

        public void Update(string query)
        {
            SqlCommand command = new SqlCommand(query,sqlConnection);
            Open();
            command.ExecuteScalar();
            Close();
        }

        public void UpdateTrans(string query)
        {
            transCommand.CommandText = query;
            transCommand.ExecuteNonQuery();
        }

        public void Delete(string query)
        {     
            SqlCommand command = new SqlCommand(query, sqlConnection);
            Open();
            command.ExecuteScalar();
            Close();
        }

        public void BeginTrans()
        {
            //Collegamento connessione a transazione
            transCommand = sqlConnection.CreateCommand();

            sqlTransaction = sqlConnection.BeginTransaction();

            transCommand.Connection = sqlConnection;
            transCommand.Transaction = sqlTransaction;
        }

        public void CommitTrans()
        {
            sqlTransaction.Commit();
        }

        public void RollbackTrans()
        {
            sqlTransaction.Rollback();
        }

        public int Execute(string query)
        {
            SqlCommand command = new SqlCommand(query, sqlConnection);
            int result = 0;

            Open();

            try
            {
                var value = command.ExecuteScalar();
                result = Convert.ToInt32(value);
            }

            catch (Exception ex)
            {
                result = 0;
            }

            Close();

            return result;
        }

    }
}

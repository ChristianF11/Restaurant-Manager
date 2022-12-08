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
        SqlCommand command = null;
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

            if (command == null)
                command = sqlConnection.CreateCommand();
        }

        public void Close() 
        { 
            if(sqlConnection.State == ConnectionState.Open)
                sqlConnection.Close();
        }

        public void Create(string query)
        {
            command.CommandText = query;
            command.ExecuteNonQuery();
        }

        public DataTable Read(string query)
        {
            Open();

            command.CommandText= query;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            dataAdapter.Fill(dt);
            Close();

            return dt;
        }


        public void Update(string query)
        {
            command.CommandText = query;
            command.ExecuteNonQuery();
        }

        public void Delete(string query)
        {
            command.CommandText = query;
            command.ExecuteNonQuery();
        }

        public void BeginTrans()
        {
            //Collegamento connessione a transazione
            sqlTransaction = sqlConnection.BeginTransaction();

            command.Connection = sqlConnection;
            command.Transaction = sqlTransaction;
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

            command.CommandText = query;
            int result = 0;

            try
            {
                var value = command.ExecuteScalar();
                result = Convert.ToInt32(value);
            }

            catch (Exception ex)
            {
                result = 0;
            }
            return result;
        }

    }
}

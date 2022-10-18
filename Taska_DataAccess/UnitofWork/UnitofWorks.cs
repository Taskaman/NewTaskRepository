using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Taska_DataAccess.UnitofWork
{
    public class UnitofWorks:IDisposable
    {
        protected string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionStrings"].ToString();
        protected SqlConnection sqlConnection { get; set; }
        protected SqlTransaction transaction { get; set; }
        public SqlCommand sqlcommand { get; set; }

        public UnitofWorks()
        {
            BeginTransaction();
        }

        public void BeginTransaction()
        {
            OpenConnection();
        }

        public void OpenConnection()
        {
            sqlConnection = new SqlConnection(ConnectionString);
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            transaction = sqlConnection.BeginTransaction();
            sqlcommand.Connection = sqlConnection;
            sqlcommand.Transaction = transaction;
        }


        public void Dispose()
        {
            sqlConnection.Close();
            sqlConnection.Dispose();
            sqlcommand.Dispose();
        }
    }
}

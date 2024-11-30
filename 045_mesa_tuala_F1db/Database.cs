using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
namespace _045_mesa_tuala_F1db
{
    public class Database
    {
        // Generic Connection string
        private string provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";

        // Get all drivers
        private OleDbCommand command;
        private OleDbConnection connection;
        private OleDbDataAdapter adapter;

        // Datatable

        private DataTable dt;


        public Database(string file_path)
        {
            string conn_str = provider + file_path; 
            connection = new OleDbConnection(conn_str);
        }

        public OleDbConnection Connection
        {
            get { return connection; }
        }

        public void OpenConnection()
        {
            if (this.Connection.State != ConnectionState.Open)
            {
                this.Connection.Open();
            }

        }

        public void CloseConnection()
        {
            if (this.Connection.State != ConnectionState.Closed)
            {
                this.Connection.Close();
            }

        }
    }
}

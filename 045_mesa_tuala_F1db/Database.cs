using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
<<<<<<< HEAD

=======
>>>>>>> b6e78c9712879e6de39c9e4849d38f7fbc74fc6c
namespace _045_mesa_tuala_F1db
{
    public class Database
    {
<<<<<<< HEAD

=======
        const string ConnStr = "some string";

        // Get all drivers
        private OleDbCommand command;
        private OleDbConnection connection;
        private OleDbDataAdapter adapter;

        // Datatable

        private DataTable dt;


        public Database()
        {
            connection = new OleDbConnection(ConnStr);
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
>>>>>>> b6e78c9712879e6de39c9e4849d38f7fbc74fc6c
    }
}

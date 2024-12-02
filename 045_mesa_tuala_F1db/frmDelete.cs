using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _045_mesa_tuala_F1db
{
    public partial class frmDelete : Form
    {
        Database db;

        public frmDelete(Database db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtModeldescDelete.Text))
            {
                MessageBox.Show("Please input the required field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int rows_affectd = this.db.delete_record(txtModeldescDelete.Text);

            if (rows_affectd > 0)
            {
                MessageBox.Show("Successfully added a deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Failed to add a delete", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtModeldescDelete.Clear();
        }
    }
}

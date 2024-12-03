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
        private Database db;

        // hold selected value

        private string model_desc;

        public frmDelete(Database db, string model_desc)
        {
            InitializeComponent();
            this.db = db;
            this.model_desc = model_desc;
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

        private void frmDelete_Load(object sender, EventArgs e)
        {
            txtModeldescDelete.Text = model_desc;
        }
    }
}

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
    public partial class frmAdd : Form
    {
        Database db;
        public frmAdd(Database db)
        {
            InitializeComponent();
            this.db = db;

        }

        // Helper Function

        public void InitializeCBO()
        {
            DataTable dt = this.db.query_brand_table();
            cboBrandAdd.DataSource = dt;
            cboBrandAdd.DisplayMember = "brand";
            cboBrandAdd.ValueMember = "brandid";
        }

        // WinForm Function

        private void frmAdd_Load(object sender, EventArgs e)
        {
            InitializeCBO();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrWhiteSpace(txtModeldescAdd.Text) || string.IsNullOrWhiteSpace(txtPriceAdd.Text))
            {
                MessageBox.Show("Please input the required field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int rows_affectd = db.add_record(txtModeldescAdd.Text, Convert.ToDouble(txtPriceAdd.Text),
                                    Convert.ToInt32(cboBrandAdd.SelectedValue.ToString()));

            if (rows_affectd > 0)
            {
                MessageBox.Show("Successfully added a record", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Failed to add a record", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cboBrandAdd.SelectedIndex = -1;
            txtModeldescAdd.Clear();
            txtPriceAdd.Clear();
        }
    }
}

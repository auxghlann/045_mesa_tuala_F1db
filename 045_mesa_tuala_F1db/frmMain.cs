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
    public partial class frmMain : Form
    {

        private string db_file_path;
        private Database db;


        // Forms
        private frmAdd frmAdd;
        private frmUpdate frmUpdate;
        private frmDelete frmDelete;

        // value holder

        private string curr_model_desc;
        private string curr_brand;
        private double curr_price;

        public frmMain()
        {
            InitializeComponent();
        }

        // Helper Function


        private void InitializeCBO()
        {
            DataTable dt = this.db.query_brand_table();
            cboSearchBrand.DataSource = dt;
            cboSearchBrand.DisplayMember = "brand";
            cboSearchBrand.ValueMember = "brand";
            cboSearchBrand.SelectedIndex = -1;
        }

        private void fill_grdview()
        {
            grdview.DataSource = db.query_all();
        }

        // WinForm Function
        private void importDbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "*.mdb|";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                db_file_path = dialog.FileName;

                this.db = new Database(db_file_path);
                InitializeCBO();
                fill_grdview();
                MessageBox.Show("Successfully imported the mdb file", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        // Record Forms
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (db == null)
            {
                MessageBox.Show("Please import the database first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmAdd = new frmAdd(db);
            frmAdd.ShowDialog();
            fill_grdview();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (db == null)
            {
                MessageBox.Show("Please import the database first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmUpdate = new frmUpdate(db, curr_model_desc, curr_brand, curr_price);
            frmUpdate.ShowDialog();
            fill_grdview();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (db == null)
            {
                MessageBox.Show("Please import the database first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmDelete = new frmDelete(db, curr_model_desc);
            frmDelete.ShowDialog();
            fill_grdview();
        }

        private void btnSearchKeyword_Click(object sender, EventArgs e)
        {
            if (db == null)
            {
                MessageBox.Show("Please import the database first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtKeyword.Text))
            {
                MessageBox.Show("Please fill in the search field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            grdview.DataSource = db.search_by_keyword(txtKeyword.Text);
        }

        private void btnSearchBrand_Click(object sender, EventArgs e)
        {
            if (db == null)
            {
                MessageBox.Show("Please import the database first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboSearchBrand.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a brand", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            grdview.DataSource = db.search_by_brand(cboSearchBrand.Text);
        }

        private void btnSearchPriceRange_Click(object sender, EventArgs e)
        {
            if (db == null)
            {
                MessageBox.Show("Please import the database first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtLow.Text) || string.IsNullOrEmpty(txtHigh.Text))
            {
                MessageBox.Show("Please fill in the search fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            grdview.DataSource = db.search_by_price_range(Convert.ToInt32(txtLow.Text), Convert.ToInt32(txtHigh.Text));
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            if (db == null)
            {
                MessageBox.Show("Please import the database first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((string.IsNullOrEmpty(txtKeyword.Text) || cboSearchBrand.SelectedIndex == -1 || string.IsNullOrEmpty(txtLow.Text) || string.IsNullOrEmpty(txtHigh.Text)))
            {
                MessageBox.Show("Please fill in the search fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            grdview.DataSource = db.search_by_all(txtKeyword.Text, cboSearchBrand.Text, Convert.ToInt32(txtLow.Text), Convert.ToInt32(txtHigh.Text));



        }

        private void grdview_SelectionChanged(object sender, EventArgs e)
        {


            if (grdview.SelectedRows.Count > 0)
            {
                var selected_row = grdview.SelectedRows[0].DataBoundItem as DataRowView;

                if (selected_row != null)
                {
                    curr_model_desc = selected_row["MODEL DESCRIPTION"].ToString();
                    curr_brand = selected_row["BRAND"].ToString();
                    curr_price = Convert.ToDouble(selected_row["PRICE"]);
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}

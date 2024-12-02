﻿using System;
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
    public partial class frmUpdate : Form
    {
        Database db;
        public frmUpdate(Database db)
        {
            InitializeComponent();
            this.db = db;
        }


        // Helper Function

        public void InitializeCBO()
        {
            DataTable dt = this.db.query_brand_table();
            cboBrandUpdate.DataSource = dt;
            cboBrandUpdate.DisplayMember = "brand";
            cboBrandUpdate.ValueMember = "brandid";
        }

        // WinForm Function
        private void frmUpdate_Load(object sender, EventArgs e)
        {
            InitializeCBO();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtModeldescUpdate.Text) || string.IsNullOrWhiteSpace(txtCurrModelDesc.Text) ||
                string.IsNullOrWhiteSpace(txtPriceUpdate.Text))
            {
                MessageBox.Show("Please input the required field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            int rows_affectd = db.update_record(txtCurrModelDesc.Text, txtModeldescUpdate.Text, 
                                    Convert.ToDouble(txtPriceUpdate.Text), Convert.ToInt32(cboBrandUpdate.SelectedValue.ToString()));

            if (rows_affectd > 0)
            {
                MessageBox.Show("Successfully updated a record", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update a record", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            cboBrandUpdate.SelectedIndex = -1;
            txtPriceUpdate.Clear();
            txtModeldescUpdate.Clear();
            txtCurrModelDesc.Clear();   
        }
    }
}

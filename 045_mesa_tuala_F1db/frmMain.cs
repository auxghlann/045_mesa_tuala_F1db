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

        public frmMain()
        {
            InitializeComponent();
        }

        private void importDbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "*.mdb|";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                db_file_path = dialog.FileName;

                this.db = new Database(db_file_path);

                MessageBox.Show("Successfully imported the mdb file", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (db == null)
            {
                MessageBox.Show("Please import the database first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmAdd = new frmAdd(db);
            frmAdd.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (db == null)
            {
                MessageBox.Show("Please import the database first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmUpdate = new frmUpdate(db);
            frmUpdate.ShowDialog();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (db == null)
            {
                MessageBox.Show("Please import the database first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmDelete = new frmDelete(db);
            frmDelete.ShowDialog();
        }
    }
}

namespace _045_mesa_tuala_F1db
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnSearchAll = new System.Windows.Forms.Button();
            this.grdview = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.importDbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtLow = new System.Windows.Forms.TextBox();
            this.txtHigh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSearchBrand = new System.Windows.Forms.ComboBox();
            this.btnSearchKeyword = new System.Windows.Forms.Button();
            this.btnSearchBrand = new System.Windows.Forms.Button();
            this.btnSearchPriceRange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdview)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(36, 67);
            this.txtKeyword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(147, 22);
            this.txtKeyword.TabIndex = 0;
            // 
            // btnSearchAll
            // 
            this.btnSearchAll.Location = new System.Drawing.Point(33, 242);
            this.btnSearchAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchAll.Name = "btnSearchAll";
            this.btnSearchAll.Size = new System.Drawing.Size(150, 41);
            this.btnSearchAll.TabIndex = 1;
            this.btnSearchAll.Text = "Search All";
            this.btnSearchAll.UseVisualStyleBackColor = true;
            this.btnSearchAll.Click += new System.EventHandler(this.btnSearchAll_Click);
            // 
            // grdview
            // 
            this.grdview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdview.Location = new System.Drawing.Point(215, 48);
            this.grdview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdview.Name = "grdview";
            this.grdview.ReadOnly = true;
            this.grdview.RowHeadersVisible = false;
            this.grdview.RowHeadersWidth = 51;
            this.grdview.RowTemplate.Height = 24;
            this.grdview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdview.Size = new System.Drawing.Size(517, 360);
            this.grdview.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(387, 426);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 53);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(641, 426);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 53);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(513, 426);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 53);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importDbToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(808, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // importDbToolStripMenuItem
            // 
            this.importDbToolStripMenuItem.Name = "importDbToolStripMenuItem";
            this.importDbToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.importDbToolStripMenuItem.Text = "import db";
            this.importDbToolStripMenuItem.Click += new System.EventHandler(this.importDbToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtLow
            // 
            this.txtLow.Location = new System.Drawing.Point(33, 197);
            this.txtLow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLow.Name = "txtLow";
            this.txtLow.Size = new System.Drawing.Size(65, 22);
            this.txtLow.TabIndex = 7;
            // 
            // txtHigh
            // 
            this.txtHigh.Location = new System.Drawing.Point(115, 197);
            this.txtHigh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.Size = new System.Drawing.Size(65, 22);
            this.txtHigh.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Price Range";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "-";
            // 
            // cboSearchBrand
            // 
            this.cboSearchBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchBrand.FormattingEnabled = true;
            this.cboSearchBrand.Location = new System.Drawing.Point(36, 127);
            this.cboSearchBrand.Name = "cboSearchBrand";
            this.cboSearchBrand.Size = new System.Drawing.Size(144, 24);
            this.cboSearchBrand.TabIndex = 13;
            // 
            // btnSearchKeyword
            // 
            this.btnSearchKeyword.Location = new System.Drawing.Point(33, 296);
            this.btnSearchKeyword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchKeyword.Name = "btnSearchKeyword";
            this.btnSearchKeyword.Size = new System.Drawing.Size(150, 41);
            this.btnSearchKeyword.TabIndex = 14;
            this.btnSearchKeyword.Text = "Search by Keyword";
            this.btnSearchKeyword.UseVisualStyleBackColor = true;
            this.btnSearchKeyword.Click += new System.EventHandler(this.btnSearchKeyword_Click);
            // 
            // btnSearchBrand
            // 
            this.btnSearchBrand.Location = new System.Drawing.Point(33, 354);
            this.btnSearchBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchBrand.Name = "btnSearchBrand";
            this.btnSearchBrand.Size = new System.Drawing.Size(150, 41);
            this.btnSearchBrand.TabIndex = 15;
            this.btnSearchBrand.Text = "Filter by Brand";
            this.btnSearchBrand.UseVisualStyleBackColor = true;
            this.btnSearchBrand.Click += new System.EventHandler(this.btnSearchBrand_Click);
            // 
            // btnSearchPriceRange
            // 
            this.btnSearchPriceRange.Location = new System.Drawing.Point(33, 410);
            this.btnSearchPriceRange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchPriceRange.Name = "btnSearchPriceRange";
            this.btnSearchPriceRange.Size = new System.Drawing.Size(150, 41);
            this.btnSearchPriceRange.TabIndex = 16;
            this.btnSearchPriceRange.Text = "Filter by Price Range";
            this.btnSearchPriceRange.UseVisualStyleBackColor = true;
            this.btnSearchPriceRange.Click += new System.EventHandler(this.btnSearchPriceRange_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 503);
            this.Controls.Add(this.btnSearchPriceRange);
            this.Controls.Add(this.btnSearchBrand);
            this.Controls.Add(this.btnSearchKeyword);
            this.Controls.Add(this.cboSearchBrand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHigh);
            this.Controls.Add(this.txtLow);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grdview);
            this.Controls.Add(this.btnSearchAll);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Record";
            ((System.ComponentModel.ISupportInitialize)(this.grdview)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnSearchAll;
        private System.Windows.Forms.DataGridView grdview;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importDbToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtLow;
        private System.Windows.Forms.TextBox txtHigh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboSearchBrand;
        private System.Windows.Forms.Button btnSearchKeyword;
        private System.Windows.Forms.Button btnSearchBrand;
        private System.Windows.Forms.Button btnSearchPriceRange;
    }
}


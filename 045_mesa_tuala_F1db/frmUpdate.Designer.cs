namespace _045_mesa_tuala_F1db
{
    partial class frmUpdate
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtModeldescUpdate = new System.Windows.Forms.TextBox();
            this.cboBrandUpdate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPriceUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCurrModelDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(72, 400);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtModeldescUpdate
            // 
            this.txtModeldescUpdate.Location = new System.Drawing.Point(72, 156);
            this.txtModeldescUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtModeldescUpdate.Name = "txtModeldescUpdate";
            this.txtModeldescUpdate.Size = new System.Drawing.Size(284, 22);
            this.txtModeldescUpdate.TabIndex = 1;
            // 
            // cboBrandUpdate
            // 
            this.cboBrandUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrandUpdate.FormattingEnabled = true;
            this.cboBrandUpdate.Location = new System.Drawing.Point(72, 280);
            this.cboBrandUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboBrandUpdate.Name = "cboBrandUpdate";
            this.cboBrandUpdate.Size = new System.Drawing.Size(284, 24);
            this.cboBrandUpdate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 260);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Brand";
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.Location = new System.Drawing.Point(257, 400);
            this.btnCancelUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnCancelUpdate.TabIndex = 5;
            this.btnCancelUpdate.Text = "Cancel";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Model Description";
            // 
            // txtPriceUpdate
            // 
            this.txtPriceUpdate.Location = new System.Drawing.Point(72, 218);
            this.txtPriceUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPriceUpdate.Name = "txtPriceUpdate";
            this.txtPriceUpdate.Size = new System.Drawing.Size(284, 22);
            this.txtPriceUpdate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "New Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Model Desc to Update";
            // 
            // txtCurrModelDesc
            // 
            this.txtCurrModelDesc.Location = new System.Drawing.Point(71, 96);
            this.txtCurrModelDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurrModelDesc.Name = "txtCurrModelDesc";
            this.txtCurrModelDesc.Size = new System.Drawing.Size(284, 22);
            this.txtCurrModelDesc.TabIndex = 8;
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 506);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCurrModelDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPriceUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboBrandUpdate);
            this.Controls.Add(this.txtModeldescUpdate);
            this.Controls.Add(this.btnUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Record";
            this.Load += new System.EventHandler(this.frmUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtModeldescUpdate;
        private System.Windows.Forms.ComboBox cboBrandUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPriceUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurrModelDesc;
    }
}
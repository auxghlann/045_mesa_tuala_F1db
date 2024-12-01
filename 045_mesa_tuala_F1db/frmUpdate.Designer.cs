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
            this.txtModelUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(54, 325);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtModeldescUpdate
            // 
            this.txtModeldescUpdate.Location = new System.Drawing.Point(54, 76);
            this.txtModeldescUpdate.Name = "txtModeldescUpdate";
            this.txtModeldescUpdate.Size = new System.Drawing.Size(214, 20);
            this.txtModeldescUpdate.TabIndex = 1;
            // 
            // cboBrandUpdate
            // 
            this.cboBrandUpdate.FormattingEnabled = true;
            this.cboBrandUpdate.Location = new System.Drawing.Point(54, 177);
            this.cboBrandUpdate.Name = "cboBrandUpdate";
            this.cboBrandUpdate.Size = new System.Drawing.Size(214, 21);
            this.cboBrandUpdate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Brand";
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.Location = new System.Drawing.Point(193, 325);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCancelUpdate.TabIndex = 4;
            this.btnCancelUpdate.Text = "Cancel";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Model Description";
            // 
            // txtModelUpdate
            // 
            this.txtModelUpdate.Location = new System.Drawing.Point(54, 127);
            this.txtModelUpdate.Name = "txtModelUpdate";
            this.txtModelUpdate.Size = new System.Drawing.Size(214, 20);
            this.txtModelUpdate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 411);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModelUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboBrandUpdate);
            this.Controls.Add(this.txtModeldescUpdate);
            this.Controls.Add(this.btnUpdate);
            this.Name = "frmUpdate";
            this.Text = "frmDelete";
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
        private System.Windows.Forms.TextBox txtModelUpdate;
        private System.Windows.Forms.Label label3;
    }
}
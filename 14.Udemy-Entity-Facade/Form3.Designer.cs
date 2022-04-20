namespace _14.Udemy_Entity_Facade
{
    partial class Form3
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
            this.lblCompanyPhoneE = new System.Windows.Forms.Label();
            this.lblCompanyNameE = new System.Windows.Forms.Label();
            this.txtCNE = new System.Windows.Forms.TextBox();
            this.txtCPE = new System.Windows.Forms.TextBox();
            this.btnCompanyAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCompanyPhoneE
            // 
            this.lblCompanyPhoneE.AutoSize = true;
            this.lblCompanyPhoneE.Location = new System.Drawing.Point(32, 92);
            this.lblCompanyPhoneE.Name = "lblCompanyPhoneE";
            this.lblCompanyPhoneE.Size = new System.Drawing.Size(99, 20);
            this.lblCompanyPhoneE.TabIndex = 1;
            this.lblCompanyPhoneE.Text = "Şirket Telefon";
            // 
            // lblCompanyNameE
            // 
            this.lblCompanyNameE.AutoSize = true;
            this.lblCompanyNameE.Location = new System.Drawing.Point(32, 48);
            this.lblCompanyNameE.Name = "lblCompanyNameE";
            this.lblCompanyNameE.Size = new System.Drawing.Size(73, 20);
            this.lblCompanyNameE.TabIndex = 0;
            this.lblCompanyNameE.Text = "Şirket Adı";
            // 
            // txtCNE
            // 
            this.txtCNE.Location = new System.Drawing.Point(198, 41);
            this.txtCNE.Name = "txtCNE";
            this.txtCNE.Size = new System.Drawing.Size(253, 27);
            this.txtCNE.TabIndex = 2;
            // 
            // txtCPE
            // 
            this.txtCPE.Location = new System.Drawing.Point(198, 89);
            this.txtCPE.Name = "txtCPE";
            this.txtCPE.Size = new System.Drawing.Size(253, 27);
            this.txtCPE.TabIndex = 3;
            // 
            // btnCompanyAdd
            // 
            this.btnCompanyAdd.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnCompanyAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCompanyAdd.Location = new System.Drawing.Point(357, 122);
            this.btnCompanyAdd.Name = "btnCompanyAdd";
            this.btnCompanyAdd.Size = new System.Drawing.Size(94, 29);
            this.btnCompanyAdd.TabIndex = 4;
            this.btnCompanyAdd.Text = "EKLE";
            this.btnCompanyAdd.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCompanyAdd);
            this.groupBox1.Controls.Add(this.txtCPE);
            this.groupBox1.Controls.Add(this.txtCNE);
            this.groupBox1.Controls.Add(this.lblCompanyNameE);
            this.groupBox1.Controls.Add(this.lblCompanyPhoneE);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 179);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sahippers ADD";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 206);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyPhoneE;
        private System.Windows.Forms.Label lblCompanyNameE;
        private System.Windows.Forms.TextBox txtCNE;
        private System.Windows.Forms.TextBox txtCPE;
        private System.Windows.Forms.Button btnCompanyAdd;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
namespace _14.Udemy_Entity_Facade
{
    partial class Form2
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
            this.lblCompanyPhoneG = new System.Windows.Forms.Label();
            this.lblCompanyNameG = new System.Windows.Forms.Label();
            this.txtCNG = new System.Windows.Forms.TextBox();
            this.txtCPG = new System.Windows.Forms.TextBox();
            this.btnCompanyUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIDG = new System.Windows.Forms.TextBox();
            this.lblIDG = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCompanyPhoneG
            // 
            this.lblCompanyPhoneG.AutoSize = true;
            this.lblCompanyPhoneG.Location = new System.Drawing.Point(32, 142);
            this.lblCompanyPhoneG.Name = "lblCompanyPhoneG";
            this.lblCompanyPhoneG.Size = new System.Drawing.Size(99, 20);
            this.lblCompanyPhoneG.TabIndex = 1;
            this.lblCompanyPhoneG.Text = "Şirket Telefon";
            // 
            // lblCompanyNameG
            // 
            this.lblCompanyNameG.AutoSize = true;
            this.lblCompanyNameG.Location = new System.Drawing.Point(32, 98);
            this.lblCompanyNameG.Name = "lblCompanyNameG";
            this.lblCompanyNameG.Size = new System.Drawing.Size(73, 20);
            this.lblCompanyNameG.TabIndex = 0;
            this.lblCompanyNameG.Text = "Şirket Adı";
            // 
            // txtCNG
            // 
            this.txtCNG.Location = new System.Drawing.Point(198, 91);
            this.txtCNG.Name = "txtCNG";
            this.txtCNG.Size = new System.Drawing.Size(253, 27);
            this.txtCNG.TabIndex = 2;
            // 
            // txtCPG
            // 
            this.txtCPG.Location = new System.Drawing.Point(198, 139);
            this.txtCPG.Name = "txtCPG";
            this.txtCPG.Size = new System.Drawing.Size(253, 27);
            this.txtCPG.TabIndex = 3;
            // 
            // btnCompanyUpdate
            // 
            this.btnCompanyUpdate.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnCompanyUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCompanyUpdate.Location = new System.Drawing.Point(357, 192);
            this.btnCompanyUpdate.Name = "btnCompanyUpdate";
            this.btnCompanyUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnCompanyUpdate.TabIndex = 4;
            this.btnCompanyUpdate.Text = "GÜNCELLE";
            this.btnCompanyUpdate.UseVisualStyleBackColor = false;
            this.btnCompanyUpdate.Click += new System.EventHandler(this.btnCompanyUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIDG);
            this.groupBox1.Controls.Add(this.lblIDG);
            this.groupBox1.Controls.Add(this.btnCompanyUpdate);
            this.groupBox1.Controls.Add(this.txtCPG);
            this.groupBox1.Controls.Add(this.txtCNG);
            this.groupBox1.Controls.Add(this.lblCompanyNameG);
            this.groupBox1.Controls.Add(this.lblCompanyPhoneG);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 227);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sahippers UPDATE";
            // 
            // txtIDG
            // 
            this.txtIDG.Location = new System.Drawing.Point(198, 47);
            this.txtIDG.Name = "txtIDG";
            this.txtIDG.Size = new System.Drawing.Size(253, 27);
            this.txtIDG.TabIndex = 6;
            // 
            // lblIDG
            // 
            this.lblIDG.AutoSize = true;
            this.lblIDG.Location = new System.Drawing.Point(32, 50);
            this.lblIDG.Name = "lblIDG";
            this.lblIDG.Size = new System.Drawing.Size(65, 20);
            this.lblIDG.TabIndex = 5;
            this.lblIDG.Text = "Şirket ID";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 267);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyPhoneG;
        private System.Windows.Forms.Label lblCompanyNameG;
        private System.Windows.Forms.TextBox txtCNG;
        private System.Windows.Forms.TextBox txtCPG;
        private System.Windows.Forms.Button btnCompanyUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIDG;
        private System.Windows.Forms.Label lblIDG;
    }
}
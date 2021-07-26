namespace WindowsFormsCLogin
{
    partial class ChangePassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnClearPass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewPassSave = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUpdatePassword = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdatePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSearchName);
            this.panel1.Controls.Add(this.btnClearPass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnNewPassSave);
            this.panel1.Controls.Add(this.txtNewPassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvUpdatePassword);
            this.panel1.Location = new System.Drawing.Point(43, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 319);
            this.panel1.TabIndex = 0;
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(124, 157);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(123, 20);
            this.txtSearchName.TabIndex = 14;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // btnClearPass
            // 
            this.btnClearPass.BackColor = System.Drawing.Color.Coral;
            this.btnClearPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPass.Location = new System.Drawing.Point(217, 93);
            this.btnClearPass.Name = "btnClearPass";
            this.btnClearPass.Size = new System.Drawing.Size(51, 23);
            this.btnClearPass.TabIndex = 12;
            this.btnClearPass.Text = "Clear";
            this.btnClearPass.UseVisualStyleBackColor = false;
            this.btnClearPass.Click += new System.EventHandler(this.btnClearPass_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Type Name";
            // 
            // btnNewPassSave
            // 
            this.btnNewPassSave.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnNewPassSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPassSave.Location = new System.Drawing.Point(145, 93);
            this.btnNewPassSave.Name = "btnNewPassSave";
            this.btnNewPassSave.Size = new System.Drawing.Size(54, 23);
            this.btnNewPassSave.TabIndex = 9;
            this.btnNewPassSave.Text = "Save";
            this.btnNewPassSave.UseVisualStyleBackColor = false;
            this.btnNewPassSave.Click += new System.EventHandler(this.btnNewPassSave_Click_1);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(145, 67);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(123, 20);
            this.txtNewPassword.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Type New Password";
            // 
            // dgvUpdatePassword
            // 
            this.dgvUpdatePassword.AllowUserToAddRows = false;
            this.dgvUpdatePassword.AllowUserToDeleteRows = false;
            this.dgvUpdatePassword.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvUpdatePassword.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.ID,
            this.Password});
            this.dgvUpdatePassword.Location = new System.Drawing.Point(50, 194);
            this.dgvUpdatePassword.Name = "dgvUpdatePassword";
            this.dgvUpdatePassword.ReadOnly = true;
            this.dgvUpdatePassword.Size = new System.Drawing.Size(243, 122);
            this.dgvUpdatePassword.TabIndex = 6;
            this.dgvUpdatePassword.DoubleClick += new System.EventHandler(this.dgvUpdatePassword_DoubleClick);
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 70;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 70;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password Change";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 379);
            this.Controls.Add(this.panel1);
          /*  this.Name = "ChangePassword";*/
            this.Text = "ChangePassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdatePassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClearPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewPassSave;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUpdatePassword;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.Label label3;
    }
}
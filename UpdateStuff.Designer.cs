namespace WindowsFormsCLogin
{
    partial class UpdateStuff
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.cmbStuffRole = new System.Windows.Forms.ComboBox();
            this.cmbStuffGender = new System.Windows.Forms.ComboBox();
            this.txtStuffPassword = new System.Windows.Forms.TextBox();
            this.txtStuffMobileNo = new System.Windows.Forms.TextBox();
            this.dtpStuffDoB = new System.Windows.Forms.DateTimePicker();
            this.txtStuffId = new System.Windows.Forms.TextBox();
            this.txtStuffName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInformation = new System.Windows.Forms.DataGridView();
            this.StuffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddStuff = new System.Windows.Forms.Button();
            this.btnRemoveStuff = new System.Windows.Forms.Button();
            this.btnStuffDetails = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtAutoSearch);
            this.panel1.Controls.Add(this.cmbStuffRole);
            this.panel1.Controls.Add(this.cmbStuffGender);
            this.panel1.Controls.Add(this.txtStuffPassword);
            this.panel1.Controls.Add(this.txtStuffMobileNo);
            this.panel1.Controls.Add(this.dtpStuffDoB);
            this.panel1.Controls.Add(this.txtStuffId);
            this.panel1.Controls.Add(this.txtStuffName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvInformation);
            this.panel1.Controls.Add(this.btnAddStuff);
            this.panel1.Controls.Add(this.btnRemoveStuff);
            this.panel1.Controls.Add(this.btnStuffDetails);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 499);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.IndianRed;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(373, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Auto Search";
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Location = new System.Drawing.Point(267, 227);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(100, 20);
            this.txtAutoSearch.TabIndex = 19;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // cmbStuffRole
            // 
            this.cmbStuffRole.FormattingEnabled = true;
            this.cmbStuffRole.Items.AddRange(new object[] {
            "stuff"});
            this.cmbStuffRole.Location = new System.Drawing.Point(82, 73);
            this.cmbStuffRole.Name = "cmbStuffRole";
            this.cmbStuffRole.Size = new System.Drawing.Size(63, 21);
            this.cmbStuffRole.TabIndex = 18;
            // 
            // cmbStuffGender
            // 
            this.cmbStuffGender.FormattingEnabled = true;
            this.cmbStuffGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbStuffGender.Location = new System.Drawing.Point(82, 176);
            this.cmbStuffGender.Name = "cmbStuffGender";
            this.cmbStuffGender.Size = new System.Drawing.Size(63, 21);
            this.cmbStuffGender.TabIndex = 17;
            // 
            // txtStuffPassword
            // 
            this.txtStuffPassword.Location = new System.Drawing.Point(82, 150);
            this.txtStuffPassword.Name = "txtStuffPassword";
            this.txtStuffPassword.Size = new System.Drawing.Size(100, 20);
            this.txtStuffPassword.TabIndex = 16;
            // 
            // txtStuffMobileNo
            // 
            this.txtStuffMobileNo.Location = new System.Drawing.Point(82, 125);
            this.txtStuffMobileNo.Name = "txtStuffMobileNo";
            this.txtStuffMobileNo.Size = new System.Drawing.Size(100, 20);
            this.txtStuffMobileNo.TabIndex = 15;
            // 
            // dtpStuffDoB
            // 
            this.dtpStuffDoB.CustomFormat = "YYYY-MM-DD";
            this.dtpStuffDoB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStuffDoB.Location = new System.Drawing.Point(82, 100);
            this.dtpStuffDoB.Name = "dtpStuffDoB";
            this.dtpStuffDoB.Size = new System.Drawing.Size(100, 20);
            this.dtpStuffDoB.TabIndex = 14;
            // 
            // txtStuffId
            // 
            this.txtStuffId.Location = new System.Drawing.Point(82, 47);
            this.txtStuffId.Name = "txtStuffId";
            this.txtStuffId.Size = new System.Drawing.Size(100, 20);
            this.txtStuffId.TabIndex = 13;
            // 
            // txtStuffName
            // 
            this.txtStuffName.Location = new System.Drawing.Point(82, 20);
            this.txtStuffName.Name = "txtStuffName";
            this.txtStuffName.Size = new System.Drawing.Size(100, 20);
            this.txtStuffName.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "MobileNo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "DoB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = " Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = " Name";
            // 
            // dgvInformation
            // 
            this.dgvInformation.AllowUserToAddRows = false;
            this.dgvInformation.AllowUserToDeleteRows = false;
            this.dgvInformation.BackgroundColor = System.Drawing.Color.DarkOliveGreen;
            this.dgvInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StuffName,
            this.ID,
            this.Password,
            this.Role,
            this.Gender,
            this.DoB,
            this.MobileNo});
            this.dgvInformation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvInformation.Location = new System.Drawing.Point(0, 278);
            this.dgvInformation.Name = "dgvInformation";
            this.dgvInformation.ReadOnly = true;
            this.dgvInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInformation.Size = new System.Drawing.Size(733, 221);
            this.dgvInformation.TabIndex = 4;
            // 
            // StuffName
            // 
            this.StuffName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StuffName.DataPropertyName = "Name";
            this.StuffName.HeaderText = "Name";
            this.StuffName.Name = "StuffName";
            this.StuffName.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // DoB
            // 
            this.DoB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DoB.DataPropertyName = "DoB";
            this.DoB.HeaderText = "DoB";
            this.DoB.Name = "DoB";
            this.DoB.ReadOnly = true;
            // 
            // MobileNo
            // 
            this.MobileNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MobileNo.DataPropertyName = "MobileNo";
            this.MobileNo.HeaderText = "MobileNo";
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.ReadOnly = true;
            // 
            // btnAddStuff
            // 
            this.btnAddStuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStuff.Location = new System.Drawing.Point(226, 20);
            this.btnAddStuff.Name = "btnAddStuff";
            this.btnAddStuff.Size = new System.Drawing.Size(96, 40);
            this.btnAddStuff.TabIndex = 3;
            this.btnAddStuff.Text = "Add Stuff";
            this.btnAddStuff.UseVisualStyleBackColor = true;
            this.btnAddStuff.Click += new System.EventHandler(this.btnAddStuff_Click);
            this.btnAddStuff.MouseLeave += new System.EventHandler(this.btnAddStuff_MouseLeave);
            this.btnAddStuff.MouseHover += new System.EventHandler(this.btnAddStuff_MouseHover);
            // 
            // btnRemoveStuff
            // 
            this.btnRemoveStuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStuff.Location = new System.Drawing.Point(340, 20);
            this.btnRemoveStuff.Name = "btnRemoveStuff";
            this.btnRemoveStuff.Size = new System.Drawing.Size(96, 40);
            this.btnRemoveStuff.TabIndex = 2;
            this.btnRemoveStuff.Text = "Remove Stuff";
            this.btnRemoveStuff.UseVisualStyleBackColor = true;
            this.btnRemoveStuff.Click += new System.EventHandler(this.btnRemoveStuff_Click);
            this.btnRemoveStuff.MouseLeave += new System.EventHandler(this.btnRemoveStuff_MouseLeave);
            this.btnRemoveStuff.MouseHover += new System.EventHandler(this.btnRemoveStuff_MouseHover);
            // 
            // btnStuffDetails
            // 
            this.btnStuffDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStuffDetails.Location = new System.Drawing.Point(628, 225);
            this.btnStuffDetails.Name = "btnStuffDetails";
            this.btnStuffDetails.Size = new System.Drawing.Size(96, 23);
            this.btnStuffDetails.TabIndex = 1;
            this.btnStuffDetails.Text = " Stuff Details";
            this.btnStuffDetails.UseVisualStyleBackColor = true;
            this.btnStuffDetails.Click += new System.EventHandler(this.btnStuffDetails_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(646, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // UpdateStuff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 504);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateStuff";
            this.Text = "UpdateStuff";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddStuff;
        private System.Windows.Forms.Button btnRemoveStuff;
        private System.Windows.Forms.DataGridView dgvInformation;
        private System.Windows.Forms.Button btnStuffDetails;
        private System.Windows.Forms.ComboBox cmbStuffRole;
        private System.Windows.Forms.ComboBox cmbStuffGender;
        private System.Windows.Forms.TextBox txtStuffPassword;
        private System.Windows.Forms.TextBox txtStuffMobileNo;
        private System.Windows.Forms.DateTimePicker dtpStuffDoB;
        private System.Windows.Forms.TextBox txtStuffId;
        private System.Windows.Forms.TextBox txtStuffName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAutoSearch;
    }
}
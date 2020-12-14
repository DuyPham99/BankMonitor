namespace BankMonitor.views
{
    partial class UCStaff
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDistributeStaff = new System.Windows.Forms.ComboBox();
            this.btnCancelStaff = new System.Windows.Forms.Button();
            this.btnChangeStaff = new System.Windows.Forms.Button();
            this.btnDeletepnStaff = new System.Windows.Forms.Button();
            this.btnAddpnStaff = new System.Windows.Forms.Button();
            this.tbPhoneNumberStaff = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAddressStaff = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLastNameStaff = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFirstNameStaff = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIdStaff = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.IdpnStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDistribute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDistributeStaff);
            this.groupBox1.Controls.Add(this.btnCancelStaff);
            this.groupBox1.Controls.Add(this.btnChangeStaff);
            this.groupBox1.Controls.Add(this.btnDeletepnStaff);
            this.groupBox1.Controls.Add(this.btnAddpnStaff);
            this.groupBox1.Controls.Add(this.tbPhoneNumberStaff);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.rdbtnFemale);
            this.groupBox1.Controls.Add(this.rdbtnMale);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbAddressStaff);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbLastNameStaff);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbFirstNameStaff);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbIdStaff);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(53, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 301);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // cbDistributeStaff
            // 
            this.cbDistributeStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDistributeStaff.FormattingEnabled = true;
            this.cbDistributeStaff.Location = new System.Drawing.Point(322, 38);
            this.cbDistributeStaff.Name = "cbDistributeStaff";
            this.cbDistributeStaff.Size = new System.Drawing.Size(101, 21);
            this.cbDistributeStaff.TabIndex = 20;
            // 
            // btnCancelStaff
            // 
            this.btnCancelStaff.Location = new System.Drawing.Point(333, 238);
            this.btnCancelStaff.Name = "btnCancelStaff";
            this.btnCancelStaff.Size = new System.Drawing.Size(75, 23);
            this.btnCancelStaff.TabIndex = 19;
            this.btnCancelStaff.Text = "Hủy bỏ";
            this.btnCancelStaff.UseVisualStyleBackColor = true;
            this.btnCancelStaff.Click += new System.EventHandler(this.btnCancelStaff_Click);
            // 
            // btnChangeStaff
            // 
            this.btnChangeStaff.Location = new System.Drawing.Point(237, 238);
            this.btnChangeStaff.Name = "btnChangeStaff";
            this.btnChangeStaff.Size = new System.Drawing.Size(75, 23);
            this.btnChangeStaff.TabIndex = 18;
            this.btnChangeStaff.Text = "Sửa";
            this.btnChangeStaff.UseVisualStyleBackColor = true;
            this.btnChangeStaff.Click += new System.EventHandler(this.btnChangeStaff_Click);
            // 
            // btnDeletepnStaff
            // 
            this.btnDeletepnStaff.Location = new System.Drawing.Point(139, 238);
            this.btnDeletepnStaff.Name = "btnDeletepnStaff";
            this.btnDeletepnStaff.Size = new System.Drawing.Size(75, 23);
            this.btnDeletepnStaff.TabIndex = 17;
            this.btnDeletepnStaff.Text = "Xóa";
            this.btnDeletepnStaff.UseVisualStyleBackColor = true;
            this.btnDeletepnStaff.Click += new System.EventHandler(this.btnDeletepnStaff_Click);
            // 
            // btnAddpnStaff
            // 
            this.btnAddpnStaff.Location = new System.Drawing.Point(44, 238);
            this.btnAddpnStaff.Name = "btnAddpnStaff";
            this.btnAddpnStaff.Size = new System.Drawing.Size(75, 23);
            this.btnAddpnStaff.TabIndex = 16;
            this.btnAddpnStaff.Text = "Thêm";
            this.btnAddpnStaff.UseVisualStyleBackColor = true;
            this.btnAddpnStaff.Click += new System.EventHandler(this.btnAddpnStaff_Click);
            // 
            // tbPhoneNumberStaff
            // 
            this.tbPhoneNumberStaff.Location = new System.Drawing.Point(103, 187);
            this.tbPhoneNumberStaff.Name = "tbPhoneNumberStaff";
            this.tbPhoneNumberStaff.Size = new System.Drawing.Size(320, 20);
            this.tbPhoneNumberStaff.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "SĐT";
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Location = new System.Drawing.Point(298, 159);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(39, 17);
            this.rdbtnFemale.TabIndex = 12;
            this.rdbtnFemale.TabStop = true;
            this.rdbtnFemale.Text = "Nữ";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Location = new System.Drawing.Point(164, 158);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(47, 17);
            this.rdbtnMale.TabIndex = 11;
            this.rdbtnMale.TabStop = true;
            this.rdbtnMale.Text = "Nam";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Phái";
            // 
            // tbAddressStaff
            // 
            this.tbAddressStaff.Location = new System.Drawing.Point(102, 123);
            this.tbAddressStaff.Name = "tbAddressStaff";
            this.tbAddressStaff.Size = new System.Drawing.Size(320, 20);
            this.tbAddressStaff.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Địa chỉ";
            // 
            // tbLastNameStaff
            // 
            this.tbLastNameStaff.Location = new System.Drawing.Point(322, 83);
            this.tbLastNameStaff.Name = "tbLastNameStaff";
            this.tbLastNameStaff.Size = new System.Drawing.Size(100, 20);
            this.tbLastNameStaff.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(258, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên";
            // 
            // tbFirstNameStaff
            // 
            this.tbFirstNameStaff.Location = new System.Drawing.Point(102, 82);
            this.tbFirstNameStaff.Name = "tbFirstNameStaff";
            this.tbFirstNameStaff.Size = new System.Drawing.Size(150, 20);
            this.tbFirstNameStaff.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Họ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã CN";
            // 
            // tbIdStaff
            // 
            this.tbIdStaff.Location = new System.Drawing.Point(102, 40);
            this.tbIdStaff.Name = "tbIdStaff";
            this.tbIdStaff.Size = new System.Drawing.Size(100, 20);
            this.tbIdStaff.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV";
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToResizeColumns = false;
            this.dgvStaff.AllowUserToResizeRows = false;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdpnStaff,
            this.IdDistribute,
            this.firstName,
            this.lastName,
            this.address,
            this.sex,
            this.phoneNumber});
            this.dgvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStaff.Location = new System.Drawing.Point(3, 16);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.Size = new System.Drawing.Size(589, 295);
            this.dgvStaff.TabIndex = 5;
            this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellContentClick);
            this.dgvStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellContentClick);
            // 
            // IdpnStaff
            // 
            this.IdpnStaff.HeaderText = "Mã NV";
            this.IdpnStaff.Name = "IdpnStaff";
            this.IdpnStaff.ReadOnly = true;
            // 
            // IdDistribute
            // 
            this.IdDistribute.HeaderText = "Mã CN";
            this.IdDistribute.Name = "IdDistribute";
            this.IdDistribute.ReadOnly = true;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "Họ";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Tên";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "Địa chỉ";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // sex
            // 
            this.sex.HeaderText = "Phái";
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            // 
            // phoneNumber
            // 
            this.phoneNumber.HeaderText = "SĐT";
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvStaff);
            this.groupBox2.Location = new System.Drawing.Point(588, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 314);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // UCStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCStaff";
            this.Size = new System.Drawing.Size(1210, 440);
            this.Load += new System.EventHandler(this.UCStaff_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelStaff;
        private System.Windows.Forms.Button btnChangeStaff;
        private System.Windows.Forms.Button btnDeletepnStaff;
        private System.Windows.Forms.Button btnAddpnStaff;
        private System.Windows.Forms.TextBox tbPhoneNumberStaff;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdbtnFemale;
        private System.Windows.Forms.RadioButton rdbtnMale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAddressStaff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLastNameStaff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFirstNameStaff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIdStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdpnStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDistribute;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbDistributeStaff;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

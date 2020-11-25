namespace BankMonitor.views
{
    partial class UCCustomer
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
            this.gbListCustomer = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.IdCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateIdCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstNameCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumberCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SexCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDistributeCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.gbCustomerMonitor = new System.Windows.Forms.GroupBox();
            this.btnCancelCustomer = new System.Windows.Forms.Button();
            this.btnChangeCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.rdbtnFemaleCustomer = new System.Windows.Forms.RadioButton();
            this.rdbtnMaleCustomer = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.tbPhoneNumberCustomer = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpDateIdCustomer = new System.Windows.Forms.DateTimePicker();
            this.tbAddressCustomer = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbLastNameCustomer = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbFirstNameCustomer = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbIdDistributeCustomer = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbIdCustomer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gbListCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gbCustomerMonitor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListCustomer
            // 
            this.gbListCustomer.Controls.Add(this.dataGridView2);
            this.gbListCustomer.Location = new System.Drawing.Point(588, 82);
            this.gbListCustomer.Name = "gbListCustomer";
            this.gbListCustomer.Size = new System.Drawing.Size(595, 314);
            this.gbListCustomer.TabIndex = 5;
            this.gbListCustomer.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCustomer,
            this.DateIdCustomer,
            this.FirstNameCustomer,
            this.LastNameCustomer,
            this.AddressCustomer,
            this.PhoneNumberCustomer,
            this.SexCustomer,
            this.IdDistributeCustomer});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(589, 295);
            this.dataGridView2.TabIndex = 0;
            // 
            // IdCustomer
            // 
            this.IdCustomer.HeaderText = "CMND";
            this.IdCustomer.Name = "IdCustomer";
            // 
            // DateIdCustomer
            // 
            this.DateIdCustomer.HeaderText = "Ngày cấp";
            this.DateIdCustomer.Name = "DateIdCustomer";
            // 
            // FirstNameCustomer
            // 
            this.FirstNameCustomer.HeaderText = "Họ";
            this.FirstNameCustomer.Name = "FirstNameCustomer";
            // 
            // LastNameCustomer
            // 
            this.LastNameCustomer.HeaderText = "Tên";
            this.LastNameCustomer.Name = "LastNameCustomer";
            // 
            // AddressCustomer
            // 
            this.AddressCustomer.HeaderText = "Địa chỉ";
            this.AddressCustomer.Name = "AddressCustomer";
            // 
            // PhoneNumberCustomer
            // 
            this.PhoneNumberCustomer.HeaderText = "SĐT";
            this.PhoneNumberCustomer.Name = "PhoneNumberCustomer";
            // 
            // SexCustomer
            // 
            this.SexCustomer.HeaderText = "Phái";
            this.SexCustomer.Name = "SexCustomer";
            // 
            // IdDistributeCustomer
            // 
            this.IdDistributeCustomer.HeaderText = "Mã CN";
            this.IdDistributeCustomer.Name = "IdDistributeCustomer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(194, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(256, 24);
            this.label9.TabIndex = 7;
            this.label9.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // gbCustomerMonitor
            // 
            this.gbCustomerMonitor.Controls.Add(this.btnCancelCustomer);
            this.gbCustomerMonitor.Controls.Add(this.btnChangeCustomer);
            this.gbCustomerMonitor.Controls.Add(this.btnDeleteCustomer);
            this.gbCustomerMonitor.Controls.Add(this.btnAddCustomer);
            this.gbCustomerMonitor.Controls.Add(this.rdbtnFemaleCustomer);
            this.gbCustomerMonitor.Controls.Add(this.rdbtnMaleCustomer);
            this.gbCustomerMonitor.Controls.Add(this.label17);
            this.gbCustomerMonitor.Controls.Add(this.tbPhoneNumberCustomer);
            this.gbCustomerMonitor.Controls.Add(this.label16);
            this.gbCustomerMonitor.Controls.Add(this.label15);
            this.gbCustomerMonitor.Controls.Add(this.dtpDateIdCustomer);
            this.gbCustomerMonitor.Controls.Add(this.tbAddressCustomer);
            this.gbCustomerMonitor.Controls.Add(this.label14);
            this.gbCustomerMonitor.Controls.Add(this.tbLastNameCustomer);
            this.gbCustomerMonitor.Controls.Add(this.label13);
            this.gbCustomerMonitor.Controls.Add(this.tbFirstNameCustomer);
            this.gbCustomerMonitor.Controls.Add(this.label12);
            this.gbCustomerMonitor.Controls.Add(this.tbIdDistributeCustomer);
            this.gbCustomerMonitor.Controls.Add(this.label11);
            this.gbCustomerMonitor.Controls.Add(this.tbIdCustomer);
            this.gbCustomerMonitor.Controls.Add(this.label10);
            this.gbCustomerMonitor.Location = new System.Drawing.Point(53, 92);
            this.gbCustomerMonitor.Name = "gbCustomerMonitor";
            this.gbCustomerMonitor.Size = new System.Drawing.Size(500, 301);
            this.gbCustomerMonitor.TabIndex = 6;
            this.gbCustomerMonitor.TabStop = false;
            // 
            // btnCancelCustomer
            // 
            this.btnCancelCustomer.Location = new System.Drawing.Point(356, 252);
            this.btnCancelCustomer.Name = "btnCancelCustomer";
            this.btnCancelCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnCancelCustomer.TabIndex = 20;
            this.btnCancelCustomer.Text = "Hủy bỏ";
            this.btnCancelCustomer.UseVisualStyleBackColor = true;
            // 
            // btnChangeCustomer
            // 
            this.btnChangeCustomer.Location = new System.Drawing.Point(255, 252);
            this.btnChangeCustomer.Name = "btnChangeCustomer";
            this.btnChangeCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnChangeCustomer.TabIndex = 19;
            this.btnChangeCustomer.Text = "Sửa";
            this.btnChangeCustomer.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(145, 252);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCustomer.TabIndex = 18;
            this.btnDeleteCustomer.Text = "Xóa";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(31, 253);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnAddCustomer.TabIndex = 17;
            this.btnAddCustomer.Text = "Thêm";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // rdbtnFemaleCustomer
            // 
            this.rdbtnFemaleCustomer.AutoSize = true;
            this.rdbtnFemaleCustomer.Location = new System.Drawing.Point(384, 205);
            this.rdbtnFemaleCustomer.Name = "rdbtnFemaleCustomer";
            this.rdbtnFemaleCustomer.Size = new System.Drawing.Size(39, 17);
            this.rdbtnFemaleCustomer.TabIndex = 16;
            this.rdbtnFemaleCustomer.TabStop = true;
            this.rdbtnFemaleCustomer.Text = "Nữ";
            this.rdbtnFemaleCustomer.UseVisualStyleBackColor = true;
            // 
            // rdbtnMaleCustomer
            // 
            this.rdbtnMaleCustomer.AutoSize = true;
            this.rdbtnMaleCustomer.Location = new System.Drawing.Point(313, 205);
            this.rdbtnMaleCustomer.Name = "rdbtnMaleCustomer";
            this.rdbtnMaleCustomer.Size = new System.Drawing.Size(47, 17);
            this.rdbtnMaleCustomer.TabIndex = 15;
            this.rdbtnMaleCustomer.TabStop = true;
            this.rdbtnMaleCustomer.Text = "Nam";
            this.rdbtnMaleCustomer.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(255, 205);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 19);
            this.label17.TabIndex = 14;
            this.label17.Text = "Phái";
            // 
            // tbPhoneNumberCustomer
            // 
            this.tbPhoneNumberCustomer.Location = new System.Drawing.Point(96, 162);
            this.tbPhoneNumberCustomer.Name = "tbPhoneNumberCustomer";
            this.tbPhoneNumberCustomer.Size = new System.Drawing.Size(323, 20);
            this.tbPhoneNumberCustomer.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(34, 162);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 19);
            this.label16.TabIndex = 12;
            this.label16.Text = "SĐT";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(253, 122);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 19);
            this.label15.TabIndex = 11;
            this.label15.Text = "Ngày cấp";
            // 
            // dtpDateIdCustomer
            // 
            this.dtpDateIdCustomer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtpDateIdCustomer.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateIdCustomer.Location = new System.Drawing.Point(321, 122);
            this.dtpDateIdCustomer.Name = "dtpDateIdCustomer";
            this.dtpDateIdCustomer.Size = new System.Drawing.Size(98, 20);
            this.dtpDateIdCustomer.TabIndex = 10;
            // 
            // tbAddressCustomer
            // 
            this.tbAddressCustomer.Location = new System.Drawing.Point(96, 81);
            this.tbAddressCustomer.Name = "tbAddressCustomer";
            this.tbAddressCustomer.Size = new System.Drawing.Size(323, 20);
            this.tbAddressCustomer.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(33, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 19);
            this.label14.TabIndex = 8;
            this.label14.Text = "Địa chỉ";
            // 
            // tbLastNameCustomer
            // 
            this.tbLastNameCustomer.Location = new System.Drawing.Point(319, 43);
            this.tbLastNameCustomer.Name = "tbLastNameCustomer";
            this.tbLastNameCustomer.Size = new System.Drawing.Size(100, 20);
            this.tbLastNameCustomer.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(256, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 19);
            this.label13.TabIndex = 6;
            this.label13.Text = "Tên";
            // 
            // tbFirstNameCustomer
            // 
            this.tbFirstNameCustomer.Location = new System.Drawing.Point(94, 42);
            this.tbFirstNameCustomer.Name = "tbFirstNameCustomer";
            this.tbFirstNameCustomer.Size = new System.Drawing.Size(155, 20);
            this.tbFirstNameCustomer.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 19);
            this.label12.TabIndex = 4;
            this.label12.Text = "Họ";
            // 
            // tbIdDistributeCustomer
            // 
            this.tbIdDistributeCustomer.Location = new System.Drawing.Point(96, 204);
            this.tbIdDistributeCustomer.Name = "tbIdDistributeCustomer";
            this.tbIdDistributeCustomer.Size = new System.Drawing.Size(98, 20);
            this.tbIdDistributeCustomer.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "Mã CN";
            // 
            // tbIdCustomer
            // 
            this.tbIdCustomer.Location = new System.Drawing.Point(94, 122);
            this.tbIdCustomer.Name = "tbIdCustomer";
            this.tbIdCustomer.Size = new System.Drawing.Size(151, 20);
            this.tbIdCustomer.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "CMND";
            // 
            // UCCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gbCustomerMonitor);
            this.Controls.Add(this.gbListCustomer);
            this.Name = "UCCustomer";
            this.Size = new System.Drawing.Size(1217, 437);
            this.gbListCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gbCustomerMonitor.ResumeLayout(false);
            this.gbCustomerMonitor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListCustomer;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateIdCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumberCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn SexCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDistributeCustomer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbCustomerMonitor;
        private System.Windows.Forms.Button btnCancelCustomer;
        private System.Windows.Forms.Button btnChangeCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.RadioButton rdbtnFemaleCustomer;
        private System.Windows.Forms.RadioButton rdbtnMaleCustomer;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbPhoneNumberCustomer;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpDateIdCustomer;
        private System.Windows.Forms.TextBox tbAddressCustomer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbLastNameCustomer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbFirstNameCustomer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbIdDistributeCustomer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbIdCustomer;
        private System.Windows.Forms.Label label10;
    }
}

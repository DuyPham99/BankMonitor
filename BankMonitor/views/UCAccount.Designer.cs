namespace BankMonitor.views
{
    partial class UCAccount
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelAccount = new System.Windows.Forms.Button();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btAddAccount = new System.Windows.Forms.Button();
            this.cbDistributeAccount = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDateAccount = new System.Windows.Forms.TextBox();
            this.tbAmountAccount = new System.Windows.Forms.TextBox();
            this.tbIdentityAccount = new System.Windows.Forms.TextBox();
            this.tbIdAccount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.NGAYMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SODU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MACN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.uCAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uCAccountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelAccount);
            this.groupBox1.Controls.Add(this.btnUpdateAccount);
            this.groupBox1.Controls.Add(this.btnDeleteAccount);
            this.groupBox1.Controls.Add(this.btAddAccount);
            this.groupBox1.Controls.Add(this.cbDistributeAccount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbDateAccount);
            this.groupBox1.Controls.Add(this.tbAmountAccount);
            this.groupBox1.Controls.Add(this.tbIdentityAccount);
            this.groupBox1.Controls.Add(this.tbIdAccount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(53, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCancelAccount
            // 
            this.btnCancelAccount.Location = new System.Drawing.Point(358, 232);
            this.btnCancelAccount.Name = "btnCancelAccount";
            this.btnCancelAccount.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAccount.TabIndex = 16;
            this.btnCancelAccount.Text = "Hủy bỏ";
            this.btnCancelAccount.UseVisualStyleBackColor = true;
            this.btnCancelAccount.Click += new System.EventHandler(this.btnCancelAccount_Click);
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Location = new System.Drawing.Point(266, 232);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateAccount.TabIndex = 15;
            this.btnUpdateAccount.Text = "Sửa";
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(172, 232);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAccount.TabIndex = 14;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btAddAccount
            // 
            this.btAddAccount.Location = new System.Drawing.Point(80, 232);
            this.btAddAccount.Name = "btAddAccount";
            this.btAddAccount.Size = new System.Drawing.Size(75, 23);
            this.btAddAccount.TabIndex = 13;
            this.btAddAccount.Text = "Thêm";
            this.btAddAccount.UseVisualStyleBackColor = true;
            this.btAddAccount.Click += new System.EventHandler(this.btAddAccount_Click);
            // 
            // cbDistributeAccount
            // 
            this.cbDistributeAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDistributeAccount.FormattingEnabled = true;
            this.cbDistributeAccount.Location = new System.Drawing.Point(337, 179);
            this.cbDistributeAccount.Name = "cbDistributeAccount";
            this.cbDistributeAccount.Size = new System.Drawing.Size(97, 21);
            this.cbDistributeAccount.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(274, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mã CN";
            // 
            // tbDateAccount
            // 
            this.tbDateAccount.Location = new System.Drawing.Point(131, 180);
            this.tbDateAccount.Name = "tbDateAccount";
            this.tbDateAccount.ReadOnly = true;
            this.tbDateAccount.Size = new System.Drawing.Size(131, 20);
            this.tbDateAccount.TabIndex = 10;
            // 
            // tbAmountAccount
            // 
            this.tbAmountAccount.Location = new System.Drawing.Point(120, 137);
            this.tbAmountAccount.Name = "tbAmountAccount";
            this.tbAmountAccount.Size = new System.Drawing.Size(325, 20);
            this.tbAmountAccount.TabIndex = 9;
            this.tbAmountAccount.TextChanged += new System.EventHandler(this.tbAmountAccount_TextChanged);
            this.tbAmountAccount.Validating += new System.ComponentModel.CancelEventHandler(this.tbAmountAccount_Validating);
            // 
            // tbIdentityAccount
            // 
            this.tbIdentityAccount.Location = new System.Drawing.Point(120, 87);
            this.tbIdentityAccount.Name = "tbIdentityAccount";
            this.tbIdentityAccount.Size = new System.Drawing.Size(325, 20);
            this.tbIdentityAccount.TabIndex = 8;
            this.tbIdentityAccount.Validating += new System.ComponentModel.CancelEventHandler(this.tbIdentityAccount_Validating);
            // 
            // tbIdAccount
            // 
            this.tbIdAccount.Location = new System.Drawing.Point(120, 39);
            this.tbIdAccount.Name = "tbIdAccount";
            this.tbIdAccount.Size = new System.Drawing.Size(325, 20);
            this.tbIdAccount.TabIndex = 7;
            this.tbIdAccount.TextChanged += new System.EventHandler(this.tbIdAccount_TextChanged);
            this.tbIdAccount.Validating += new System.ComponentModel.CancelEventHandler(this.tbIdAccount_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày mở";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số dư";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "CMND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số TK";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAccount);
            this.groupBox2.Location = new System.Drawing.Point(588, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 314);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NGAYMO,
            this.SOTK,
            this.CMND,
            this.SODU,
            this.MACN});
            this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccount.Location = new System.Drawing.Point(3, 16);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.Size = new System.Drawing.Size(543, 295);
            this.dgvAccount.TabIndex = 0;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellContentClick);
            this.dgvAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellContentClick);
            // 
            // NGAYMO
            // 
            this.NGAYMO.FillWeight = 21F;
            this.NGAYMO.HeaderText = "Ngày mở";
            this.NGAYMO.Name = "NGAYMO";
            this.NGAYMO.ReadOnly = true;
            this.NGAYMO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NGAYMO.Width = 125;
            // 
            // SOTK
            // 
            this.SOTK.FillWeight = 62.19413F;
            this.SOTK.HeaderText = "Số TK";
            this.SOTK.Name = "SOTK";
            this.SOTK.ReadOnly = true;
            // 
            // CMND
            // 
            this.CMND.FillWeight = 101.6581F;
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            // 
            // SODU
            // 
            this.SODU.FillWeight = 139.4646F;
            this.SODU.HeaderText = "Số dư";
            this.SODU.Name = "SODU";
            this.SODU.ReadOnly = true;
            // 
            // MACN
            // 
            this.MACN.FillWeight = 175.6832F;
            this.MACN.HeaderText = "Mã CN";
            this.MACN.Name = "MACN";
            this.MACN.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Undo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Redo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UCAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCAccount";
            this.Size = new System.Drawing.Size(1210, 440);
            this.Load += new System.EventHandler(this.UCAccount_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uCAccountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbIdAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cbDistributeAccount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDateAccount;
        private System.Windows.Forms.TextBox tbAmountAccount;
        private System.Windows.Forms.TextBox tbIdentityAccount;
        private System.Windows.Forms.Button btnCancelAccount;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btAddAccount;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.BindingSource uCAccountBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn SODU;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACN;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

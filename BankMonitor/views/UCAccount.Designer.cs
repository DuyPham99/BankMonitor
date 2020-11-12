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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIdAccount = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tbCMNDAccount = new System.Windows.Forms.TextBox();
            this.tbBalanceAccount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDateAccount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.idDistributeAccount = new System.Windows.Forms.ComboBox();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnChangeAccount = new System.Windows.Forms.Button();
            this.btnCancelAccount = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCustomerAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distributeAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelAccount);
            this.groupBox1.Controls.Add(this.btnChangeAccount);
            this.groupBox1.Controls.Add(this.btnDeleteAccount);
            this.groupBox1.Controls.Add(this.btnAddAccount);
            this.groupBox1.Controls.Add(this.idDistributeAccount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbDateAccount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbBalanceAccount);
            this.groupBox1.Controls.Add(this.tbCMNDAccount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbIdAccount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(46, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 293);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(653, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 293);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số TK";
            // 
            // tbIdAccount
            // 
            this.tbIdAccount.AllowDrop = true;
            this.tbIdAccount.Location = new System.Drawing.Point(118, 39);
            this.tbIdAccount.Name = "tbIdAccount";
            this.tbIdAccount.Size = new System.Drawing.Size(361, 20);
            this.tbIdAccount.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "CMND";
            // 
            // tbCMNDAccount
            // 
            this.tbCMNDAccount.Location = new System.Drawing.Point(118, 88);
            this.tbCMNDAccount.Name = "tbCMNDAccount";
            this.tbCMNDAccount.Size = new System.Drawing.Size(361, 20);
            this.tbCMNDAccount.TabIndex = 4;
            // 
            // tbBalanceAccount
            // 
            this.tbBalanceAccount.Location = new System.Drawing.Point(118, 136);
            this.tbBalanceAccount.Name = "tbBalanceAccount";
            this.tbBalanceAccount.Size = new System.Drawing.Size(361, 20);
            this.tbBalanceAccount.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số dư";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày mở";
            // 
            // tbDateAccount
            // 
            this.tbDateAccount.Location = new System.Drawing.Point(139, 181);
            this.tbDateAccount.Name = "tbDateAccount";
            this.tbDateAccount.ReadOnly = true;
            this.tbDateAccount.Size = new System.Drawing.Size(110, 20);
            this.tbDateAccount.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(288, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mã CN";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // idDistributeAccount
            // 
            this.idDistributeAccount.FormattingEnabled = true;
            this.idDistributeAccount.Items.AddRange(new object[] {
            "BẾN THÀNH",
            "TÂN ĐỊNH"});
            this.idDistributeAccount.Location = new System.Drawing.Point(351, 180);
            this.idDistributeAccount.Name = "idDistributeAccount";
            this.idDistributeAccount.Size = new System.Drawing.Size(105, 21);
            this.idDistributeAccount.TabIndex = 10;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(82, 233);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(84, 26);
            this.btnAddAccount.TabIndex = 11;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(181, 233);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(84, 26);
            this.btnDeleteAccount.TabIndex = 13;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btnChangeAccount
            // 
            this.btnChangeAccount.Location = new System.Drawing.Point(282, 233);
            this.btnChangeAccount.Name = "btnChangeAccount";
            this.btnChangeAccount.Size = new System.Drawing.Size(84, 26);
            this.btnChangeAccount.TabIndex = 14;
            this.btnChangeAccount.Text = "Sửa";
            this.btnChangeAccount.UseVisualStyleBackColor = true;
            // 
            // btnCancelAccount
            // 
            this.btnCancelAccount.Location = new System.Drawing.Point(374, 233);
            this.btnCancelAccount.Name = "btnCancelAccount";
            this.btnCancelAccount.Size = new System.Drawing.Size(84, 26);
            this.btnCancelAccount.TabIndex = 15;
            this.btnCancelAccount.Text = "Hủy bỏ";
            this.btnCancelAccount.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAccount,
            this.dateAccount,
            this.idCustomerAccount,
            this.balanceAccount,
            this.distributeAccount});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(518, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // idAccount
            // 
            this.idAccount.HeaderText = "Số tài khoản";
            this.idAccount.Name = "idAccount";
            // 
            // dateAccount
            // 
            this.dateAccount.HeaderText = "Ngày mở";
            this.dateAccount.Name = "dateAccount";
            // 
            // idCustomerAccount
            // 
            this.idCustomerAccount.HeaderText = "CMND";
            this.idCustomerAccount.Name = "idCustomerAccount";
            // 
            // balanceAccount
            // 
            this.balanceAccount.HeaderText = "Số dư";
            this.balanceAccount.Name = "balanceAccount";
            // 
            // distributeAccount
            // 
            this.distributeAccount.HeaderText = "Mã chi nhánh";
            this.distributeAccount.Name = "distributeAccount";
            // 
            // UCAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "UCAccount";
            this.Size = new System.Drawing.Size(1226, 437);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbIdAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDateAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBalanceAccount;
        private System.Windows.Forms.TextBox tbCMNDAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox idDistributeAccount;
        private System.Windows.Forms.Button btnCancelAccount;
        private System.Windows.Forms.Button btnChangeAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCustomerAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn distributeAccount;
    }
}

namespace BankMonitor.views
{
    partial class UCExchange
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_IDExchange = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_IDStaffExchange = new System.Windows.Forms.TextBox();
            this.ib_IDAccountExchange = new System.Windows.Forms.TextBox();
            this.cb_TypeExchange = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_DateExchange = new System.Windows.Forms.TextBox();
            this.tb_MoneyExchange = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_SubmitExchange = new System.Windows.Forms.Button();
            this.bt_CancelExchange = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewExchange = new System.Windows.Forms.DataGridView();
            this.dateExchange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idExchange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeExchange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExchange)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gửi tiền/Rút tiền";
            // 
            // tb_IDExchange
            // 
            this.tb_IDExchange.Location = new System.Drawing.Point(139, 63);
            this.tb_IDExchange.Name = "tb_IDExchange";
            this.tb_IDExchange.ReadOnly = true;
            this.tb_IDExchange.Size = new System.Drawing.Size(100, 20);
            this.tb_IDExchange.TabIndex = 1;
            this.tb_IDExchange.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã giao dịch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label3.Location = new System.Drawing.Point(32, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số TK";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label4.Location = new System.Drawing.Point(32, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label5.Location = new System.Drawing.Point(285, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã nhân viên";
            // 
            // tb_IDStaffExchange
            // 
            this.tb_IDStaffExchange.Location = new System.Drawing.Point(392, 64);
            this.tb_IDStaffExchange.Name = "tb_IDStaffExchange";
            this.tb_IDStaffExchange.Size = new System.Drawing.Size(122, 20);
            this.tb_IDStaffExchange.TabIndex = 1;
            this.tb_IDStaffExchange.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ib_IDAccountExchange
            // 
            this.ib_IDAccountExchange.Location = new System.Drawing.Point(139, 104);
            this.ib_IDAccountExchange.Name = "ib_IDAccountExchange";
            this.ib_IDAccountExchange.Size = new System.Drawing.Size(375, 20);
            this.ib_IDAccountExchange.TabIndex = 1;
            this.ib_IDAccountExchange.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cb_TypeExchange
            // 
            this.cb_TypeExchange.FormattingEnabled = true;
            this.cb_TypeExchange.Items.AddRange(new object[] {
            "Gửi tiền",
            "Rút tiền"});
            this.cb_TypeExchange.Location = new System.Drawing.Point(139, 134);
            this.cb_TypeExchange.Name = "cb_TypeExchange";
            this.cb_TypeExchange.Size = new System.Drawing.Size(121, 21);
            this.cb_TypeExchange.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(273, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày giao dịch";
            // 
            // tb_DateExchange
            // 
            this.tb_DateExchange.Location = new System.Drawing.Point(392, 135);
            this.tb_DateExchange.Name = "tb_DateExchange";
            this.tb_DateExchange.ReadOnly = true;
            this.tb_DateExchange.Size = new System.Drawing.Size(122, 20);
            this.tb_DateExchange.TabIndex = 3;
            // 
            // tb_MoneyExchange
            // 
            this.tb_MoneyExchange.Location = new System.Drawing.Point(139, 179);
            this.tb_MoneyExchange.Name = "tb_MoneyExchange";
            this.tb_MoneyExchange.Size = new System.Drawing.Size(375, 20);
            this.tb_MoneyExchange.TabIndex = 1;
            this.tb_MoneyExchange.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label7.Location = new System.Drawing.Point(32, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số tiền";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // bt_SubmitExchange
            // 
            this.bt_SubmitExchange.Location = new System.Drawing.Point(175, 232);
            this.bt_SubmitExchange.Name = "bt_SubmitExchange";
            this.bt_SubmitExchange.Size = new System.Drawing.Size(75, 23);
            this.bt_SubmitExchange.TabIndex = 4;
            this.bt_SubmitExchange.Text = "Xác nhận";
            this.bt_SubmitExchange.UseVisualStyleBackColor = true;
            // 
            // bt_CancelExchange
            // 
            this.bt_CancelExchange.Location = new System.Drawing.Point(316, 232);
            this.bt_CancelExchange.Name = "bt_CancelExchange";
            this.bt_CancelExchange.Size = new System.Drawing.Size(75, 23);
            this.bt_CancelExchange.TabIndex = 4;
            this.bt_CancelExchange.Text = "Hủy bỏ";
            this.bt_CancelExchange.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bt_CancelExchange);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bt_SubmitExchange);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_DateExchange);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cb_TypeExchange);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_IDExchange);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ib_IDAccountExchange);
            this.groupBox1.Controls.Add(this.tb_IDStaffExchange);
            this.groupBox1.Controls.Add(this.tb_MoneyExchange);
            this.groupBox1.Location = new System.Drawing.Point(35, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 278);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewExchange);
            this.groupBox2.Location = new System.Drawing.Point(635, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 287);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // dataGridViewExchange
            // 
            this.dataGridViewExchange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExchange.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateExchange,
            this.idExchange,
            this.idAccount,
            this.typeExchange,
            this.amount,
            this.idStaff});
            this.dataGridViewExchange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewExchange.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewExchange.Name = "dataGridViewExchange";
            this.dataGridViewExchange.ReadOnly = true;
            this.dataGridViewExchange.Size = new System.Drawing.Size(589, 268);
            this.dataGridViewExchange.TabIndex = 0;
            // 
            // dateExchange
            // 
            this.dateExchange.HeaderText = "Ngày GD";
            this.dateExchange.Name = "dateExchange";
            this.dateExchange.ReadOnly = true;
            // 
            // idExchange
            // 
            this.idExchange.HeaderText = "Mã GD";
            this.idExchange.Name = "idExchange";
            this.idExchange.ReadOnly = true;
            // 
            // idAccount
            // 
            this.idAccount.HeaderText = "Số tài khoản";
            this.idAccount.Name = "idAccount";
            this.idAccount.ReadOnly = true;
            // 
            // typeExchange
            // 
            this.typeExchange.HeaderText = "Loại";
            this.typeExchange.Name = "typeExchange";
            this.typeExchange.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.HeaderText = "Số tiền";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // idStaff
            // 
            this.idStaff.HeaderText = "Mã NV";
            this.idStaff.Name = "idStaff";
            this.idStaff.ReadOnly = true;
            // 
            // UCExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCExchange";
            this.Size = new System.Drawing.Size(1257, 475);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExchange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_IDExchange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_IDStaffExchange;
        private System.Windows.Forms.TextBox ib_IDAccountExchange;
        private System.Windows.Forms.ComboBox cb_TypeExchange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_DateExchange;
        private System.Windows.Forms.TextBox tb_MoneyExchange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_SubmitExchange;
        private System.Windows.Forms.Button bt_CancelExchange;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewExchange;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateExchange;
        private System.Windows.Forms.DataGridViewTextBoxColumn idExchange;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeExchange;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStaff;
    }
}

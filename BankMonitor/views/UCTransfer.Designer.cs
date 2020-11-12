namespace BankMonitor.views
{
    partial class UCTransfer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_CancelTransfer = new System.Windows.Forms.Button();
            this.bt_SubmitTransfer = new System.Windows.Forms.Button();
            this.tb_DateTransfer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_MoneyTransfer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_IDAccountReceiveTransfer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_IDAccountSendTransfer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_idTransfer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTransfer = new System.Windows.Forms.DataGridView();
            this.DateTransfer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTransfer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountSendTransfer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountReceiveTransfer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransfer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_CancelTransfer);
            this.groupBox1.Controls.Add(this.bt_SubmitTransfer);
            this.groupBox1.Controls.Add(this.tb_DateTransfer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_MoneyTransfer);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_IDAccountReceiveTransfer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_IDAccountSendTransfer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_idTransfer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(46, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // bt_CancelTransfer
            // 
            this.bt_CancelTransfer.Location = new System.Drawing.Point(289, 248);
            this.bt_CancelTransfer.Name = "bt_CancelTransfer";
            this.bt_CancelTransfer.Size = new System.Drawing.Size(75, 23);
            this.bt_CancelTransfer.TabIndex = 2;
            this.bt_CancelTransfer.Text = "Hủy bỏ";
            this.bt_CancelTransfer.UseVisualStyleBackColor = true;
            // 
            // bt_SubmitTransfer
            // 
            this.bt_SubmitTransfer.Location = new System.Drawing.Point(151, 248);
            this.bt_SubmitTransfer.Name = "bt_SubmitTransfer";
            this.bt_SubmitTransfer.Size = new System.Drawing.Size(75, 23);
            this.bt_SubmitTransfer.TabIndex = 2;
            this.bt_SubmitTransfer.Text = "Chuyển tiền";
            this.bt_SubmitTransfer.UseVisualStyleBackColor = true;
            // 
            // tb_DateTransfer
            // 
            this.tb_DateTransfer.Location = new System.Drawing.Point(340, 77);
            this.tb_DateTransfer.Name = "tb_DateTransfer";
            this.tb_DateTransfer.ReadOnly = true;
            this.tb_DateTransfer.Size = new System.Drawing.Size(100, 20);
            this.tb_DateTransfer.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày GD";
            // 
            // tb_MoneyTransfer
            // 
            this.tb_MoneyTransfer.Location = new System.Drawing.Point(115, 202);
            this.tb_MoneyTransfer.Name = "tb_MoneyTransfer";
            this.tb_MoneyTransfer.Size = new System.Drawing.Size(325, 20);
            this.tb_MoneyTransfer.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số tiền";
            // 
            // tb_IDAccountReceiveTransfer
            // 
            this.tb_IDAccountReceiveTransfer.Location = new System.Drawing.Point(115, 159);
            this.tb_IDAccountReceiveTransfer.Name = "tb_IDAccountReceiveTransfer";
            this.tb_IDAccountReceiveTransfer.Size = new System.Drawing.Size(325, 20);
            this.tb_IDAccountReceiveTransfer.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "STK nhận";
            // 
            // tb_IDAccountSendTransfer
            // 
            this.tb_IDAccountSendTransfer.Location = new System.Drawing.Point(115, 118);
            this.tb_IDAccountSendTransfer.Name = "tb_IDAccountSendTransfer";
            this.tb_IDAccountSendTransfer.Size = new System.Drawing.Size(325, 20);
            this.tb_IDAccountSendTransfer.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "STK chuyển";
            // 
            // tb_idTransfer
            // 
            this.tb_idTransfer.Location = new System.Drawing.Point(115, 77);
            this.tb_idTransfer.Name = "tb_idTransfer";
            this.tb_idTransfer.ReadOnly = true;
            this.tb_idTransfer.Size = new System.Drawing.Size(100, 20);
            this.tb_idTransfer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã GD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuyển tiền";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewTransfer);
            this.groupBox2.Location = new System.Drawing.Point(630, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 301);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridViewTransfer
            // 
            this.dataGridViewTransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransfer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateTransfer,
            this.IdTransfer,
            this.AccountSendTransfer,
            this.AccountReceiveTransfer,
            this.Money});
            this.dataGridViewTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTransfer.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewTransfer.Name = "dataGridViewTransfer";
            this.dataGridViewTransfer.Size = new System.Drawing.Size(531, 282);
            this.dataGridViewTransfer.TabIndex = 0;
            // 
            // DateTransfer
            // 
            this.DateTransfer.HeaderText = "Ngày GD";
            this.DateTransfer.Name = "DateTransfer";
            // 
            // IdTransfer
            // 
            this.IdTransfer.HeaderText = "Mã GD";
            this.IdTransfer.Name = "IdTransfer";
            // 
            // AccountSendTransfer
            // 
            this.AccountSendTransfer.HeaderText = "TK Chuyển";
            this.AccountSendTransfer.Name = "AccountSendTransfer";
            // 
            // AccountReceiveTransfer
            // 
            this.AccountReceiveTransfer.HeaderText = "TK Nhận";
            this.AccountReceiveTransfer.Name = "AccountReceiveTransfer";
            // 
            // Money
            // 
            this.Money.HeaderText = "Số tiền";
            this.Money.Name = "Money";
            // 
            // UCTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCTransfer";
            this.Size = new System.Drawing.Size(1217, 437);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransfer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_CancelTransfer;
        private System.Windows.Forms.Button bt_SubmitTransfer;
        private System.Windows.Forms.TextBox tb_DateTransfer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_MoneyTransfer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_IDAccountReceiveTransfer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_IDAccountSendTransfer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_idTransfer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewTransfer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTransfer;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTransfer;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountSendTransfer;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountReceiveTransfer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

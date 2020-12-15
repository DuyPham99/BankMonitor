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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIdExchange = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTypeExchange = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDateExchange = new System.Windows.Forms.TextBox();
            this.tbMoneyExchange = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_SubmitExchange = new System.Windows.Forms.Button();
            this.bt_CancelExchange = new System.Windows.Forms.Button();
            this.tbIdStaffExchange = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvExchange = new System.Windows.Forms.DataGridView();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbIdAccountExchange = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.nGAYGDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAGDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOTKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOAIGDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOTIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bds = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExchange)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gửi tiền/Rút tiền";
            // 
            // tbIdExchange
            // 
            this.tbIdExchange.Location = new System.Drawing.Point(114, 81);
            this.tbIdExchange.Name = "tbIdExchange";
            this.tbIdExchange.ReadOnly = true;
            this.tbIdExchange.Size = new System.Drawing.Size(100, 20);
            this.tbIdExchange.TabIndex = 1;
            this.tbIdExchange.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã giao dịch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số TK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(258, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã nhân viên";
            // 
            // cbTypeExchange
            // 
            this.cbTypeExchange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeExchange.FormattingEnabled = true;
            this.cbTypeExchange.Items.AddRange(new object[] {
            "Gửi tiền",
            "Rút tiền"});
            this.cbTypeExchange.Location = new System.Drawing.Point(114, 158);
            this.cbTypeExchange.Name = "cbTypeExchange";
            this.cbTypeExchange.Size = new System.Drawing.Size(121, 21);
            this.cbTypeExchange.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(253, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày giao dịch";
            // 
            // tbDateExchange
            // 
            this.tbDateExchange.Location = new System.Drawing.Point(367, 159);
            this.tbDateExchange.Name = "tbDateExchange";
            this.tbDateExchange.ReadOnly = true;
            this.tbDateExchange.Size = new System.Drawing.Size(122, 20);
            this.tbDateExchange.TabIndex = 3;
            // 
            // tbMoneyExchange
            // 
            this.tbMoneyExchange.Location = new System.Drawing.Point(114, 203);
            this.tbMoneyExchange.Name = "tbMoneyExchange";
            this.tbMoneyExchange.Size = new System.Drawing.Size(375, 20);
            this.tbMoneyExchange.TabIndex = 1;
            this.tbMoneyExchange.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số tiền";
            // 
            // bt_SubmitExchange
            // 
            this.bt_SubmitExchange.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SubmitExchange.Location = new System.Drawing.Point(139, 256);
            this.bt_SubmitExchange.Name = "bt_SubmitExchange";
            this.bt_SubmitExchange.Size = new System.Drawing.Size(75, 32);
            this.bt_SubmitExchange.TabIndex = 4;
            this.bt_SubmitExchange.Text = "Xác nhận";
            this.bt_SubmitExchange.UseVisualStyleBackColor = true;
            this.bt_SubmitExchange.Click += new System.EventHandler(this.bt_SubmitExchange_Click);
            // 
            // bt_CancelExchange
            // 
            this.bt_CancelExchange.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CancelExchange.Location = new System.Drawing.Point(302, 256);
            this.bt_CancelExchange.Name = "bt_CancelExchange";
            this.bt_CancelExchange.Size = new System.Drawing.Size(79, 32);
            this.bt_CancelExchange.TabIndex = 4;
            this.bt_CancelExchange.Text = "Hủy bỏ";
            this.bt_CancelExchange.UseVisualStyleBackColor = true;
            this.bt_CancelExchange.Click += new System.EventHandler(this.bt_CancelExchange_Click);
            // 
            // tbIdStaffExchange
            // 
            this.tbIdStaffExchange.Location = new System.Drawing.Point(367, 81);
            this.tbIdStaffExchange.Name = "tbIdStaffExchange";
            this.tbIdStaffExchange.Size = new System.Drawing.Size(122, 20);
            this.tbIdStaffExchange.TabIndex = 1;
            this.tbIdStaffExchange.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvExchange);
            this.groupBox2.Location = new System.Drawing.Point(607, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 314);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // dgvExchange
            // 
            this.dgvExchange.AutoGenerateColumns = false;
            this.dgvExchange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExchange.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nGAYGDDataGridViewTextBoxColumn,
            this.mAGDDataGridViewTextBoxColumn,
            this.sOTKDataGridViewTextBoxColumn,
            this.lOAIGDDataGridViewTextBoxColumn,
            this.sOTIENDataGridViewTextBoxColumn,
            this.mANVDataGridViewTextBoxColumn});
            this.dgvExchange.DataSource = this.bds;
            this.dgvExchange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExchange.Location = new System.Drawing.Point(3, 16);
            this.dgvExchange.Name = "dgvExchange";
            this.dgvExchange.Size = new System.Drawing.Size(589, 295);
            this.dgvExchange.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbIdAccountExchange);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.bt_CancelExchange);
            this.groupBox3.Controls.Add(this.tbMoneyExchange);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbIdStaffExchange);
            this.groupBox3.Controls.Add(this.bt_SubmitExchange);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbIdExchange);
            this.groupBox3.Controls.Add(this.tbDateExchange);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cbTypeExchange);
            this.groupBox3.Location = new System.Drawing.Point(43, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(505, 314);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // tbIdAccountExchange
            // 
            this.tbIdAccountExchange.Location = new System.Drawing.Point(114, 122);
            this.tbIdAccountExchange.Name = "tbIdAccountExchange";
            this.tbIdAccountExchange.Size = new System.Drawing.Size(375, 20);
            this.tbIdAccountExchange.TabIndex = 5;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // nGAYGDDataGridViewTextBoxColumn
            // 
            this.nGAYGDDataGridViewTextBoxColumn.DataPropertyName = "NGAYGD";
            this.nGAYGDDataGridViewTextBoxColumn.HeaderText = "NGAYGD";
            this.nGAYGDDataGridViewTextBoxColumn.Name = "nGAYGDDataGridViewTextBoxColumn";
            this.nGAYGDDataGridViewTextBoxColumn.Width = 91;
            // 
            // mAGDDataGridViewTextBoxColumn
            // 
            this.mAGDDataGridViewTextBoxColumn.DataPropertyName = "MAGD";
            this.mAGDDataGridViewTextBoxColumn.HeaderText = "MAGD";
            this.mAGDDataGridViewTextBoxColumn.Name = "mAGDDataGridViewTextBoxColumn";
            this.mAGDDataGridViewTextBoxColumn.Width = 91;
            // 
            // sOTKDataGridViewTextBoxColumn
            // 
            this.sOTKDataGridViewTextBoxColumn.DataPropertyName = "SOTK";
            this.sOTKDataGridViewTextBoxColumn.HeaderText = "SOTK";
            this.sOTKDataGridViewTextBoxColumn.Name = "sOTKDataGridViewTextBoxColumn";
            this.sOTKDataGridViewTextBoxColumn.Width = 91;
            // 
            // lOAIGDDataGridViewTextBoxColumn
            // 
            this.lOAIGDDataGridViewTextBoxColumn.DataPropertyName = "LOAIGD";
            this.lOAIGDDataGridViewTextBoxColumn.HeaderText = "LOAIGD";
            this.lOAIGDDataGridViewTextBoxColumn.Name = "lOAIGDDataGridViewTextBoxColumn";
            this.lOAIGDDataGridViewTextBoxColumn.Width = 91;
            // 
            // sOTIENDataGridViewTextBoxColumn
            // 
            this.sOTIENDataGridViewTextBoxColumn.DataPropertyName = "SOTIEN";
            this.sOTIENDataGridViewTextBoxColumn.HeaderText = "SOTIEN";
            this.sOTIENDataGridViewTextBoxColumn.Name = "sOTIENDataGridViewTextBoxColumn";
            this.sOTIENDataGridViewTextBoxColumn.Width = 91;
            // 
            // mANVDataGridViewTextBoxColumn
            // 
            this.mANVDataGridViewTextBoxColumn.DataPropertyName = "MANV";
            this.mANVDataGridViewTextBoxColumn.HeaderText = "MANV";
            this.mANVDataGridViewTextBoxColumn.Name = "mANVDataGridViewTextBoxColumn";
            this.mANVDataGridViewTextBoxColumn.Width = 91;
            // 
            // bds
            // 
            this.bds.DataSource = typeof(BankMonitor.datasource.GD_GOIRUT);
            // 
            // UCExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "UCExchange";
            this.Size = new System.Drawing.Size(1257, 475);
            this.Load += new System.EventHandler(this.UCExchange_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExchange)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIdExchange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTypeExchange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDateExchange;
        private System.Windows.Forms.TextBox tbMoneyExchange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_SubmitExchange;
        private System.Windows.Forms.Button bt_CancelExchange;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox tbIdStaffExchange;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbIdAccountExchange;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridView dgvExchange;
        private System.Windows.Forms.BindingSource bds;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYGDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAGDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOTKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOAIGDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOTIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn;
    }
}

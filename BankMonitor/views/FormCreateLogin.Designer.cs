namespace BankMonitor.views
{
    partial class FormCreateLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateLogin));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.lbRole = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbRetypePassword = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbAccount = new System.Windows.Forms.TextBox();
            this.btnSaveChangePassword = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelChangepassword = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên đăng nhập";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRole);
            this.groupBox1.Controls.Add(this.lbRole);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.tbRetypePassword);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.tbAccount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 259);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(141, 216);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(206, 27);
            this.cbRole.TabIndex = 11;
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.Location = new System.Drawing.Point(6, 219);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(49, 19);
            this.lbRole.TabIndex = 10;
            this.lbRole.Text = "Quyền";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(141, 172);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(205, 26);
            this.tbName.TabIndex = 9;
            // 
            // tbRetypePassword
            // 
            this.tbRetypePassword.Location = new System.Drawing.Point(141, 128);
            this.tbRetypePassword.Name = "tbRetypePassword";
            this.tbRetypePassword.Size = new System.Drawing.Size(206, 26);
            this.tbRetypePassword.TabIndex = 8;
            this.tbRetypePassword.UseSystemPasswordChar = true;
            this.tbRetypePassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbRetypePassword_Validating);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(144, 83);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(202, 26);
            this.tbPassword.TabIndex = 6;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassword_Validating);
            // 
            // tbAccount
            // 
            this.tbAccount.Location = new System.Drawing.Point(144, 41);
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.Size = new System.Drawing.Size(202, 26);
            this.tbAccount.TabIndex = 5;
            this.tbAccount.Validating += new System.ComponentModel.CancelEventHandler(this.tbAccount_Validating);
            // 
            // btnSaveChangePassword
            // 
            this.btnSaveChangePassword.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveChangePassword.ImageOptions.Image")));
            this.btnSaveChangePassword.Location = new System.Drawing.Point(38, 289);
            this.btnSaveChangePassword.Name = "btnSaveChangePassword";
            this.btnSaveChangePassword.Size = new System.Drawing.Size(80, 23);
            this.btnSaveChangePassword.TabIndex = 6;
            this.btnSaveChangePassword.Text = "Lưu";
            this.btnSaveChangePassword.Click += new System.EventHandler(this.btnSaveChangePassword_Click);
            // 
            // btnCancelChangepassword
            // 
            this.btnCancelChangepassword.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelChangepassword.ImageOptions.Image")));
            this.btnCancelChangepassword.Location = new System.Drawing.Point(286, 289);
            this.btnCancelChangepassword.Name = "btnCancelChangepassword";
            this.btnCancelChangepassword.Size = new System.Drawing.Size(82, 23);
            this.btnCancelChangepassword.TabIndex = 7;
            this.btnCancelChangepassword.Text = "Hủy";
            this.btnCancelChangepassword.Click += new System.EventHandler(this.btnCancelChangepassword_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // FormCreateLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 330);
            this.Controls.Add(this.btnCancelChangepassword);
            this.Controls.Add(this.btnSaveChangePassword);
            this.Controls.Add(this.groupBox1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Name = "FormCreateLogin";
            this.Text = "Tạo tài khoản đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChangePassword_FormClosing);
            this.Load += new System.EventHandler(this.FormChangePassword_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbRetypePassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbAccount;
        private DevExpress.XtraEditors.SimpleButton btnSaveChangePassword;
        private DevExpress.XtraEditors.SimpleButton btnCancelChangepassword;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label lbRole;
    }
}
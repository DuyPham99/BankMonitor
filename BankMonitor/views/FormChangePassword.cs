using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BankMonitor.model;
using System.Text.RegularExpressions;

namespace BankMonitor.views
{
    public partial class FormChangePassword : DevExpress.XtraEditors.XtraForm
    {
        User user;
        int flag = 0;
        public FormChangePassword()
        {
            InitializeComponent();
            
        }

        internal User User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormChangePassword_Load(object sender, EventArgs e)
        {
           //tbAccount.Text = user.Username;
        }

        private void FormChangePassword_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Visible = false;
            e.Cancel = true;
        }

        private void btnCancelChangepassword_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnSaveChangePassword_Click(object sender, EventArgs e)
        {
            if(tbOldPassword.Text != user.Password)
            {
                MessageBox.Show("Mật khẩu cũ không đúng");
            } else
            {
                if (ValidateChildren(ValidationConstraints.Enabled) && flag == 1)
                {
                    // update password
                }
            }
        }

        private void tbOldPassword_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void tbNewPassword_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("/(?=(.*[0-9]))((?=.*[A-Za-z0-9])(?=.*[A-Z])(?=.*[a-z]))^.{8,}$/");

            if (!regex.IsMatch(tbNewPassword.Text))
            {
                errorProvider.SetError(tbNewPassword, "Mật khẩu phải có chữ hoa, chữ thường, một số và độ dài ít nhất 8 ký tự!");
                flag = 0;
            } else
            {
                flag = 1;
                errorProvider.SetError(tbNewPassword, null);
            }
        }

        private void tbRetypePassword_Validating(object sender, CancelEventArgs e)
        {
            if(tbRetypePassword.Text != tbNewPassword.Text)
            {
                errorProvider.SetError(tbRetypePassword, "Mật khẩu không trùng khớp");
                flag = 0;
            } else
            {
                flag = 1;
                errorProvider.SetError(tbNewPassword, null);
            }
        }
    }
}
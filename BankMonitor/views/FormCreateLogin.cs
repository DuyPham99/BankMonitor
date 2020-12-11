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
using System.Data.SqlClient;
using System.Collections;
using BankMonitor.datasource;

namespace BankMonitor.views
{
    public partial class FormCreateLogin : DevExpress.XtraEditors.XtraForm
    {
        User user;
        int flag = 0;
        public FormCreateLogin()
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

        }

        private void FormChangePassword_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Visible = false;
            e.Cancel = true;
        }

        public void LoadData()
        {
            ConnectionDatabase db = new ConnectionDatabase();
            db.Mlogin = user.Username;
            db.Password = user.Password;
            db.Connect(user.Distribute);
    
            Hashtable temp = new Hashtable();
            temp.Add("loginName",user.Username);

            SqlDataReader data = db.ExecProcParams("getLoginInfo", temp);

            if (data.Read())
            {
                if (data.GetString(2) == "CHINHANH")
                {
                    cbRole.Items.Add("CHINHANH");
                }
                else
                {
                    cbRole.Items.Add("NGANHANG");
                    cbRole.Items.Add("CHINHANH");
                }
            }

            db.Close();
        }

        public void clearData()
        {
            tbAccount.Clear();
            tbPassword.Clear();
            tbRetypePassword.Clear();
            tbName.Clear();
            cbRole.SelectedIndex = -1;
        }

        private void btnCancelChangepassword_Click(object sender, EventArgs e)
        {
            clearData();
            this.Visible = false;
        }

        private void btnSaveChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isValid()) return;
                ConnectionDatabase db = new ConnectionDatabase();
                db.Mlogin = user.Username;
                db.Password = user.Password;
                db.Connect(user.Distribute);

                Hashtable temp = new Hashtable();
                temp.Add("LGNAME", tbAccount.Text);
                temp.Add("PASS", tbPassword.Text);
                temp.Add("USERNAME", tbName.Text);
                temp.Add("ROLE", cbRole.Text);

                SqlDataReader data = db.ExecProcParams("taoLogin", temp);

                MessageBox.Show("Tạo thành công!");
                clearData();
                db.Close();
            } catch (Exception ex)
            {
                MessageBox.Show("Tài khoản đã tồn tại!");
            }        
        }

        public bool isValid()
        {
            int flag = 1;

            //Regex regex = new Regex("/(?=(.*[0-9]))((?=.*[A-Za-z0-9])(?=.*[A-Z])(?=.*[a-z]))^.{8,}$/");

            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                errorProvider.SetError(tbPassword, "Mật khẩu không hợp lệ!");
                flag = 0;
            }
            else if (string.IsNullOrEmpty(tbPassword.Text))
            {
                errorProvider.SetError(tbPassword, "Nhập password!");
                flag = 0;
            }
            else
            {
                errorProvider.SetError(tbPassword, null);
            }

            //
            if (tbRetypePassword.Text != tbPassword.Text)
            {
                errorProvider.SetError(tbRetypePassword, "Mật khẩu không trùng khớp!");
                flag = 0;
            } else if (string.IsNullOrEmpty(tbRetypePassword.Text))
            {
                errorProvider.SetError(tbRetypePassword, "*");
                flag = 0;
            }
            else
            {
                errorProvider.SetError(tbPassword, null);
            }
            // 
            if (string.IsNullOrEmpty(tbAccount.Text))
            {
                errorProvider.SetError(tbAccount, "Nhập tài khoản!");
                flag = 0;
            } else if (string.IsNullOrWhiteSpace(tbAccount.Text))
            {
                errorProvider.SetError(tbAccount, "Cú pháp không hợp lệ!");
                flag = 0;
            }
            else
            {
                errorProvider.SetError(tbAccount, null);
            }
            //
            if (string.IsNullOrEmpty(tbName.Text))
            {
                errorProvider.SetError(tbName, "Nhập tên!");
                flag = 0;
            }
            else if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                errorProvider.SetError(tbName, "Cú pháp không hợp lệ!");
                flag = 0;
            }
            else
            {
                errorProvider.SetError(tbName, null);
            }
            //
            if (cbRole.SelectedIndex == -1)
            {
                errorProvider.SetError(cbRole, "*");
                flag = 0;
            } else
            {
                errorProvider.SetError(cbRole, null);
            }

            if (flag == 0) return false;

            return true;
        }
        private void tbRetypePassword_Validating(object sender, CancelEventArgs e)
        {
         
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
          
        }

        private void tbAccount_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
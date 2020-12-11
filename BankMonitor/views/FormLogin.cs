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
using BankMonitor.views;
using System.Data.SqlClient;
using System.Collections;
using BankMonitor.datasource;
using System.Data.Entity;

namespace BankMonitor.views
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        ConnectionDatabase conn = new ConnectionDatabase();
        User user = new User();
        int checkLoad = 0;
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

        internal ConnectionDatabase Conn
        {
            get
            {
                return conn;
            }

            set
            {
                conn = value;
            }
        }

        public FormLogin()
        {
            InitializeComponent();
        }

        //logout
        public void clearData()
        {
            this.tbAccountLogin.Text = "";
            this.tbPasswordLogin.Text = "";
            this.cb_IdDistribute.SelectedIndex = -1;              
        }
            
        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Mlogin =  tbAccountLogin.Text;
            conn.Password = tbPasswordLogin.Text;   
          
            if (cb_IdDistribute.Text == "BENTHANH")
            {
               user.Distribute = @"PC-DOM\MSSQLSERVER1";
            } else user.Distribute = @"PC-DOM\MSSQLSERVER2";
            if (tbAccountLogin.Text == "")
            {
                MessageBox.Show("Không được để trống tài khoản!");
                tbAccountLogin.Focus();
            } else
            if (tbPasswordLogin.Text == "")
            {
                MessageBox.Show("Không được để trống mật khẩu!");
                tbPasswordLogin.Focus();
            } else if (cb_IdDistribute.Text == "") {
                MessageBox.Show("Hãy chọn chi nhánh!");
                cb_IdDistribute.Focus();
            } else if (conn.Connect(user.Distribute) == 0)
            {
                MessageBox.Show("Tài khoản, mật khẩu không đúng!");
            } else
            {
                user.Username = tbAccountLogin.Text;
                user.Password = tbPasswordLogin.Text;
                var db = new NGANHANG();
                MessageBox.Show("Đăng nhập thành công!");
                db.User = user;
                db.ChangeDataSource();

                db = new NGANHANG();
                db.NhanViens.Load();
                this.Visible = false;
            }
           
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (checkLoad == 1) return;
            conn.Mlogin = "sa";
            conn.Password = "123";
            conn.Connect(@"PC-DOM\MSSQLSERVER3");
            try
            {
                SqlDataReader rd = conn.ExecProc("getAllBranches");
                while (rd.Read())
                {
                    cb_IdDistribute.Items.Add(rd.GetString(2).Remove(0, 9));
                }
                this.checkLoad = 1;
            }
            finally
            {
              conn.Close();
            }         
        }

        private void FormLogin_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Visible = false;
            e.Cancel = true;
        }
    }
}
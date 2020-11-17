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

namespace BankMonitor.views
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        ConnectionDatabase conn = new ConnectionDatabase();
        // FormMessage message = new FormMessage();
       
        public FormLogin()
        {
            InitializeComponent();

        }
        public void AlertMessage(String message)
        {
            new FormMessage(message).Visible = true;

        }

        public int validateAccount(String username, String password)
        {
            
            return 0;
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbAccountLogin.Text == "")
            {
                //AlertMessage("Không được để trống tài khoản!");
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
            }
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            conn.Connect("3");
            try
            {
                SqlDataReader rd = conn.ExecProc("getAllBranches");
                while (rd.Read())
                {
              
                    cb_IdDistribute.Items.Add(rd.GetString(2).Remove(0,9));
                }
            }
            finally
            {
                ConnectionDatabase.conn.Close();
            }
     
        }
    }
}
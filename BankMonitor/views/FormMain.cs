using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankMonitor.datasource;
using BankMonitor.views;
using BankMonitor.model;
using System.Data.Entity;

namespace BankMonitor
{

    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        User user = new User();
        FormLogin login = new FormLogin();
        ConnectionDatabase conn;

        public Form1()
        {
            InitializeComponent();
           
        }

        public void HidePanels(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                if (c is UserControl)
                {
                    c.Visible = false;
                }
            }
        }

        private void bbtnpnStaff_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(login.User.Username)) return;
            ucStaff.User = login.User;
            if (ucStaff.checkLoad == 0) ucStaff.LoadData();
            if (ucStaff.Visible != true) HidePanels(this.Controls);
            ucStaff.Visible = !ucStaff.Visible;

        }
        private void bbtnCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(login.User.Username)) return;
            ucCustomer.User = login.User;
            if (ucCustomer.checkLoad != 1) ucCustomer.LoadData();
            if (ucCustomer.Visible != true) HidePanels(this.Controls);
            ucCustomer.Visible = !ucCustomer.Visible;
         
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(login.User.Username)) return;
            ucExchange.User = login.User;
            if (ucExchange.checkLoad !=1) ucExchange.LoadData();
            if (ucExchange.Visible != true) HidePanels(this.Controls);
            ucExchange.Visible = !ucExchange.Visible;
        }


        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(login.User.Username)) return;
            ucTransfer.User = login.User;
            ucTransfer.LoadData();
            if (ucTransfer.Visible != true) HidePanels(this.Controls);
            ucTransfer.Visible = !ucTransfer.Visible;
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

       
        private void bbtnSignIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HidePanels(this.Controls);
            login.Hide();       
            login.ShowDialog();           
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(login.User.Username)) return;
            ucAccount.User = login.User;
            ucAccount.Conn = login.Conn;
            if (ucAccount.checkLoad != 1) ucAccount.LoadData();
            if (ucAccount.Visible != true) HidePanels(this.Controls);
            ucAccount.Visible = !ucAccount.Visible;
        }

        private void bbtnSignOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!String.IsNullOrEmpty(login.User.Username))
            {
                if(MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var db = new NGANHANG();
                    db.User = login.User;
                    db.ChangeDataSource();
                    
                    login.User = new User();
                    login.Conn.Close();
                    login.clearData();

                    // flag check load data to dgv
                    ucAccount.checkLoad = 0;
                    ucStaff.checkLoad = 0;
                    ucCustomer.checkLoad = 0;

                    // clear dgv accoun
                    ucAccount.clearData();
                    ucCustomer.clearData();
                    ucStaff.clearData();
                    ucExchange.clearData();
                    ucTransfer.clearData();

                    MessageBox.Show("Đã đăng xuất!"); 
                }
            }
               
        }

        private void ucAccount_Load(object sender, EventArgs e)
        {          
        }

        FormCreateLogin frmChangePassword = new FormCreateLogin();
        private void bbtnChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChangePassword.User = login.User;
            frmChangePassword.LoadData();
            frmChangePassword.Hide();
            frmChangePassword.ShowDialog();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is UserControl)
                {
                    if (c.Visible == true)
                    {
                        if (c.GetType() == typeof(UCAccount))
                        {
                            ucAccount.Undo();
                            break;
                        } else if (c.GetType() == typeof(UCCustomer))
                        {
                            ucCustomer.Undo();
                            break;
                        } else if (c.GetType() == typeof(UCStaff))
                        {
                            ucStaff.Undo();
                            break;
                        }
                    }
                }
            }
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is UserControl)
                {
                    if (c.Visible == true)
                    {
                        if (c.GetType() == typeof(UCAccount))
                        {
                            ucAccount.Redo();
                            break;
                        }
                        else if (c.GetType() == typeof(UCCustomer))
                        {
                            ucCustomer.Redo();
                            break;
                        }
                        else if (c.GetType() == typeof(UCStaff))
                        {
                            ucStaff.Redo();
                            break;
                        }
                    }
                }
            }
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(login.User.Username)) return;
 
            if (ucExchangeReport.Visible != true) HidePanels(this.Controls);
            ucExchangeReport.Visible = !ucExchangeReport.Visible;
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(login.User.Username)) return;
            ucAccountReport.User = login.User;
            ucAccountReport.LoadData();
            if (ucAccountReport.Visible != true) HidePanels(this.Controls);
            ucAccountReport.Visible = !ucAccountReport.Visible;
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(login.User.Username)) return;
            ucCustomerReport1.User = login.User;
            ucCustomerReport1.LoadData();
            if (ucCustomerReport1.Visible != true) HidePanels(this.Controls);
            ucCustomerReport1.Visible = !ucCustomerReport1.Visible;
        }
    }
}

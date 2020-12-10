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
            ucStaff.User = login.User;
            if (ucStaff.checkLoad == 0) ucStaff.LoadData();
            if (ucStaff.Visible != true) HidePanels(this.Controls);
            ucStaff.Visible = !ucStaff.Visible;

        }
        private void bbtnCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucCustomer.User = login.User;
            if (ucCustomer.checkLoad != 1) ucCustomer.LoadData();
            if (ucCustomer.Visible != true) HidePanels(this.Controls);
            ucCustomer.Visible = !ucCustomer.Visible;
         
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucExchange.User = login.User;
            if (ucExchange.checkLoad !=1) ucExchange.LoadData();
            if (ucExchange.Visible != true) HidePanels(this.Controls);
            ucExchange.Visible = !ucExchange.Visible;
        }


        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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

        FormChangePassword frmChangePassword = new FormChangePassword();
        private void bbtnChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChangePassword.User = login.User;
            frmChangePassword.LoadData();
            frmChangePassword.Hide();
            frmChangePassword.ShowDialog();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                NGANHANG db = new NGANHANG();
                int test = db.Database.ExecuteSqlCommand("TEST @p0", "1");
                MessageBox.Show(test.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("sdfsafs");
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("ádsdas");
        }
    }
}

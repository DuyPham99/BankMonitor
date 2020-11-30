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
                // hide any panels this control may have
                HidePanels(c.Controls);
            }
        }

        private void bbtnpnStaff_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ucStaff.Visible != true) HidePanels(this.Controls);
            ucStaff.Visible = !ucStaff.Visible;

        }
        private void bbtnCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ucCustomer.Visible != true) HidePanels(this.Controls);
            ucCustomer.Visible = !ucCustomer.Visible;
         
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ucExchange.Visible != true) HidePanels(this.Controls);
            ucExchange.Visible = !ucExchange.Visible;
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ucTransfer.Visible != true) HidePanels(this.Controls);
            ucTransfer.Visible = !ucTransfer.Visible;
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

       
        private void bbtnSignIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //   FormLogin login = new FormLogin();
            login.Hide();
            login.Show();
           
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucAccount.User = login.User;
            if(ucAccount.checkLoad != 1) ucAccount.LoadData();
            if (ucAccount.Visible != true) HidePanels(this.Controls);
            ucAccount.Visible = !ucAccount.Visible;
 
        }

        private void bbtnSignOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!String.IsNullOrEmpty(login.User.Username))
            {
                if(MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    login.User = new User();
                    login.Conn.Close();
                    login.clearData();

                    // flag check load data to dgv
                    ucAccount.checkLoad = 0;
                    // clear dgv accoun
                    ucAccount.clearData();

                    var db = new NGANHANG();
                    db.ChangeDataSource(@"PC-DOM\MSSQLSERVER0");
                }
            }
               
        }
    }
}

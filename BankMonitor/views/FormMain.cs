using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankMonitor
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
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

        private void ucCustomer_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ucExchange.Visible != true) HidePanels(this.Controls);
            ucExchange.Visible = !ucExchange.Visible;
        }
    }
}

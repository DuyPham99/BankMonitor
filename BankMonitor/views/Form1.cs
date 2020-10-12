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

        private void bbtnpnStaff_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.pnStaff.Visible != true) HidePanels(this.Controls);
            this.pnStaff.Visible = !this.pnStaff.Visible;
        }
        public void HidePanels(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                if (c is Panel)
                {
                    c.Visible = false;
                }

                // hide any panels this control may have
                HidePanels(c.Controls);
            }
        } 
        private void bbtnCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(this.pnCustomer.Visible != true) HidePanels(this.Controls);
            this.pnCustomer.Visible = !this.pnCustomer.Visible;
        }

       
    }
}

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

namespace BankMonitor.views
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
            ConnectionDatabase a = new ConnectionDatabase();
          
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
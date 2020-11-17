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

namespace BankMonitor.views
{
    public partial class FormMessage : DevExpress.XtraEditors.XtraForm
    {
        public FormMessage(String message)
        {
            InitializeComponent();
            this.lbMessage.Text = message;
            this.lbMessage.Visible = true;
        }
        //public setText(string)
        //{

        //}
    }
}
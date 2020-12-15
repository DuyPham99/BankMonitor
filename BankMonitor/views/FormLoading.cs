using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankMonitor.views
{
    public partial class FormLoading : Form
    {
        public FormLoading()
        {
           
            InitializeComponent();
        }

        //protected override void OnLoad(EventArgs e)
        //{
        //    base.OnLoad(e);
        //    Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        //}

        public void Start()
        {
            this.Visible = true;
        }

        public void End()
        {
            this.Visible = false;
        }



    }
}

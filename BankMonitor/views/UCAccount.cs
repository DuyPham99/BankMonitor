using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankMonitor.datasource;
using BankMonitor.views;
using BankMonitor.model;

namespace BankMonitor.views
{
    public partial class UCAccount : UserControl
    {
        User user;
        //to prevent load duplicate datagridview
        public int checkLoad = 0;
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

        public UCAccount()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {
            if (!String.IsNullOrEmpty(user.Username))
            {
                try
                {              
                    NGANHANG db = new NGANHANG();
                    var data = from d in db.TaiKhoans select new { d.NGAYMOTK, d.SOTK, d.CMND, d.SODU, d.MACN };
                    foreach (var x in data.ToList())
                    {
                        if (!x.NGAYMOTK.ToString().Equals(" "))
                            dgvAccount.Rows.Add(x.NGAYMOTK, x.SOTK, x.CMND, x.SODU, x.MACN);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UCAccount_Load(object sender, EventArgs e)
        {
            checkLoad = 1;
        }

        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

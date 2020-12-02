using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankMonitor.model;
using BankMonitor.datasource;

namespace BankMonitor.views
{
    public partial class UCCustomer : UserControl
    {
        User user;
        public int checkLoad = 0;
        int flag = 0;

        public UCCustomer()
        {
            InitializeComponent();
        }

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

        public void LoadData()
        {
            if (!String.IsNullOrEmpty(user.Username))
            {
                try
                {
                    NGANHANG db = new NGANHANG();
                    var data = from d in db.KhachHangs select d;

                    foreach (var x in data.ToList())
                    {
                        if (!x.CMND.ToString().Equals(" "))
                            dgvCustomer.Rows.Add(x.CMND, x.NGAYCAP.ToShortDateString(), x.HO, x.TEN, x.DIACHI, x.SODT, x.PHAI, x.MACN);
                    }

                    // load chi nhanh cua tai khoan
                    var dataCN = from d in db.ChiNhanhs select d;
                    foreach (var x in dataCN.ToList())
                        cbDistributeCustomer.Items.Add(x.MACN);
                        checkLoad = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // check unclick and click in header
            try
            {
                if (dgvCustomer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    flag = 0;
                    dgvCustomer.CurrentRow.Selected = true;
                    tbIdCustomer.Text = dgvCustomer.Rows[e.RowIndex].Cells[0].FormattedValue.ToString().Trim(' ');
                    dtpDateIdCustomer.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].FormattedValue.ToString().Trim(' ');
                    tbFirstNameCustomer.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].FormattedValue.ToString().Trim(' ');
                    tbLastNameCustomer.Text = dgvCustomer.Rows[e.RowIndex].Cells[3].FormattedValue.ToString().Trim(' ');
                    tbAddressCustomer.Text = dgvCustomer.Rows[e.RowIndex].Cells[4].FormattedValue.ToString().Trim(' ');
                    tbPhoneNumberCustomer.Text = dgvCustomer.Rows[e.RowIndex].Cells[5].FormattedValue.ToString().Trim(' ');
                    //   rd.Text = dgvCustomer.Rows[e.RowIndex].Cells[6].FormattedValue.ToString().Trim(' ');
                    if (string.Equals(dgvCustomer.Rows[e.RowIndex].Cells[6].FormattedValue.ToString().Trim(' '), "NAM", StringComparison.OrdinalIgnoreCase))
                    {
                        rdbtnMaleCustomer.Select();
                    } else rdbtnFemaleCustomer.Select();
                    cbDistributeCustomer.SelectedIndex = cbDistributeCustomer.FindString(dgvCustomer.Rows[e.RowIndex].Cells[7].FormattedValue.ToString().Trim(' '));
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}

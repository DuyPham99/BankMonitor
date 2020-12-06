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
using System.Text.RegularExpressions;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.Entity.Infrastructure;

namespace BankMonitor.views
{
    public partial class UCAccount : UserControl
    {
        User user;
        //to prevent load duplicate datagridview
        public int checkLoad = 0;
        ConnectionDatabase conn;

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

        internal ConnectionDatabase Conn
        {
            get
            {
                return conn;
            }

            set
            {
                conn = value;
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
                    var dataTK = from d in db.TaiKhoans select new { d.NGAYMOTK, d.SOTK, d.CMND, d.SODU, d.MACN };
                    foreach (var x in dataTK.ToList())
                    {
                        if (!x.NGAYMOTK.ToString().Equals(" "))
                            dgvAccount.Rows.Add(x.NGAYMOTK, x.SOTK, x.CMND, x.SODU.ToString("G29") , x.MACN);
                    }

                    var dataCN = from d in db.ChiNhanhs select d;

                    foreach (var x in dataCN.ToList())
                         cbDistributeAccount.Items.Add(x.MACN);
                        checkLoad = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //logout
        public void clearData()
        {
            this.dgvAccount.Rows.Clear();
            this.dgvAccount.Refresh();
        }

        private void UCAccount_Load(object sender, EventArgs e)
        {
        }

        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // check unclick and click in header
            try
            {
                if (dgvAccount.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvAccount.CurrentRow.Selected = true;
                    tbIdAccount.Enabled = false;
                    tbIdAccount.Text = dgvAccount.Rows[e.RowIndex].Cells[1].FormattedValue.ToString().Trim(' ');
                    tbIdentityAccount.Text = dgvAccount.Rows[e.RowIndex].Cells[2].FormattedValue.ToString().Trim(' ');
                    tbDateAccount.Text = dgvAccount.Rows[e.RowIndex].Cells[0].FormattedValue.ToString().Trim(' ');
                    tbAmountAccount.Text = dgvAccount.Rows[e.RowIndex].Cells[3].FormattedValue.ToString().Trim(' ');
                    cbDistributeAccount.SelectedIndex = cbDistributeAccount.FindString(dgvAccount.Rows[e.RowIndex].Cells[4].FormattedValue.ToString().Trim(' '));
                }
            } catch (Exception ex)
            {

            }   
        }

        public bool isValid()
        {
            int flag = 1;
            Regex regex = new Regex(@"^[0-9]*$");
            if (string.IsNullOrEmpty(tbIdAccount.Text))
            {
                errorProvider.SetError(tbIdAccount, "Nhập số tài khoản!");
                flag *= 0;               
            }
            else if (!regex.IsMatch(tbIdAccount.Text))
            {
                errorProvider.SetError(tbIdAccount, "Chỉ nhập số!");
                flag *= 0;
            }
            else
            {
                errorProvider.SetError(tbIdAccount, null);
            }

            //
            regex = new Regex(@"^[0-9]*$");
            if (string.IsNullOrEmpty(tbIdentityAccount.Text))
            {
                errorProvider.SetError(tbIdentityAccount, "Nhập số CMND!");
                flag *= 0;
            }
            else if (!regex.IsMatch(tbIdentityAccount.Text))
            {
                errorProvider.SetError(tbIdentityAccount, "CMND/CCCD sai cú pháp!");
                flag *= 0;
            }
            else if (tbIdentityAccount.Text.Length != 9 && tbIdentityAccount.Text.Length != 12)
            {
                errorProvider.SetError(tbIdentityAccount, "Độ dài CMND không đúng!");
                flag *= 0;
            }
            else
            {
                errorProvider.SetError(tbIdentityAccount, null);
            }

            //   Regex regex = new Regex(@"^[0-9]*$");
            if (string.IsNullOrEmpty(tbAmountAccount.Text))
            {
                errorProvider.SetError(tbAmountAccount, "Nhập số số dư!");
                flag *= 0;
            }
            else if ( tbAmountAccount.Text.Length < 0)
            {
                errorProvider.SetError(tbAmountAccount, "Số dư phải lớn hơn 0đ!");
                flag *= 0;
            } else if (!regex.IsMatch(tbAmountAccount.Text))
            {
                errorProvider.SetError(tbAmountAccount, "Số dư phải là số!");
                flag *= 0;
            }
            else
            {
                errorProvider.SetError(tbAmountAccount, null);
            }
            //
             regex = new Regex(@"^[0-9]*$");
            if (string.IsNullOrEmpty(tbAmountAccount.Text))
            {
                errorProvider.SetError(tbAmountAccount, "Nhập số số dư!");
                flag *= 0;
            }
            else if (tbAmountAccount.Text.Length < 0)
            {
                errorProvider.SetError(tbAmountAccount, "Số dư phải lớn hơn 0đ!");
                flag *= 0;
            }
            else if (!regex.IsMatch(tbAmountAccount.Text))
            {
                errorProvider.SetError(tbAmountAccount, "Số dư phải là số!");
                flag *= 0;
            }
            else
            {
                errorProvider.SetError(tbAmountAccount, null);
            }
            //
            if (string.IsNullOrEmpty(cbDistributeAccount.Text))
            {
                errorProvider.SetError(cbDistributeAccount, "Chọn chi nhánh!");
                flag *= 0;
            } else
            {
                errorProvider.SetError(cbDistributeAccount, null);
            }

            if (flag == 0) return false;

            return true;
        }

        private void btnCancelAccount_Click(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedRows.Count > 0) dgvAccount.CurrentRow.Selected = false;
            tbIdAccount.Enabled = true;
            tbIdAccount.Clear();
            tbIdentityAccount.Clear();
            tbDateAccount.Clear();
            tbAmountAccount.Clear();
            cbDistributeAccount.SelectedIndex = -1;
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {          
            if (isValid())
            {            
                 if(MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var account = new TaiKhoan();
                    account.SOTK = tbIdAccount.Text;
                    var db = new NGANHANG();

                    var check = db.TaiKhoans.Find(tbIdAccount.Text);
                    if (check == null)
                    {
                        MessageBox.Show("Tài khoản không tồn tại!");
                        return;
                    }

                    db.Entry(account).State = EntityState.Deleted;
                    db.SaveChanges();

                    // remove select
                    if (dgvAccount.CurrentRow.Selected == true)
                    {
                        dgvAccount.Rows.RemoveAt(dgvAccount.SelectedRows[0].Index);
                    }
                    btnCancelAccount.PerformClick();
                    MessageBox.Show("Xóa thành công!");
                }          
            }
        }

        private void tbIdAccount_Validating(object sender, CancelEventArgs e)
        {       
          
        }

        private void tbIdentityAccount_Validating(object sender, CancelEventArgs e)
        {
         
        }

        private void tbAmountAccount_Validating(object sender, CancelEventArgs e)
        {
         
        }

        private void btAddAccount_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                DateTimeOffset now = (DateTimeOffset)DateTime.UtcNow;
                var time = now.ToLocalTime().ToString();
                // insert
                using (var db = new NGANHANG())
                {
                    try
                    {
                        var account = new TaiKhoan()
                        {
                            SOTK = tbIdAccount.Text,
                            MACN = cbDistributeAccount.Text,
                            CMND = tbIdentityAccount.Text,
                            NGAYMOTK = Convert.ToDateTime(time),
                            SODU = decimal.Parse(tbAmountAccount.Text),
                            rowguid = Guid.NewGuid()
                    };

                        //db.TaiKhoans.Add(account);
                        //db.SaveChanges();          
                        // add account
                        db.Database.ExecuteSqlCommand("themTaiKhoan @p0, @p1, @p2, @p3", parameters: new[] {tbIdAccount.Text, tbIdentityAccount.Text, cbDistributeAccount.Text, tbAmountAccount.Text});
                        dgvAccount.Rows.Add(account.NGAYMOTK, account.SOTK, account.CMND, account.SODU.ToString("G29"), account.MACN);
                        MessageBox.Show("Thêm thành công!");
                    } catch (SqlException ex)
                    {
                        // MessageBox.Show("Số tài khoản đã tồn tại!");
                        MessageBox.Show(ex.Message);
                    }
                    
                }
               
            }
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                using (var db = new NGANHANG())
                {
                    try
                    {
                        // choose current
                        var account = db.TaiKhoans.Find(tbIdAccount.Text);

                        if (account != null)
                        {
                            account.MACN = cbDistributeAccount.Text;
                            account.CMND = tbIdentityAccount.Text;
                            account.SODU = decimal.Parse(tbAmountAccount.Text);
                            db.SaveChanges();

                            dgvAccount.Rows[dgvAccount.SelectedRows[0].Index].Cells[2].Value = account.CMND;
                            dgvAccount.Rows[dgvAccount.SelectedRows[0].Index].Cells[4].Value = account.MACN;
                            dgvAccount.Rows[dgvAccount.SelectedRows[0].Index].Cells[3].Value = account.SODU;
                            MessageBox.Show("Cập nhật thành công!");
                        } else MessageBox.Show("Số tài khoản đã tồn tại!");
                    }
                    catch (SqlException ex)
                    {
                        // MessageBox.Show("Số tài khoản đã tồn tại!");
                        MessageBox.Show(ex.Message);
                    }
                }               
            }
        }

        private void tbIdAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAmountAccount_TextChanged(object sender, EventArgs e)
        {

        }
    }


}

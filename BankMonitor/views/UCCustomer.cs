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
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Data.Entity;

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
            if (ValidateChildren(ValidationConstraints.Enabled) && flag == 1)
            {
                using (var db = new NGANHANG())
                {
                    try
                    {
                        //db.TaiKhoans.Add(account);
                        //db.SaveChanges();          
                        // add account
                        string gender;
                        if (rdbtnMaleCustomer.Checked)
                        {
                           gender = "NAM";
                        } else gender = "NỮ";

                        db.Database.ExecuteSqlCommand("themKhachHang @p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7", parameters: new[] { tbIdCustomer.Text, tbFirstNameCustomer.Text, tbLastNameCustomer.Text, tbAddressCustomer.Text, gender, dtpDateIdCustomer.Text, cbDistributeCustomer.Text, tbPhoneNumberCustomer.Text });
                        dgvCustomer.Rows.Add(tbIdCustomer.Text, dtpDateIdCustomer.Text, tbFirstNameCustomer.Text, tbLastNameCustomer.Text, tbAddressCustomer.Text, tbPhoneNumberCustomer.Text, gender, cbDistributeCustomer.Text);
                        MessageBox.Show("Thêm thành công!");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("CMND đã tồn tại!");
                    }

                }
            }
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

        private void tbFirstNameCustomer_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbFirstNameCustomer.Text))
            {
                flag = 0;
                errorProvider.SetError(tbFirstNameCustomer,"Nhập họ!");
            } else
            {
                flag = 1;
                errorProvider.SetError(tbFirstNameCustomer, null);
            }
        }

        private void tbLastNameCustomer_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbLastNameCustomer.Text))
            {
                flag = 0;
                errorProvider.SetError(tbLastNameCustomer, "Nhập tên!");
            }
            else
            {
                flag = 1;
                errorProvider.SetError(tbLastNameCustomer, null);
            }
        }

        private void tbAddressCustomer_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbAddressCustomer.Text))
            {
                flag = 0;
                errorProvider.SetError(tbAddressCustomer, "Nhập tên!");
            }
            else
            {
                flag = 1;
                errorProvider.SetError(tbAddressCustomer, null);
            }
        }

        private void tbIdCustomer_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]*$");
            if (string.IsNullOrEmpty(tbIdCustomer.Text))
            {
                errorProvider.SetError(tbIdCustomer, "Nhập số CMND!");
                flag = 0;
            }
            else if (!regex.IsMatch(tbIdCustomer.Text))
            {
                errorProvider.SetError(tbIdCustomer, "CMND/CCCD sai cú pháp!");
                flag = 0;
            }
            else if (tbIdCustomer.Text.Length != 9 && tbIdCustomer.Text.Length != 12)
            {
                errorProvider.SetError(tbIdCustomer, "Độ dài CMND không đúng!");
                flag = 0;
            }
            else
            {
                flag = 1;
                errorProvider.SetError(tbIdCustomer, null);
            }
        }

        private void tbPhoneNumberCustomer_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]*$");
            if (string.IsNullOrEmpty(tbPhoneNumberCustomer.Text))
            {
                errorProvider.SetError(tbPhoneNumberCustomer, "Nhập số số điện thoại!");
                flag = 0;
            }
            else if (!regex.IsMatch(tbPhoneNumberCustomer.Text))
            {
                errorProvider.SetError(tbIdCustomer, "Số điện thoại sai cú pháp!");
                flag = 0;
            }
            else if (tbPhoneNumberCustomer.Text.Length != 10)
            {
                flag = 0;
                errorProvider.SetError(tbPhoneNumberCustomer, "Độ dài không đúng!");
            }
            else
            {
                flag = 1;
                errorProvider.SetError(tbPhoneNumberCustomer, null);
            }
        }

        private void rdbtnMaleCustomer_Validating(object sender, CancelEventArgs e)
        {
            if (!rdbtnMaleCustomer.Checked && !rdbtnFemaleCustomer.Checked)
            {
                flag = 0;
                errorProvider.SetError(rdbtnMaleCustomer, "");
                errorProvider.SetError(rdbtnFemaleCustomer, "");
            } else
            {
                flag = 1;
                errorProvider.SetError(rdbtnMaleCustomer, null);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled) && flag == 1)
            {
                if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    var customer = new KhachHang();
                    customer.CMND = tbIdCustomer.Text;
                    var db = new NGANHANG();
                    var check = db.KhachHangs.Find(tbIdCustomer.Text);

                    if (check==null)
                    {
                        MessageBox.Show("Khách hàng không tồn tại!");
                        return;
                    }
                    db.Entry(customer).State = EntityState.Deleted;
                    db.SaveChanges();

                    // remove select
                    if (dgvCustomer.CurrentRow.Selected == true)
                    {
                        dgvCustomer.Rows.RemoveAt(dgvCustomer.SelectedRows[0].Index);
                    }
                    btnCancelCustomer.PerformClick();
                    MessageBox.Show("Xóa thành công!");
                }
            }
        }

        private void btnCancelCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count > 0) dgvCustomer.CurrentRow.Selected = false;
            tbFirstNameCustomer.Clear();
            tbLastNameCustomer.Clear();
            tbAddressCustomer.Clear();
            tbIdCustomer.Clear();
            dtpDateIdCustomer.Value = DateTime.Now;
            tbPhoneNumberCustomer.Clear();
            cbDistributeCustomer.SelectedIndex = -1;
            if (rdbtnMaleCustomer.Checked)
            {
                rdbtnMaleCustomer.Checked = false;      
            }
            rdbtnFemaleCustomer.Checked = false;
        }

        private void btnChangeCustomer_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled) && flag == 1)
            {
                using (var db = new NGANHANG())
                {
                    try
                    {
                        // choose current
                        var khachhang = db.KhachHangs.Find(tbIdCustomer.Text);
                        if (khachhang != null)
                        {
                            khachhang.HO = tbFirstNameCustomer.Text;
                            khachhang.TEN = tbLastNameCustomer.Text;
                            khachhang.DIACHI = tbAddressCustomer.Text;
       
                            khachhang.NGAYCAP = dtpDateIdCustomer.Value;
                            khachhang.SODT = tbPhoneNumberCustomer.Text;
                            khachhang.MACN = cbDistributeCustomer.Text;

                            if (rdbtnMaleCustomer.Checked)
                            {
                                khachhang.PHAI = "NAM";
                            } else khachhang.PHAI = "NỮ";

                            db.SaveChanges();

                            dgvCustomer.Rows[dgvCustomer.SelectedRows[0].Index].Cells[1].Value = khachhang.NGAYCAP;
                            dgvCustomer.Rows[dgvCustomer.SelectedRows[0].Index].Cells[2].Value = khachhang.HO;
                            dgvCustomer.Rows[dgvCustomer.SelectedRows[0].Index].Cells[3].Value = khachhang.TEN;
                            dgvCustomer.Rows[dgvCustomer.SelectedRows[0].Index].Cells[4].Value = khachhang.DIACHI;
                            dgvCustomer.Rows[dgvCustomer.SelectedRows[0].Index].Cells[5].Value = khachhang.SODT;
                            dgvCustomer.Rows[dgvCustomer.SelectedRows[0].Index].Cells[6].Value = khachhang.PHAI;
                            dgvCustomer.Rows[dgvCustomer.SelectedRows[0].Index].Cells[7].Value = khachhang.SODT;

                            MessageBox.Show("Cập nhật thành công!");
                        } else
                        {
                            MessageBox.Show("CMND không tồn tại!");

                        }

                    }
                    catch (SqlException ex)
                    {
                        // MessageBox.Show("Số tài khoản đã tồn tại!");
                        MessageBox.Show("Cập nhật thất bại!");
                    }
                }
            }
        }
    }
}

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
using BankMonitor.model;
using System.Text.RegularExpressions;
using System.Data.Entity;

namespace BankMonitor.views
{
    public partial class UCStaff : UserControl
    {
        User user;
        public int checkLoad = 0;
        private UndoRedo<NhanVien, string> stack = new UndoRedo<NhanVien, string>();

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

        public UndoRedo<NhanVien, string> Stack
        {
            get
            {
                return stack;
            }

            set
            {
                stack = value;
            }
        }

        public UCStaff()
        {
            InitializeComponent();        
        }

        private void UCStaff_Load(object sender, EventArgs e)
        {

        }

        public void LoadData() {
            if (!String.IsNullOrEmpty(user.Username))
            {
                try
                {
                    NGANHANG db = new NGANHANG();
                    var data = from d in db.NhanViens select d;
                    foreach (var x in data.ToList())
                    {
                        if (!x.MANV.ToString().Equals(" "))
                            dgvStaff.Rows.Add(x.MANV, x.MACN, x.HO, x.TEN, x.DIACHI, x.PHAI, x.SODT);
                    }

                    var dataCN = from d in db.ChiNhanhs select d;

                    foreach (var x in dataCN.ToList())
                        cbDistributeStaff.Items.Add(x.MACN);
                    checkLoad = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public bool isValid()
        {
            int flag = 1;
            if (string.IsNullOrEmpty(tbIdStaff.Text))
            {
                flag *= 0;
                errorProvider.SetError(tbIdStaff, "Nhập mã nhân viên!");
            } else if (tbIdStaff.Text.Length > 10)
            {
                flag *= 0;
                errorProvider.SetError(tbIdStaff, "Độ dài tối đa 10 kí tự!");
            } else
            {
                errorProvider.SetError(tbIdStaff, null);
            }
            //
            if (string.IsNullOrEmpty(cbDistributeStaff.Text))
            {
                flag *= 0;
                errorProvider.SetError(cbDistributeStaff, "*");
            } else
            {
                errorProvider.SetError(cbDistributeStaff, null);
            }
            //
            if (string.IsNullOrEmpty(tbFirstNameStaff.Text))
            {
                errorProvider.SetError(tbFirstNameStaff, "Nhập họ!");
                flag *= 0;
            }
            else
            {
                errorProvider.SetError(tbFirstNameStaff, null);
            }
            //
            if (string.IsNullOrEmpty(tbLastNameStaff.Text))
            {
                flag *= 0;
                errorProvider.SetError(tbLastNameStaff, "Nhập tên!");
            }
            else
            {
                errorProvider.SetError(tbLastNameStaff, null);
            }

            //
            if (string.IsNullOrEmpty(tbAddressStaff.Text))
            {
                flag *= 0;
                errorProvider.SetError(tbAddressStaff, "Nhập địa chỉ!");
            }
            else
            {
                errorProvider.SetError(tbAddressStaff, null);
            }
            //
            Regex regex = new Regex(@"^[0-9]*$");
            if (string.IsNullOrEmpty(tbPhoneNumberStaff.Text))
            {

                flag *= 0;
                errorProvider.SetError(tbPhoneNumberStaff, "Nhập số số điện thoại!");
            }
            else if (!regex.IsMatch(tbPhoneNumberStaff.Text))
            {

                flag *= 0;
                errorProvider.SetError(tbPhoneNumberStaff, "Số điện thoại sai cú pháp!");
            }
            else if (tbPhoneNumberStaff.Text.Length != 10)
            {
                flag *= 0;
                errorProvider.SetError(tbPhoneNumberStaff, "Độ dài không đúng!");
            }
            else
            {
                errorProvider.SetError(tbPhoneNumberStaff, null);
            }
            //
            if (!rdbtnMale.Checked && !rdbtnFemale.Checked)
            {
                errorProvider.SetError(rdbtnMale, "*");
                errorProvider.SetError(rdbtnFemale, "*");
                flag *= 0;
            }
            else
            {
                errorProvider.SetError(rdbtnMale, null);
                errorProvider.SetError(rdbtnFemale, null);
            }

            if (flag == 0) return false;

            return true;
        }

        private void btnAddpnStaff_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                using (var db = new NGANHANG())
                {
                    string gender;

                    var staff = db.NhanViens.Find(tbIdStaff.Text);
                    if (staff != null)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại!");
                    } else
                    {
                       
                        if (rdbtnMale.Checked)
                        {
                            gender = "NAM";
                        }
                        else
                        {
                            gender = "NỮ";
                        }

                        MessageBox.Show(gender);
                        db.Database.ExecuteSqlCommand("themNhanVien @p0, @p1, @p2, @p3, @p4, @p5, @p6", parameters: new[] {tbIdStaff.Text, tbFirstNameStaff.Text,
                    tbLastNameStaff.Text, tbAddressStaff.Text, gender, tbPhoneNumberStaff.Text, cbDistributeStaff.Text});
                        // undo redo  
                        NhanVien nhanvien = db.NhanViens.Find(tbIdStaff.Text);
                        MessageBox.Show(nhanvien.HO);
                        stack.Add(new AddStaff(nhanvien, "ADD"));
                        //
                        dgvStaff.Rows.Add(tbIdStaff.Text, cbDistributeStaff.Text, tbFirstNameStaff.Text,
                        tbLastNameStaff.Text, tbAddressStaff.Text, gender, tbPhoneNumberStaff.Text);
                        MessageBox.Show("Thêm thành công!");
                    }        
                }
            }
        }

        private void btnCancelStaff_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0) dgvStaff.CurrentRow.Selected = false;
            tbIdStaff.Enabled = true;
            tbIdStaff.Clear();
            tbFirstNameStaff.Clear();
            tbLastNameStaff.Clear();
            tbAddressStaff.Clear();
            tbPhoneNumberStaff.Clear();
            cbDistributeStaff.SelectedIndex = -1;
            if (rdbtnMale.Checked)
            {
                rdbtnMale.Checked = false;
            }
            else rdbtnFemale.Checked = false;
        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // check unclick and click in header
            try
            {
                if (dgvStaff.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvStaff.CurrentRow.Selected = true;
                    tbIdStaff.Enabled = false;
                    tbIdStaff.Text = dgvStaff.Rows[e.RowIndex].Cells[0].FormattedValue.ToString().Trim(' ');
                    cbDistributeStaff.SelectedIndex = cbDistributeStaff.FindString(dgvStaff.Rows[e.RowIndex].Cells[1].FormattedValue.ToString().Trim(' '));
                    tbFirstNameStaff.Text = dgvStaff.Rows[e.RowIndex].Cells[2].FormattedValue.ToString().Trim(' ');
                    tbLastNameStaff.Text = dgvStaff.Rows[e.RowIndex].Cells[3].FormattedValue.ToString().Trim(' ');
                    tbAddressStaff.Text = dgvStaff.Rows[e.RowIndex].Cells[4].FormattedValue.ToString().Trim(' ');
                    if (string.Equals(dgvStaff.Rows[e.RowIndex].Cells[5].FormattedValue.ToString().Trim(' '), "NAM", StringComparison.OrdinalIgnoreCase))
                    {
                        rdbtnMale.Select();
                    }
                    else rdbtnFemale.Select();
                    tbPhoneNumberStaff.Text = dgvStaff.Rows[e.RowIndex].Cells[6].FormattedValue.ToString().Trim(' ');
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnDeletepnStaff_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var db = new NGANHANG())
                    {
                        var staff = db.NhanViens.Find(tbIdStaff.Text);
                        if (staff != null)
                        {
                            db.Entry(staff).State = EntityState.Deleted;
                            db.SaveChanges();

                            // remove select
                            if (dgvStaff.CurrentRow.Selected == true)
                            {
                                dgvStaff.Rows.RemoveAt(dgvStaff.SelectedRows[0].Index);
                            }
                            btnCancelStaff.PerformClick();
                            MessageBox.Show("Xóa thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Mã nhân viên không tồn tại!");
                        }
                    }
                }          
            }

        }

        private void btnChangeStaff_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                using (var db = new NGANHANG())
                {
                    string gender;

                    var staff = db.NhanViens.Find(tbIdStaff.Text);
                    if (staff == null)
                    {
                        MessageBox.Show("Mã nhân viên không tồn tại!");
                    }
                    else
                    {
                        if (rdbtnMale.Checked)
                        {
                            gender = "NAM";
                        }
                        else
                        {
                            gender = "NỮ";
                        }
                        db.Database.ExecuteSqlCommand("capNhatNhanVien @p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7", parameters: new[] {tbIdStaff.Text, tbFirstNameStaff.Text,
                    tbLastNameStaff.Text, tbAddressStaff.Text, gender, tbPhoneNumberStaff.Text, cbDistributeStaff.Text, " "});

                        dgvStaff.Rows[dgvStaff.SelectedRows[0].Index].Cells[1].Value = cbDistributeStaff.Text;
                        dgvStaff.Rows[dgvStaff.SelectedRows[0].Index].Cells[2].Value = tbFirstNameStaff.Text;
                        dgvStaff.Rows[dgvStaff.SelectedRows[0].Index].Cells[3].Value = tbLastNameStaff.Text;
                        dgvStaff.Rows[dgvStaff.SelectedRows[0].Index].Cells[4].Value = tbAddressStaff.Text;
                        dgvStaff.Rows[dgvStaff.SelectedRows[0].Index].Cells[5].Value = gender;
                        dgvStaff.Rows[dgvStaff.SelectedRows[0].Index].Cells[6].Value = tbPhoneNumberStaff.Text;

                        MessageBox.Show("Sửa thành công!");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien();
            //ur.unDo(new AddStaff(nhanvien,"a"));
            AddStaff a = (AddStaff) stack.Undo.Pop();           
            MessageBox.Show(a.getKey().HO);  
        }

        public void Add(NhanVien nv)
        {
            var db = new NGANHANG();
            db.Database.ExecuteSqlCommand("themNhanVien @p0, @p1, @p2, @p3, @p4, @p5, @p6", parameters: new[] {nv.MANV, nv.HO,
                          nv.TEN, nv.DIACHI, nv.PHAI, nv.SODT, nv.MACN});
            dgvStaff.Rows.Add(nv.MANV, nv.MACN, nv.HO,
                         nv.TEN, nv.DIACHI, nv.PHAI, nv.SODT);
        }

        public void Delete(NhanVien nv)
        {
            var db = new NGANHANG();
            db.Entry(nv).State = EntityState.Deleted;
            db.SaveChanges();

            this.LoadData();
        }
    }
}

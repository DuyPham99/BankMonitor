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
using System.Data.SqlClient;

namespace BankMonitor.views
{
    public partial class UCStaff : UserControl
    {
        User user;
        public int checkLoad = 0;
   //     private UndoRedo<NhanVien, string> stack = new UndoRedo<NhanVien, string>();


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

        //public UndoRedo<NhanVien, string> Stack
        //{
        //    get
        //    {
        //        return stack;
        //    }

        //    set
        //    {
        //        stack = value;
        //    }
        //}

        public UCStaff()
        {
            InitializeComponent();
        }

        private void UCStaff_Load(object sender, EventArgs e)
        {
  //          stack.Reset();
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
                        if (!x.MANV.ToString().Equals(" ") && x.TrangThaiXoa!=1)
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

        public void clearData()
        {
            dgvStaff.Rows.Clear();
            dgvStaff.Refresh();
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
                try
                {
                    using (var db = new NGANHANG())
                    {
                        string gender;

                        var staff = db.NhanViens.Find(tbIdStaff.Text);
                        if (staff != null)
                        {
                           // MessageBox.Show("Mã nhân viên đã tồn tại!");
                            MessageBox.Show("Mã nhân viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            db.Database.ExecuteSqlCommand("themNhanVien @p0, @p1, @p2, @p3, @p4, @p5, @p6", parameters: new[] {tbIdStaff.Text, tbFirstNameStaff.Text,
                    tbLastNameStaff.Text, tbAddressStaff.Text, gender, tbPhoneNumberStaff.Text, cbDistributeStaff.Text});
                            // undo redo  
                            NhanVien nhanvien = db.NhanViens.Find(tbIdStaff.Text);
                            MessageBox.Show("dsfd");
 //                           stack.Add(new AddStaff(nhanvien, "ADD"));
                            
                            //
                            dgvStaff.Rows.Add(tbIdStaff.Text, cbDistributeStaff.Text, tbFirstNameStaff.Text,
                            tbLastNameStaff.Text, tbAddressStaff.Text, gender, tbPhoneNumberStaff.Text);
                            MessageBox.Show("Thêm thành công!");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    //if (ex.Errors[0].Message == "-1") MessageBox.Show("Mã nhân viên đã tồn tại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //else if (ex.Errors[0].Message == "-2") MessageBox.Show("Phái là nam hoặc nữ!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //else if (ex.Errors[0].Message == "-3") MessageBox.Show("Mã chi nhánh không tồn tại", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //else MessageBox.Show(ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.Errors[0].Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        NhanVien staff = db.NhanViens.Find(tbIdStaff.Text);
                        NhanVien temp = new NhanVien();
                        temp = (NhanVien) staff.Clone();
                        if (staff != null)
                        {
                            // undo redo  
  //                          staff.TrangThaiXoa = 1;
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
                            MessageBox.Show("Mã nhân viên không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }          
            }

        }

        private void btnChangeStaff_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValid())
                {
                    using (var db = new NGANHANG())
                    {
                        string gender;

                        var staff = db.NhanViens.Find(tbIdStaff.Text);

                        //undo redo
    //                    stack.Update(new AddStaff((NhanVien)staff.Clone(), "UPDATE"));

                        if (staff == null)
                        {
                            MessageBox.Show("Mã nhân viên không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    btnCancelStaff.PerformClick();
                }
            } catch (SqlException ex)
            {
                //switch (ex.Errors[0].Message)
                //{
                //    case "-1":
                //        MessageBox.Show("Mã nhân viên không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        break;
                //    case "-2":
                //        MessageBox.Show("Nhân viên đã bị xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        break;
                //    case "-3":
                //        MessageBox.Show("Phái phải là Nam hoặc Nữ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        break;
                //    case "-4":
                //        MessageBox.Show("Cần tạo mã nhân viên mới tại chi nhanh chuyển đến!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        break;
                //    case "-5":
                //        MessageBox.Show("Mã nhân viên bên chi nhánh mới đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        break;
                //    case "-6":
                //        MessageBox.Show("Mã nhân viên bên chi nhánh mới đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        break;
                //    case "-7":
                //        MessageBox.Show("Mã chi nhánh không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        break;
                //    default:
                //        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        break;
                //}
                MessageBox.Show(ex.Errors[0].Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        public void Add(NhanVien nv)
        {
            var db = new NGANHANG();
            //db.Database.ExecuteSqlCommandAsync("themNhanVien @p0, @p1, @p2, @p3, @p4, @p5, @p6", parameters: new[] {nv.MANV, nv.HO,
            //              nv.TEN, nv.DIACHI, nv.PHAI, nv.SODT, nv.MACN.Trim(' ')});

            var staff = db.NhanViens.Find(nv.MANV);
            staff.TrangThaiXoa = 0;
            db.SaveChanges();

            dgvStaff.Rows.Add(nv.MANV, nv.MACN, nv.HO,
                         nv.TEN, nv.DIACHI, nv.PHAI, nv.SODT);
        }

        public void Delete(NhanVien nv)
        {
            try
            {
                var db = new NGANHANG();
                var temp = db.NhanViens.Find(nv.MANV);

                foreach (DataGridViewRow row in dgvStaff.Rows)
                {
                    if (string.Equals(row.Cells[0].Value.ToString().Trim(' '), temp.MANV.Trim(' '), StringComparison.OrdinalIgnoreCase))
                    {
                        dgvStaff.Rows.RemoveAt(row.Index);
                        break;
                    }
                }

                //db.Entry(temp).State = EntityState.Deleted;
                temp.TrangThaiXoa = 1;
                db.SaveChanges();
            }
            catch 
            {

            }

        }

        public void Update(NhanVien nv)
        {
            var db = new NGANHANG();
            db.Database.ExecuteSqlCommand("capNhatNhanVien @p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7", parameters: new[] {nv.MANV, nv.HO,
                    nv.TEN, nv.DIACHI, nv.PHAI, nv.SODT, nv.MACN, " "});

            
            foreach (DataGridViewRow row in dgvStaff.Rows)
            {
                if (string.Equals(row.Cells[0].Value.ToString().Trim(' '), nv.MANV.Trim(' '), StringComparison.OrdinalIgnoreCase))
                { 
                    dgvStaff.Rows[row.Index].Cells[1].Value = nv.MACN;
                    dgvStaff.Rows[row.Index].Cells[2].Value = nv.HO;
                    dgvStaff.Rows[row.Index].Cells[3].Value = nv.TEN;
                    dgvStaff.Rows[row.Index].Cells[4].Value = nv.DIACHI;
                    dgvStaff.Rows[row.Index].Cells[5].Value = nv.PHAI;
                    dgvStaff.Rows[row.Index].Cells[6].Value = nv.SODT;
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
    
        }

        public void Undo()
        {
            //var value = stack.UNDO();
            //if (value == null) return;
            //if (value.getAction() == "ADD")
            //{
            //    Add(value.getKey());
            //}
            //else if (value.getAction() == "DELETE")
            //{
            //    Delete(value.getKey());
            //}
            //else
            //{
            //    var db = new NGANHANG();
            //    NhanVien temp = (NhanVien)db.NhanViens.Find(value.getKey().MANV).Clone();
            //    stack.Redo.Push(new AddStaff(temp, "UPDATE"));

            //    Update(value.getKey());
            //}
            //btnCancelStaff.PerformClick();
        }

        public void Redo()
        {
            //var value = stack.REDO();

            //if (value == null) return;
            //if (value.getAction() == "ADD")
            //{
            //    Add(value.getKey());
            //}
            //else if (value.getAction() == "DELETE")
            //{
            //    Delete(value.getKey());
            //}
            //else
            //{
            //    var db = new NGANHANG();
            //    NhanVien temp = (NhanVien)db.NhanViens.Find(value.getKey().MANV).Clone();
            //    stack.Update(new AddStaff(temp, "UPDATE"));

            //    Update(value.getKey());
            //}

            //btnCancelStaff.PerformClick();
        }
    }
}

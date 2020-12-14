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
        private UndoRedo<KhachHang, string> stack = new UndoRedo<KhachHang, string>();

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
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                using (var db = new NGANHANG())
                {
                    try
                    {
                        string gender;
                        if (rdbtnMaleCustomer.Checked)
                        {
                            gender = "NAM";
                        }
                        else gender = "NỮ";

                        db.Database.ExecuteSqlCommand("themKhachHang @p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7", parameters: new[] { tbIdCustomer.Text, tbFirstNameCustomer.Text, tbLastNameCustomer.Text, tbAddressCustomer.Text, gender, dtpDateIdCustomer.Text, cbDistributeCustomer.Text, tbPhoneNumberCustomer.Text });
                        dgvCustomer.Rows.Add(tbIdCustomer.Text, dtpDateIdCustomer.Text, tbFirstNameCustomer.Text, tbLastNameCustomer.Text, tbAddressCustomer.Text, tbPhoneNumberCustomer.Text, gender, cbDistributeCustomer.Text);
                        //undo redo
                        var kh = db.KhachHangs.Find(tbIdCustomer.Text);
                        stack.Add(new AddCustomer(kh,"ADD"));
                        btnCancelCustomer.PerformClick();        
                        MessageBox.Show("Thêm thành công!");
                    }
                    catch (SqlException ex)
                    {
                       if (ex.Errors[0].Message == "-1") MessageBox.Show("CMND đã tồn tại!", "Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
                       else if (ex.Errors[0].Message == "-2") MessageBox.Show("Phái phải là Nam hoặc Nữ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       else MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    dgvCustomer.CurrentRow.Selected = true;
                    tbIdCustomer.Enabled = false;
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
            catch
            {

            }
        }

        public bool isValid()
        {
            Regex regex;
            int flag = 1;

            if (string.IsNullOrEmpty(tbFirstNameCustomer.Text))
            {
                errorProvider.SetError(tbFirstNameCustomer, "Nhập họ!");
                flag *= 0;
            }
            else
            {      
                errorProvider.SetError(tbFirstNameCustomer, null);
            }

            if (string.IsNullOrEmpty(tbLastNameCustomer.Text))
            {
                flag *= 0;
                errorProvider.SetError(tbLastNameCustomer, "Nhập tên!");
            }
            else
            {        
                errorProvider.SetError(tbLastNameCustomer, null);
            }

            //
            if (string.IsNullOrEmpty(tbAddressCustomer.Text))
            {
                flag *= 0;
                errorProvider.SetError(tbAddressCustomer, "Nhập địa chỉ!");
            }
            else
            {         
                errorProvider.SetError(tbAddressCustomer, null);
            }

            //
            regex = new Regex(@"^[0-9]*$");
            if (string.IsNullOrEmpty(tbIdCustomer.Text))
            {
                flag *= 0;
                errorProvider.SetError(tbIdCustomer, "Nhập số CMND!");
            }
            else if (!regex.IsMatch(tbIdCustomer.Text))
            {
                flag *= 0;
                errorProvider.SetError(tbIdCustomer, "CMND/CCCD sai cú pháp!");
            }
            else if (tbIdCustomer.Text.Length != 9 && tbIdCustomer.Text.Length != 12)
            {
                flag *= 0;
                errorProvider.SetError(tbIdCustomer, "Độ dài CMND không đúng!");
            }
            else
            {      
                errorProvider.SetError(tbIdCustomer, null);
            }
            //


            regex = new Regex(@"^[0-9]*$");
            if (string.IsNullOrEmpty(tbPhoneNumberCustomer.Text))
            {
            
                flag *= 0;
                errorProvider.SetError(tbPhoneNumberCustomer, "Nhập số số điện thoại!");
            }
            else if (!regex.IsMatch(tbPhoneNumberCustomer.Text))
            {
            
                flag *= 0;
                errorProvider.SetError(tbPhoneNumberCustomer, "Số điện thoại sai cú pháp!");
            }
            else if (tbPhoneNumberCustomer.Text.Length != 10)
            {
                flag *= 0;
                errorProvider.SetError(tbPhoneNumberCustomer, "Độ dài không đúng!");
            }
            else
            {   
                errorProvider.SetError(tbPhoneNumberCustomer, null);
            }
            //
            if (!rdbtnMaleCustomer.Checked && !rdbtnFemaleCustomer.Checked)
            {             
                errorProvider.SetError(rdbtnMaleCustomer, "*");
                errorProvider.SetError(rdbtnFemaleCustomer, "*");
                flag *= 0;
            }
            else
            {
                errorProvider.SetError(rdbtnMaleCustomer, null);
                errorProvider.SetError(rdbtnFemaleCustomer, null);
            }

            if (flag == 1) return true;

            return false;
        }
           
        public void clearData()
        {
            this.dgvCustomer.Rows.Clear();
            this.dgvCustomer.Refresh();
        }

        private void tbFirstNameCustomer_Validating(object sender, CancelEventArgs e)
        {
          
        }

        private void tbLastNameCustomer_Validating(object sender, CancelEventArgs e)
        {
          
        }

        private void tbAddressCustomer_Validating(object sender, CancelEventArgs e)
        {
         
        }

        private void tbIdCustomer_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void tbPhoneNumberCustomer_Validating(object sender, CancelEventArgs e)
        {
        }

        private void rdbtnMaleCustomer_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    var customer = new KhachHang();
                    customer.CMND = tbIdCustomer.Text;
                    var db = new NGANHANG();
                    var check = db.KhachHangs.Find(tbIdCustomer.Text);

                    if (check==null)
                    {
                        MessageBox.Show("Khách hàng không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    //undo redo
                    stack.Delete(new AddCustomer(check, "DELETE"));

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
            tbIdCustomer.Enabled = true;
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
            if (isValid())
            {
                using (var db = new NGANHANG())
                {
                    try
                    {
                        // choose current
                        var khachhang = db.KhachHangs.Find(tbIdCustomer.Text);
                        if (khachhang != null)
                        {
                            stack.Update(new AddCustomer((KhachHang) khachhang.Clone(), "UPDATE"));
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

                            // db.SaveChanges();
                            db.Database.ExecuteSqlCommand("capNhatThongTinKhachHang @p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7", parameters: new[] { tbIdCustomer.Text, tbFirstNameCustomer.Text, tbLastNameCustomer.Text, tbAddressCustomer.Text, khachhang.PHAI, dtpDateIdCustomer.Text, cbDistributeCustomer.Text, tbPhoneNumberCustomer.Text });

                            dgvCustomer.Rows[dgvCustomer.SelectedRows[0].Index].Cells[1].Value = khachhang.NGAYCAP.ToShortDateString();
                            dgvCustomer.Rows[dgvCustomer.SelectedRows[0].Index].Cells[2].Value = khachhang.HO;
                            dgvCustomer.Rows[dgvCustomer.SelectedRows[0].Index].Cells[3].Value = khachhang.TEN;
                            dgvCustomer.Rows[dgvCustomer.SelectedRows[0].Index].Cells[4].Value = khachhang.DIACHI;
                            dgvCustomer.Rows[dgvCustomer.SelectedRows[0].Index].Cells[5].Value = khachhang.SODT;
                            dgvCustomer.Rows[dgvCustomer.SelectedRows[0].Index].Cells[6].Value = khachhang.PHAI;
                            dgvCustomer.Rows[dgvCustomer.SelectedRows[0].Index].Cells[7].Value = khachhang.SODT;

                            MessageBox.Show("Cập nhật thành công!");
                        } else
                        {
                            MessageBox.Show("CMND đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Errors[0].Message == "-1") MessageBox.Show("CMND đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else if (ex.Errors[0].Message == "-2") MessageBox.Show("Phái phải là Nam hoặc Nữ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var value = stack.UNDO();

            if (value == null) return;
            if (value.getAction() == "ADD")
            {
                Add(value.getKey());
            }
            else if (value.getAction() == "DELETE")
            {
                Delete(value.getKey());
            }
            else
            {
                var db = new NGANHANG();
                KhachHang temp = (KhachHang)db.KhachHangs.Find(value.getKey().CMND).Clone();
                stack.Redo.Push(new AddCustomer(temp, "UPDATE"));
                Update(value.getKey());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var value = stack.REDO();

            if (value == null) return;
            if (value.getAction() == "ADD")
            {
                Add(value.getKey());
            }
            else if (value.getAction() == "DELETE")
            {
                Delete(value.getKey());
            }
            else
            {
                var db = new NGANHANG();
                KhachHang temp = (KhachHang)db.KhachHangs.Find(value.getKey().CMND).Clone();
                stack.Update(new AddCustomer(temp, "UPDATE"));
                Update(value.getKey());
            }

            btnCancelCustomer.PerformClick();
        }

        public void Add(KhachHang nv)
        {
            var db = new NGANHANG();
            db.Database.ExecuteSqlCommand("themKhachHang @p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7", parameters: new[] { nv.CMND, nv.HO, nv.TEN, nv.DIACHI, nv.PHAI, nv.NGAYCAP.ToShortDateString(), nv.MACN, nv.SODT});
            dgvCustomer.Rows.Add(nv.CMND, nv.NGAYCAP.ToShortDateString(), nv.HO, nv.TEN, nv.DIACHI, nv.SODT, nv.PHAI, nv.MACN);
        }

        public void Delete(KhachHang nv)
        {
                var db = new NGANHANG();
                var temp = db.KhachHangs.Find(nv.CMND);

                foreach (DataGridViewRow row in dgvCustomer.Rows)
                {
                    if (string.Equals(row.Cells[0].Value.ToString().Trim(' '), temp.CMND.Trim(' '), StringComparison.OrdinalIgnoreCase))
                    {
                        dgvCustomer.Rows.RemoveAt(row.Index);
                        break;
                    }
                }
                db.Entry(temp).State = EntityState.Deleted;
                db.SaveChanges();
            
        }

        public void Update(KhachHang nv)
        {
            var db = new NGANHANG();
            db.Database.ExecuteSqlCommand("capNhatThongTinKhachHang @p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7",
                parameters: new[] { nv.CMND, nv.HO, nv.TEN, nv.DIACHI, nv.PHAI, nv.NGAYCAP.ToShortDateString(), nv.MACN, nv.SODT });

            foreach (DataGridViewRow row in dgvCustomer.Rows)
            {
                if (string.Equals(row.Cells[0].Value.ToString().Trim(' '), nv.CMND.Trim(' '), StringComparison.OrdinalIgnoreCase))
                {
                    dgvCustomer.Rows[row.Index].Cells[1].Value = nv.NGAYCAP.ToShortDateString();
                    dgvCustomer.Rows[row.Index].Cells[2].Value = nv.HO;
                    dgvCustomer.Rows[row.Index].Cells[3].Value = nv.TEN;
                    dgvCustomer.Rows[row.Index].Cells[4].Value = nv.DIACHI;
                    dgvCustomer.Rows[row.Index].Cells[5].Value = nv.SODT;
                    dgvCustomer.Rows[row.Index].Cells[6].Value = nv.PHAI;
                    dgvCustomer.Rows[row.Index].Cells[7].Value = nv.SODT;
                    break;
                }
            }
        }

        private void UCCustomer_Load(object sender, EventArgs e)
        {
            stack.Reset();
        }
    }
}

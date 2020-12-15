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
using System.Data.Entity;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace BankMonitor.views
{
    public partial class UCTransfer : UserControl
    {
        User user;

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

        public UCTransfer()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void UCTransfer_Load(object sender, EventArgs e)
        {
        }

        public void LoadData()
        {

            try
            {
                if (string.IsNullOrEmpty(user.Username)) return;
                NGANHANG db = new NGANHANG();
                db.GD_CHUYENTIEN.Load();
                this.bds.DataSource = db.GD_CHUYENTIEN.Local.ToBindingList();
            }
            catch 
            {
            }
        }

        bool isValid()
        {
            int flag = 1;
            var db = new NGANHANG();

            if (string.IsNullOrEmpty(tb_IDAccountSendTransfer.Text))
            {
                flag *= 0;
                errorProvider.SetError(tb_IDAccountSendTransfer, "Nhập TK chuyển!");
            } else if (db.TaiKhoans.Find(tb_IDAccountSendTransfer.Text) == null)
            {
                flag *= 0;
                errorProvider.SetError(tb_IDAccountSendTransfer, "Tài khoản chuyển không tồn tại!");
            } else
            {
                errorProvider.SetError(tb_IDAccountSendTransfer, null);
            }
            //
            if (string.IsNullOrEmpty(tb_IDAccountReceiveTransfer.Text))
            {
                flag *= 0;
                errorProvider.SetError(tb_IDAccountReceiveTransfer, "Nhập TK chuyển!");
            }
            else if (db.TaiKhoans.Find(tb_IDAccountReceiveTransfer.Text) == null)
            {
                flag *= 0;
                errorProvider.SetError(tb_IDAccountReceiveTransfer, "Tài khoản chuyển không tồn tại!");
            }
            else
            {
                errorProvider.SetError(tb_IDAccountReceiveTransfer, null);
            }
            //
            Regex regex = new Regex(@"^[0-9]*$");
            if (string.IsNullOrEmpty(tb_MoneyTransfer.Text))
            {
                errorProvider.SetError(tb_MoneyTransfer, "Nhập số số dư!");
                flag *= 0;
            }
            else if (Int32.Parse(tb_MoneyTransfer.Text) < 100000)
            {
                errorProvider.SetError(tb_MoneyTransfer, "Số tiền phải lớn hơn 100.000đ!");
                flag *= 0;
            }
            else if (!regex.IsMatch(tb_MoneyTransfer.Text))
            {
                errorProvider.SetError(tb_MoneyTransfer, "Sai cú pháp!");
                flag *= 0;
            }
            else
            {
                errorProvider.SetError(tb_MoneyTransfer, null);
            }

            if (flag == 0) return false;
            return true;                
        }

        public void clearData()
        {
            this.dgvTransfer.Rows.Clear();
            this.dgvTransfer.Refresh();
        }

        private void bt_SubmitTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValid())
                {
                    var db = new NGANHANG();
                    int number = db.Database.ExecuteSqlCommand("chuyenTien @p0, @p1, @p2, @p3", parameters: new[] { tb_IDAccountSendTransfer.Text, tb_MoneyTransfer.Text, tb_IDAccountReceiveTransfer.Text, tb_IdStaffTransfer.Text });
                    MessageBox.Show(number.ToString());
                }
            }
            catch (SqlException ex)
            {
                //if (ex.Errors[0].Message == "-1") MessageBox.Show("Số dư trong tài khoản không đủ", "Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
                //else if (ex.Errors[0].Message == "-2") MessageBox.Show("Số tài khoản nhận không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //else if (ex.Errors[0].Message == "-3") MessageBox.Show("Số tài khoản gửi không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Errors[0].Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewTransfer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // check unclick and click in header
            try
            {
                if (dgvTransfer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvTransfer.CurrentRow.Selected = true;
                    // tbIdAccount.Enabled = false;
                    tb_idTransfer.Text = dgvTransfer.Rows[e.RowIndex].Cells[0].FormattedValue.ToString().Trim(' ');
                    tb_DateTransfer.Text = dgvTransfer.Rows[e.RowIndex].Cells[1].FormattedValue.ToString().Trim(' ');
                    tb_IDAccountSendTransfer.Text = dgvTransfer.Rows[e.RowIndex].Cells[2].FormattedValue.ToString().Trim(' ');
                    tb_MoneyTransfer.Text = dgvTransfer.Rows[e.RowIndex].Cells[3].FormattedValue.ToString().Trim(' ');
                    tb_IDAccountReceiveTransfer.Text = dgvTransfer.Rows[e.RowIndex].Cells[4].FormattedValue.ToString().Trim(' ');
                    tb_IdStaffTransfer.Text = dgvTransfer.Rows[e.RowIndex].Cells[5].FormattedValue.ToString().Trim(' ');
                }
            }
            catch 
            {

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class UCCustomerReport : UserControl
    {
        User user = new User();

        public UCCustomerReport()
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
            cbMACN.Items.Clear();
            if (user.Role == "CHINHANH")
            {
                var temp = new NGANHANG().ChiNhanhs.First();
                cbMACN.Items.Add(temp.MACN);
            }
            else
            {
                cbMACN.Items.Add("BENTHANH");
                cbMACN.Items.Add("TANDINH");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // do khi truyền param cho sp, ta sẽ truyền kiểu string, kiểu date time đổi về string luôn

            // get time:
            //from.Text;
            //to.Text; 

            //get mã chi nhánh
            // cbMACN.TEXT


            // bắt lỗi từ dưới sp trả về
            //try
            //{

            //} catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}

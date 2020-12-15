using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankMonitor.views
{
    public partial class UCExchangeReport : UserControl
    {
        public UCExchangeReport()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // do khi truyền param cho sp, ta sẽ truyền kiểu string, kiểu date time đổi về string luôn

            // get so tai khoan 
            //tbSTK.Text;  

            // get time:
            //from.Text;
            //to.Text; 


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

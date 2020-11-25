using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace BankMonitor.model
{
    class ConnectionDatabase
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlDataReader myReader;
       // public static String servername = @"PC-DOM\MSSQLSERVER3";
        public static String username = "";
        private static String mlogin = "";
        private static String password = "";

        public static String database = "NGANHANG";
        public static String remotelogin = "LINKLOGIN";
        public static String remotepassword = "123";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mChinhanh = 0;

        public static BindingSource bds_dspm = new BindingSource();  // giữ bdsPM khi đăng nhập

        public string Mlogin
        {
            get
            {
                return mlogin;
            }

            set
            {
                mlogin = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public int Connect(String servername)
        {
           // servername = @"PC-DOM\MSSQLSERVER" + servername;
            if (ConnectionDatabase.conn != null && ConnectionDatabase.conn.State == ConnectionState.Open)
                ConnectionDatabase.conn.Close();
            try
            {
                ConnectionDatabase.connstr = "Data Source=" + servername + ";Initial Catalog=" +
                      ConnectionDatabase.database + ";User ID=" +
                      ConnectionDatabase.mlogin + ";password=" + ConnectionDatabase.password;
                ConnectionDatabase.conn.ConnectionString = ConnectionDatabase.connstr;
                ConnectionDatabase.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
              // MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public  SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, ConnectionDatabase.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (ConnectionDatabase.conn.State == ConnectionState.Closed) ConnectionDatabase.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                ConnectionDatabase.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public  DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (ConnectionDatabase.conn.State == ConnectionState.Closed) ConnectionDatabase.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public  int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut 
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua
            }
        }

        public SqlDataReader ExecProc(String nameProc)
        {
            SqlDataReader rdr = null;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand cmd = new SqlCommand(nameProc, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            rdr = cmd.ExecuteReader();
            return rdr;
        }
        public SqlDataReader ExecProcParams(String nameProc, Hashtable listParam)
        {
            SqlDataReader rdr = null;
            //conn.Open();
            SqlCommand cmd = new SqlCommand(nameProc, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            // add params
            /*
            foreach(KeyValuePair<String, object> item in listParam)
            {
                cmd.Parameters.Add(new SqlParameter(item.Key, item.Value));
            }*/
            ICollection key = listParam.Keys;
            foreach (string k in key)
            {
                cmd.Parameters.Add(new SqlParameter(k, listParam[k]));
            }
            Console.Write(nameProc);
            rdr = cmd.ExecuteReader();
            return rdr;
        }

        public void Close()
        {
            conn.Close();
        }

    }
  
}

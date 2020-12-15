using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankMonitor.datasource;

namespace BankMonitor.model
{
    class AddStaff : ICommand<NhanVien, string>
    {
        private NhanVien nhanvien;
        private string v;

        public AddStaff(NhanVien nhanvien, string v)
        {
            this.nhanvien = nhanvien;
            this.v = v;
        }

        public NhanVien Nhanvien
        {
            get
            {
                return nhanvien;
            }

            set
            {
                nhanvien = value;
            }
        }

        public string V
        {
            get
            {
                return v;
            }

            set
            {
                v = value;
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public string getAction()
        {
            return this.v;
        }

        public NhanVien getKey()
        {
            return this.nhanvien;
        }

        public void setAction(string action)
        {
            this.v = action; 
        }

        public void setKey(NhanVien nhanvien)
        {
            this.nhanvien = nhanvien;
        }
    }   
}

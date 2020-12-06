using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankMonitor.datasource;

namespace BankMonitor.model
{
    class AddCustomer : ICommand<KhachHang, string>
    {
        KhachHang key;
        string action;

        public AddCustomer(KhachHang key, string action)
        {
            this.key = key;
            this.action = action;
        }

        public KhachHang Key
        {
            get
            {
                return key;
            }

            set
            {
                key = value;
            }
        }

        public string Action
        {
            get
            {
                return action;
            }

            set
            {
                action = value;
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public string getAction()
        {
            return this.action;
        }

        public KhachHang getKey()
        {
            return this.key;
        }

        public void setAction(string action)
        {
            this.action = action;
        }

        public void setKey(KhachHang key)
        {
            this.key = key;
        }
    }
}

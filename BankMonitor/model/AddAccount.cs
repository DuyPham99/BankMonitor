using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankMonitor.datasource;

namespace BankMonitor.model
{
    class AddAccount : ICommand<TaiKhoan, string>
    {
        TaiKhoan key;
        string action;

        public TaiKhoan Key
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

        public AddAccount(TaiKhoan key, string action)
        {
            this.key = key;
            this.action = action;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public string getAction()
        {
            return this.action;
        }

        public TaiKhoan getKey()
        {
            return this.key;
        }

        public void setAction(string action)
        {
            this.action = action;
        }

        public void setKey(TaiKhoan key)
        {
            this.key = key;
        }
    }
}

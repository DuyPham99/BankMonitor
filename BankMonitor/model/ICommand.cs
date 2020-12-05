using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMonitor.model
{
    public interface ICommand<K, V>
    {
        K getKey();
        string getAction();
        void setKey(K key);
        void setAction(string action);
        object Clone();
    }
}

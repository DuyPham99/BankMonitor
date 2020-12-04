using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankMonitor.model;

namespace BankMonitor.model
{
    public class UndoRedo<K, V>
    { 
        Stack<ICommand<K, V>> undo;
        Stack<ICommand<K, V>> redo;

        public Stack<ICommand<K, V>> Undo
        {
            get
            {
                return undo;
            }

            set
            {
                undo = value;
            }
        }

        public Stack<ICommand<K, V>> Redo
        {
            get
            {
                return redo;
            }

            set
            {
                redo = value;
            }
        }

        public UndoRedo()
        {
            Reset();
        }

        public void Reset()
        {
            undo = new Stack<ICommand<K, V>>();
            redo = new Stack<ICommand<K, V>>();
        }

        public int getCountUndoo()
        {
            return undo.Count;
        }

        public int getCountRedo()
        {
            return redo.Count;
        }

        public void Add(ICommand<K, V> value)
        {
            value.setAction("DELETE");
            undo.Push(value);
        }

        public void Delete(ICommand<K, V> value)
        {
            value.setAction("ADD");
            undo.Push(value);
        }

        public void Update(ICommand<K, V> value)
        {
            value.setAction("UPDATE");
            undo.Push(value);
        }

        public ICommand<K, V> UNDO()
        {
            try
            {
                var value = undo.Pop();
                string temp = value.getAction();
                switch (value.getAction())
                {
                    case "ADD":
                        value.setAction("DELETE");
                        redo.Push(value);
                        break;
                    case "DELETE":
                        value.setAction("ADD");
                        redo.Push(value);
                        break;
                    //case "UPDATE":
                    //    value.setAction("UPDATE");
                    //    redo.Push(value);
                    //    return data;
                }
                value.setAction(temp);

                return value;
            }
            catch (Exception ex)
            {

            }
            return null;
        }

        public ICommand<K, V> REDO()
        {
            var value = redo.Pop();
            var temp = value;
            switch (value.getAction())
            {
                case "ADD":
                    value.setAction("DELETE");
                    undo.Push(value);
                    break;
                case "DELETE":
                    value.setAction("ADD");
                    undo.Push(value);
                    break;
                //case "UPDATE":
                //    data.setAction("UPDATE");
                //    undo.Push(data);
                //    return data;
            }
            return temp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
                ICommand<K, V> temp = (ICommand < K, V >)value.Clone();
                switch (value.getAction())
                {
                    case "ADD":
                        temp.setAction("DELETE");
                        redo.Push(temp);
                        break;
                    case "DELETE":
                        temp.setAction("ADD");
                        redo.Push(temp);
                        break;
                    case "UPDATE":
                        return value;
                }
                return value;
            }
            catch (Exception ex)
            {

            }
            return null;
        }

        public ICommand<K, V> REDO()
        {
            try
            {
                var value = redo.Pop();
                ICommand<K, V> temp = (ICommand<K, V>)value.Clone();
                switch (value.getAction())
                {
                    case "ADD":
                        temp.setAction("DELETE");
                        undo.Push(temp);
                        break;
                    case "DELETE":
                        temp.setAction("ADD");
                        undo.Push(temp);
                        break;
                    case "UPDATE":
                        return value;
                }
                return value;
            }
            catch (Exception ex)
            {

            }
            return null;
        }
    }
}

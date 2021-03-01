using System;
using System.Collections.Generic;
using System.Linq;

namespace InheritanceExercise
{
    public class Stack
    {
        private object _obj;
        private List<object> list = new List<object>();

        internal object Pop()
        {
            if (list.Count == 0)
                throw new InvalidOperationException(".Pop() is not available on a list that has no items.");

            _obj = list.FirstOrDefault();
            list.RemoveAt(0);
            return _obj;
        }

        internal void Push(object obj)
        {
            _obj = obj;
            if(_obj == null)
                throw new InvalidOperationException("You are trying to push a null item...");

            list.Insert(0, _obj);
        }

        internal void Clear()
        {
            if(list.Count == 0 )
                throw new InvalidOperationException("List is already clear.");
            list.Clear();
        }

        public void Print()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("List is empty.");
            }
            foreach(var s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
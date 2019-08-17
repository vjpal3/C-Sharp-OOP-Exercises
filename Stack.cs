using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Stack
    {
        private readonly List<Object> list = new List<Object> ();

        public void Push(Object obj)
        {
            if(obj == null)           
                throw new InvalidOperationException("Null value cannot be stored on stack!");            

            list.Add(obj);
        }

        public Object Pop()
        {
            if(list.Count == 0)           
                throw new InvalidOperationException("The stack is empty!");

            var lastIndex = list.Count - 1;
            var obj = list[lastIndex];
            list.RemoveAt(lastIndex);
            return obj;
        }

        public void Clear()
        {
            list.Clear();
        }
    }
}

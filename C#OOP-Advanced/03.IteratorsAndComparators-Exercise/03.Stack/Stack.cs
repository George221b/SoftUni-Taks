using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03.Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> stack;

        public Stack()
        {
            this.stack = new List<T>();
        }

        public void Push(params T[] collection)
        {
            this.stack.AddRange(collection);
        }

        public void Pop()
        {
            if (this.stack.Count > 0)
            {
                this.stack.Remove(this.stack.Last());
            }
            else
            {
                throw new ArgumentException("No elements");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.stack.Count - 1; i >= 0; i--)
            {
                yield return this.stack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

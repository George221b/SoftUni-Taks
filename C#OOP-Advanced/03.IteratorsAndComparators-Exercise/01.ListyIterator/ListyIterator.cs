using System;
using System.Collections;
using System.Collections.Generic;

namespace _01.ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> collection;
        private int index;

        public ListyIterator(params T[] elements)
        {
            this.collection = new List<T>(elements);
            this.index = 0;
        }

        public void Create(params T[] elements)
        {
            this.collection.AddRange(elements);
        }

        public bool Move()
        {
            if (this.index < this.collection.Count - 1)
            {
                index++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            bool result =  ++this.index <= this.collection.Count - 1;
            this.index--;
            return result;
        }

        public void Print()
        {
            if (this.collection.Count == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }
            Console.WriteLine(this.collection[this.index]);
        }

        public void PrintAll()
        {
            Console.WriteLine(string.Join(" ", this.collection));
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.collection.Count; i++)
            {
                yield return this.collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

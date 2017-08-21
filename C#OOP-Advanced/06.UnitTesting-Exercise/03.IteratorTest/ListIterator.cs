using System;
using System.Collections.Generic;

namespace _03.IteratorTest
{
    public class ListIterator
    {
        private List<string> collection;
        private int indexPosition;

        public ListIterator(params string[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException();
            }

            this.collection = new List<string>(elements);
        }

        public bool HasNext()
        {
            return this.indexPosition + 1 <= this.collection.Count - 1;
        }

        public bool Move()
        {
            if (this.HasNext())
            {
                this.indexPosition++;
                return true;
            }

            return false;
        }

        public string Print()
        {
            if (this.collection == null || this.collection.Count == 0)
            {
                throw new ArgumentNullException("Invalid Operation!");
            }

            return this.collection[this.indexPosition];
        }
    }
}

using System;
using System.Collections.Generic;

namespace _01.Database
{
    public class Database
    {
        private const int DataCapacity = 16;
        private List<int> data;

        public Database(params int[] ints)
        {
            this.Data = new List<int>(ints);
        }

        public List<int> Data
        {
            get { return this.data; }
            private set
            {
                if (value.Count > DataCapacity)
                {
                    throw new InvalidOperationException("Data can't be more than 16 integers.");
                }

                this.data = value;
            }
        }

        public int Count { get { return this.Data.Count; } }

        public void Add(int element)
        {
            if (this.Data.Count >= DataCapacity)
            {
                throw new InvalidOperationException("Can't add more elements.");
            }

            this.Data.Add(element);
        }

        public void Remove()
        {
            if (this.Data.Count == 0 || this.Data == null)
            {
                throw new InvalidOperationException("Data is empty.");
            }

            this.Data.Remove(this.Data[this.Data.Count - 1]);
        }

        public int[] Fetch()
        {
            return this.Data.ToArray();
        }
    }
}

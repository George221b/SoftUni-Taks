using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CustomList.Interfaces;

namespace CustomList
{
    class CustomList<T> : ICustomList<T>
        where T: IComparable
    {
        public List<T> List { get; set; }

        public CustomList()
        {
            this.List = new List<T>();
        }

        public void Add(T element)
        {
            this.List.Add(element);
        }

        public T Remove(int index)
        {
            var element = this.List[index];
            this.List.Remove(element);
            return element;
        }

        public bool Contains(T element)
        {
            return this.List.Contains(element);
        }

        public void Swap(int index1, int index2)
        {
            var temp = this.List[index1];
            this.List[index1] = this.List[index2];
            this.List[index2] = temp;
        }

        public int CountGreaterThan(T element)
        {
            int count = 0;

            foreach (var item in this.List)
            {
                if (element.CompareTo(item) < 0)
                {
                    count++;
                }
            }

            return count;
        }

        public T Max()
        {
            return this.List.Max();
        }

        public T Min()
        {
            return this.List.Min();
        }

        //public IEnumerator GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}
    }
}

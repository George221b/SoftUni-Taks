using System;
using System.Collections.Generic;

namespace GenericCount
{
    public class Startup
    {
        public static void Main()
        {
            List<IComparable> myList = new List<IComparable>();

            int numberOfElementsToAdd = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfElementsToAdd; i++)
            {
                var element = double.Parse(Console.ReadLine());
                myList.Add(element);
            }

            var elementToCompare = double.Parse(Console.ReadLine());
            Console.WriteLine(CountOfElementsGreaterThan(myList, elementToCompare));
        }

        private static int CountOfElementsGreaterThan<T>(List<T> list, T element)
            where T : IComparable
        {
            int count = 0;

            foreach (var item in list)
            {
                if (element.CompareTo(item) < 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}

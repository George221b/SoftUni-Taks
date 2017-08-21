using System.Collections.Generic;
using _06.StrategyPattern.Models;

namespace _06.StrategyPattern.Comparators
{
    public class AgeComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}

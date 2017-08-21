using System.Collections.Generic;
using _06.StrategyPattern.Models;

namespace _06.StrategyPattern.Comparators
{
    class NameComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int result = x.Name.Length.CompareTo(y.Name.Length);
            if (result == 0)
            {
                char xLetter = char.Parse(x.Name.Substring(0, 1).ToLower());
                char yLetter = char.Parse(y.Name.Substring(0, 1).ToLower());

                result = xLetter.CompareTo(yLetter);

                return result;
            }

            return result;
        }
    }
}

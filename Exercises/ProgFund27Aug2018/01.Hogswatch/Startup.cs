namespace _01.Hogswatch
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var homesToVisit = int.Parse(Console.ReadLine());
            var numberOfPresents = int.Parse(Console.ReadLine());

            var initialNumberOfPresents = numberOfPresents;
            var numberOfReturns = 0;
            var totalNumberOfGiftsFromReturn = 0;

            for (int i = 1; i <= homesToVisit; i++)
            {
                var childrenPerHouse = int.Parse(Console.ReadLine());

                if (numberOfPresents >= childrenPerHouse)
                {
                    numberOfPresents -= childrenPerHouse;
                }
                else
                {
                    var currentReturn =
                        ((initialNumberOfPresents / i) * (homesToVisit - i))
                        + (childrenPerHouse - numberOfPresents);

                    numberOfReturns++;
                    totalNumberOfGiftsFromReturn += currentReturn;

                    numberOfPresents += currentReturn;
                    numberOfPresents -= childrenPerHouse;
                }
            }

            if (numberOfReturns == 0)
            {
                Console.WriteLine(numberOfPresents);
            }
            else
            {
                Console.WriteLine(numberOfReturns);
                Console.WriteLine(totalNumberOfGiftsFromReturn);
            }
        }
    }
}

namespace _01.PadawanEquipment
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var money = decimal.Parse(Console.ReadLine());
            var studentsCount = int.Parse(Console.ReadLine());
            var lightsaberPrice = decimal.Parse(Console.ReadLine());
            var robePrice = decimal.Parse(Console.ReadLine());
            var beltPrice = decimal.Parse(Console.ReadLine());

            var freeBelts = studentsCount / 6;

            var moneyNeeded = (lightsaberPrice * (Math.Ceiling((studentsCount * 1.1m)))
                + (robePrice * studentsCount)
                + (beltPrice * (studentsCount - freeBelts)));

            if(money - moneyNeeded >= 0)
            {
                Console.WriteLine($"The money is enough - it would cost {moneyNeeded:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {Math.Abs(money - moneyNeeded):F2}lv more.");
            }
        }
    }
}

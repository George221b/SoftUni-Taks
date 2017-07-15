using System;
using System.Reflection;

namespace _03.OldestFamilyMember
{
    public class Startup
    {
        public static void Main()
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            int numberOfPersonsToRead = int.Parse(Console.ReadLine());
            var family = new Family();

            for (int i = 0; i < numberOfPersonsToRead; i++)
            {
                var inputArgs = Console.ReadLine().Split();

                var member = new Person(inputArgs[0], int.Parse(inputArgs[1]));
                family.AddMember(member);
            }

            var oldestOne = family.GetOldestMember();

            Console.WriteLine($"{oldestOne.Name} {oldestOne.Age}");
        }
    }
}

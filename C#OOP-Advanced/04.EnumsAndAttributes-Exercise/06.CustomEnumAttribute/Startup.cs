using System;

namespace _06.CustomEnumAttribute
{
    public class Startup
    {
        public static void Main()
        {
            var searchCategoryAttribute = Console.ReadLine();

            var mainAssembly = typeof(Startup).Assembly;
            foreach (Type type in mainAssembly.GetTypes())
            {
                //Console.WriteLine(type.FullName);
                foreach (object attr in type.GetCustomAttributes(typeof(TypeAttribute), false))
                {
                    var attribute = (TypeAttribute)attr;
                    if (attribute.Category == searchCategoryAttribute)
                    {
                        Console.WriteLine($"Type = {attribute.Type}, Description = {attribute.Description}");
                    }
                }
            }
        }
    }
}

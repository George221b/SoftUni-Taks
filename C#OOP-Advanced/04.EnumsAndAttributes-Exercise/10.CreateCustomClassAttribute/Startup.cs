using System;

namespace _10.CreateCustomClassAttribute
{
    public class Startup
    {
        public static void Main()
        {
            var assembly = typeof(Startup).Assembly;

            foreach (Type type in assembly.GetTypes())
            {
                var attributes = type.GetCustomAttributes(typeof(CustomAttribute), false);

                foreach (object attribute in attributes)
                {
                    var customAttribute = (CustomAttribute)attribute;
                    Console.WriteLine(customAttribute);
                }
            }
        }
    }
}

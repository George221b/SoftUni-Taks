using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.CatLady
{
    public class Startup
    {
        public static void Main()
        {
            var cats = new HashSet<Cat>();

            var inputLine = Console.ReadLine();
            while (inputLine != "End")
            {
                var catArgs = inputLine.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var typeOfCat = catArgs[0].ToLower();
                switch (typeOfCat)
                {
                    case "siamese":
                        var siameseCat = new Siamese(catArgs[1], int.Parse(catArgs[2]));
                        cats.Add(siameseCat);
                        break;
                    case "streetextraordinaire":
                        var streetCat = new StreetExtraordinaire(catArgs[1], int.Parse(catArgs[2]));
                        cats.Add(streetCat);
                        break;
                    case "cymric":
                        var cymricCat = new Cymric(catArgs[1], double.Parse(catArgs[2]));
                        cats.Add(cymricCat);
                        break;
                }

                inputLine = Console.ReadLine();
            }

            var catToFind = Console.ReadLine();
            Console.WriteLine(cats.FirstOrDefault(c => c.Name == catToFind).ToString());
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _01HarestingFields
{
    using System;

    class HarvestingFieldsTest
    {
        static void Main()
        {
            var command = Console.ReadLine();

            Type classToHarvest = typeof(HarvestingFields);
            FieldInfo[] fieldsToHarvest =
                classToHarvest.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            var dict = new Dictionary<string, Func<FieldInfo[]>>()
            {
                {"protected", () =>  fieldsToHarvest.Where(f => f.IsFamily).ToArray()},
                {"private", () =>  fieldsToHarvest.Where(f => f.IsPrivate).ToArray()},
                {"public", () =>  fieldsToHarvest.Where(f => f.IsPublic).ToArray()},
                {"all", () =>  fieldsToHarvest}
            };


            FieldInfo[] gatherdFields;
            while (command != "HARVEST")
            {
                dict[command]()
                    .Select(f =>
                        $"{f.Attributes.ToString().ToLower()} {f.FieldType.Name} {f.Name}")
                    .ToList()
                    .ForEach(r => Console.WriteLine(r.Replace("family", "protected")));

                command = Console.ReadLine();
            }
        }
    }
}

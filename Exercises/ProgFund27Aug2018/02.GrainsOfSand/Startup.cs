namespace _02.GrainsOfSand
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var elements = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var inputLine = Console.ReadLine();

            while (inputLine != "Mort")
            {
                var cmdTokens = inputLine
                                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();

                if (cmdTokens[0] == "Add")
                {
                    var elementToAdd = int.Parse(cmdTokens[1]);

                    elements.Add(elementToAdd);
                }
                else if (cmdTokens[0] == "Remove")
                {
                    var valueOrIndex = int.Parse(cmdTokens[1]);
                    var isRemoved = false;

                    for (int i = 0; i < elements.Count; i++)
                    {
                        if (elements[i] == valueOrIndex)
                        {
                            elements.Remove(valueOrIndex);
                            isRemoved = true;
                            break;
                        }
                    }

                    if (isRemoved == false && 
                        (valueOrIndex >= 0 && valueOrIndex < elements.Count))
                    {
                        for (int i = 0; i < elements.Count; i++)
                        {
                            if (i == valueOrIndex)
                            {
                                elements.RemoveAt(valueOrIndex);
                                isRemoved = true;
                                break;
                            }
                        }
                    }
                }
                else if (cmdTokens[0] == "Replace")
                {
                    var toReplace = int.Parse(cmdTokens[1]);
                    var replacement = int.Parse(cmdTokens[2]);

                    for (int i = 0; i < elements.Count; i++)
                    {
                        if (elements[i] == toReplace)
                        {
                            elements[i] = replacement;
                            break;
                        }
                    }
                }
                else if (cmdTokens[0] == "Increase")
                {
                    var searchedValue = int.Parse(cmdTokens[1]);
                    var isIncreased = false;

                    for (int i = 0; i < elements.Count; i++)
                    {
                        if (elements[i] >= searchedValue)
                        {
                            elements = elements
                                .Select(e => e = e + elements[i])
                                .ToList();

                            isIncreased = true;
                            break;
                        }
                    }

                    if (isIncreased == false)
                    {
                        var lastEl = elements[elements.Count - 1];

                        elements = elements
                            .Select(e => e = e + lastEl)
                            .ToList();
                    }
                }
                else if (cmdTokens[0] == "Collapse")
                {
                    var valueToCollapseRemove = int.Parse(cmdTokens[1]);
                    elements = elements
                        .Where(e => e >= valueToCollapseRemove)
                        .ToList();
                }


                inputLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}

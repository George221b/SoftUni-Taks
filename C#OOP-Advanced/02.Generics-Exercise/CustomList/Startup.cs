using System;
using System.Linq;
using CustomList.Core;

namespace CustomList
{
    public class Startup
    {
        public static void Main()
        {
            var commandInterpreter = new CommandInterpreter();
            var inputLine = Console.ReadLine();

            while (inputLine != "END")
            {
                var tokens = inputLine.Split().ToList();
                commandInterpreter.ProcessCommand(tokens);

                inputLine = Console.ReadLine();
            }
        }
    }
}

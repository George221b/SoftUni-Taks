using System;
using _01.EventImplementation.Models;

namespace _01.EventImplementation
{
    public class Startup
    {
        public static void Main()
        {
            var dispatcher = new Dispatcher();
            var handler = new Handler();

            dispatcher.NameChange += handler.OnDispatcherNameChange;

            var dispatcherName = Console.ReadLine();

            while (dispatcherName != "End")
            {
                dispatcher.Name = dispatcherName;
                dispatcherName = Console.ReadLine();
            }
        }
    }
}

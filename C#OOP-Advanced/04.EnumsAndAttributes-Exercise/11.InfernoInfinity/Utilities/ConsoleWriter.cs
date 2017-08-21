using System;

namespace _11.InfernoInfinity.Utilities
{
    public static class ConsoleWriter
    {
        public static void WriteLine<T>(T item)
        {
            Console.WriteLine(item.ToString());
        }
    }
}

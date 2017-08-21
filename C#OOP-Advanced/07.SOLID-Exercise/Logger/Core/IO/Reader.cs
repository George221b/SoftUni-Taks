using System;
using Logger.Interfaces;

namespace Logger.Core.IO
{
    public class Reader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}

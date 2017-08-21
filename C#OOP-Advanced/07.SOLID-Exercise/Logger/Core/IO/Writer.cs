using System;
using Logger.Interfaces;

namespace Logger.Core.IO
{
    public class Writer : IWriter
    {
        public void WriteLine(string content)
        {
            Console.WriteLine(content);
        }
    }
}

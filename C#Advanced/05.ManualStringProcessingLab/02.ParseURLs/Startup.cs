using System;

namespace _02.ParseURLs
{
    public class Startup
    {
        public static void Main()
        {
            var inputArgs = Console.ReadLine().Split(new string[] { "://" }, StringSplitOptions.None);

            if (inputArgs.Length != 2 || inputArgs[1].IndexOf('/') == -1)
            {
                Console.WriteLine("Invalid URL");
                return;
            }

            string protocol = inputArgs[0];
            string server = inputArgs[1].Substring(0, inputArgs[1].IndexOf('/'));
            string resource = inputArgs[1].Substring(inputArgs[1].IndexOf('/') + 1);

            Console.WriteLine("Protocol = {0}", protocol);
            Console.WriteLine("Server = {0}", server);
            Console.WriteLine("Resources = {0}", resource);
        }
    }
}

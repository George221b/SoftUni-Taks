using System;

public class Startup
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split();
        var urls = Console.ReadLine().Split();

        Smarthphone phone = new Smarthphone();

        foreach (var number in numbers)
        {
            try
            {
                Console.WriteLine(phone.Call(number));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        foreach (var url in urls)
        {
            try
            {
                Console.WriteLine(phone.Browse(url));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
using System;

public class Startup
{
    public static void Main()
    {
        string model = "488-Spider";
        var name = Console.ReadLine();

        ICar car = new Ferrari(model, name);

        Console.WriteLine(car);

        // Checks with reflection

        string ferrariName = typeof(Ferrari).Name;
        string iCarInterfaceName = typeof(ICar).Name;

        bool isCreated = typeof(ICar).IsInterface;
        if (!isCreated)
        {
            throw new Exception("No interface ICar was created");
        }
    }
}

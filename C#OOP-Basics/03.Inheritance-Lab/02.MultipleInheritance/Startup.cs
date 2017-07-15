using System;

public class Startup
{
    public static void Main()
    {
        Puppy puppy = new Puppy();
        Console.WriteLine("{0}\n\r{1}\n\r{2}",
        puppy.Eat(),
        puppy.Bark(),
        puppy.Weep());
    }
}
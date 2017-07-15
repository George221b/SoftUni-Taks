using System;

public class Startup
{
    public static void Main()
    {
        Dog dog = new Dog();
        Console.WriteLine(dog.Eat());
        Console.WriteLine(dog.Bark());
    }
}
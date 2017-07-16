using System;
using System.Collections.Generic;

public static class ProviderFactory
{
    public static Provider GetProvider(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];
        var energy = double.Parse(arguments[2]);

        switch (type)
        {
            case "Solar":
                return new SolarProvider(id, energy);
                break;
            case "Pressure":
                return new PressureProvider(id, energy);
                break;
            default:
                throw new ArgumentException("Provider failed to be created.");
                break;
        }
    }
}
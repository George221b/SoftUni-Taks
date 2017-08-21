public class Ferrari : ICar
{
    public Ferrari(string model, string driverName)
    {
        Model = model;
        DriverName = driverName;
    }

    public string Model { get; private set; }
    public string DriverName { get; private set; }

    public string Brake()
    {
        return "Brakes!";
    }

    public string Gas()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{this.Model}/{this.Brake()}/{this.Gas()}/{this.DriverName}";
    }
}

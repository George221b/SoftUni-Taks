public class WaterBender : Bender
{
    private double waterClarity;
    private double totalPower;

    public WaterBender(string name, int power, double waterClarity)
        : base(name, power)
    {
        this.WaterClarity = waterClarity;
    }

    public double WaterClarity
    {
        get { return this.waterClarity; }
        set { this.waterClarity = value; }
    }

    public override double GetPower() => this.Power * this.WaterClarity;

    public override string ToString()
    {
        return $"{base.ToString()}, Water Clarity: {this.WaterClarity:F2}";
    }
}

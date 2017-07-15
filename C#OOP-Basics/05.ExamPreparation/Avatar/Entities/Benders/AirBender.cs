public class AirBender : Bender
{
    private double aerialIntegrity;
    private double totalPower;

    public AirBender(string name, int power, double aerialIntegrity)
        : base(name, power)
    {
        this.AerialIntegrity = aerialIntegrity;
    }

    public double AerialIntegrity
    {
        get { return this.aerialIntegrity; }
        set { this.aerialIntegrity = value; }
    }

    public override double GetPower() => this.Power * this.AerialIntegrity;

    public override string ToString()
    {
        return $"{base.ToString()}, Aerial Integrity: {this.AerialIntegrity:F2}";
    }
}

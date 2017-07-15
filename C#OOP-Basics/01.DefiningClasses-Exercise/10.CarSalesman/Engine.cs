namespace _10.CarSalesman
{
    public class Engine
    {
        private string model;
        private int power;
        private string displacement;
        private string efficiency;

        public Engine(string model, int power)
        {
            this.model = model;
            this.power = power;
            this.displacement = "n/a";
            this.efficiency = "n/a";
        }

        public Engine(string model, int power, string displacement, string efficiency)
            : this(model, power)
        {
            this.displacement = displacement;
            this.efficiency = efficiency;
        }

        public string Efficiency
        {
            get { return  this.efficiency; }
            set {  this.efficiency = value; }
        }


        public string Displacement
        {
            get { return this.displacement; }
            set { this.displacement = value; }
        }


        public int Power
        {
            get { return power; }
        }


        public string Model
        {
            get { return model; }
        }

    }
}

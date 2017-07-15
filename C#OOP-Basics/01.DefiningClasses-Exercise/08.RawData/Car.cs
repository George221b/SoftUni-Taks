namespace _08.RawData
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tire[] tires;

        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType, double tire1Age, double tire1Pressure, double tire2Age, double tire2Pressure, double tire3Age, double tire3Pressure, double tire4Age, double tire4Pressure)
        {
            this.model = model;
            this.engine = new Engine() {Speed = engineSpeed, Power = enginePower};
            this.cargo = new Cargo() {Type = cargoType, Weight = cargoWeight};
            this.tires = new Tire[4]
            {
                new Tire() {Age = tire1Age, Pressure = tire1Pressure}, 
                new Tire() {Age = tire2Age, Pressure = tire2Pressure}, 
                new Tire() {Age = tire3Age, Pressure = tire3Pressure}, 
                new Tire() {Age = tire4Age, Pressure = tire4Pressure}
            };
        }

        public string Model { get { return this.model; } }

        public Cargo Cargo { get { return this.cargo; } }

        public Engine Engine { get { return this.engine; } }

        public Tire[] Tires { get { return this.tires; } }
    }
}

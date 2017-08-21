using System.Text;
using _02.Cars.Interfaces;

namespace _02.Cars.Models
{
    public class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color, int batteries)
        {
            this.Model = model;
            this.Color = color;
            this.Batteries = batteries;
        }

        public string Model { get; private set; }
        public string Color { get; private set; }
        public int Batteries { get; private set; }

        public string Start()
        {
            return "Breaaak!";
        }

        public string Stop()
        {
            return "Engine start";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Color} {this.GetType().Name} {this.Model} with {this.Batteries} Batteries")
                .AppendLine(this.Start())
                .AppendLine(this.Stop());

            return sb.ToString().Trim();
        }
    }
}

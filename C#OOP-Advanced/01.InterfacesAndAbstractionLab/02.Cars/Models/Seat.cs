using System.Text;
using _02.Cars.Interfaces;

namespace _02.Cars.Models
{
    public class Seat : ICar
    {
        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public string Model { get; private set; }
        public string Color { get; private set; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Color} {this.GetType().Name} {this.Model}")
                .AppendLine(this.Start())
                .AppendLine(this.Stop());

            return sb.ToString().Trim();
        }
    }
}

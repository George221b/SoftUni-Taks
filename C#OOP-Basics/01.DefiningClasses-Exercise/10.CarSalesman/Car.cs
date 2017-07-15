using System;

namespace _10.CarSalesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private string weight;
        private string color;

        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;
            this.color = "n/a";
            this.weight = "n/a";
        }

        public Car(string model, Engine engine, string weight, string color)
            : this(model, engine)
        {
            this.weight = weight;
            this.color = color;
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }


        public string Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }


        public Engine Engine
        {
            get { return this.engine; }
        }


        public string Model
        {
            get { return this.model; }
        }

        public override string ToString()
        {
            //FordMondeo:
            //  DSL - 13:
            //    Power: 305
            //    Displacement: 55
            //    Efficiency: A +
            //  Weight: n / a
            //  Color: Purple

            return $"{this.Model}:" + Environment.NewLine
                   + $"  {this.Engine.Model}:" + Environment.NewLine
                   + $"    Power: {this.Engine.Power}" + Environment.NewLine
                   + $"    Displacement: {this.Engine.Displacement}" + Environment.NewLine
                   + $"    Efficiency: {this.Engine.Efficiency}" + Environment.NewLine
                   + $"  Weight: {this.Weight}" + Environment.NewLine
                   + $"  Color: {this.Color}";
        }
    }
}

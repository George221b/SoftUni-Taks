namespace _14.CatLady
{
    class Cymric : Cat
    {
        private double furrLength;

        public Cymric(string name, double furrLength)
        {
            this.Name = name;
            this.FurrLength = furrLength;
        }

        public double FurrLength
        {
            get { return this.furrLength; }
            set { this.furrLength = value; }
        }

        public override string ToString()
        {
            return $"Cymric {this.Name} {this.FurrLength:F2}";
        }
    }
}

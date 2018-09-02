namespace _04.IronGirder
{
    public class Town
    {
        public Town(string name, int time, int passangers)
        {
            this.Name = name;
            this.BestTime = time;
            this.Passangers = passangers;
        }

        public string Name { get; set; }

        public int BestTime { get; set; }

        public int Passangers { get; set; }


        public void AmbushTown(int passangers)
        {
            this.BestTime = 0;
            this.Passangers -= passangers;
        }

        public override string ToString()
        {
            return $"{this.Name} -> Time: {this.BestTime} -> Passengers: {this.Passangers}";
        }
    }
}

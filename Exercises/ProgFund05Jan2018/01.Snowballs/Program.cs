namespace _01.Snowballs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var snowballs = new List<Snowball>();

            for (int i = 0; i < n; i++)
            {
                var snow = int.Parse(Console.ReadLine());
                var time = int.Parse(Console.ReadLine());
                var quality = int.Parse(Console.ReadLine());

                var snowball = new Snowball(snow, time, quality);
                snowballs.Add(snowball);
            }

            Console.WriteLine(snowballs.OrderByDescending(s => s.Value).FirstOrDefault().ToString());
        }
    }

    public class Snowball
    {
        private int value;

        public Snowball(int snow, int time, int quality)
        {
            this.Snow = snow;
            this.Time = time;
            this.Quality = quality;
        }

        public int Snow { get; set; }

        public int Time { get; set; }

        public int Quality { get; set; }

        public double Value
        {
            get
            {
                return Math.Pow((this.Snow / this.Time), this.Quality);
            }
        }

        public override string ToString()
        {
            return $"{this.Snow} : {this.Time} = {this.Value} (){this.Quality})";
        }
    }
}

namespace _02.Snowmen
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var snowmen = new Snowman[sequence.Length];

            for (int i = 0; i < sequence.Length; i++)
            {
                var s = new Snowman { Value = sequence[i] };
                snowmen[i] = s;
            }

            while (snowmen.Length > 1)
            {
                for (int i = 0; i < snowmen.Length; i++)
                {
                    if (snowmen.Where(s => s.IsDead == false).Count() == 1)
                    {
                        break;
                    }

                    var attacker = snowmen[i];
                    var attackerIndex = i;

                    if (attacker.IsDead)
                    {
                        continue;
                    }

                    var targetIndex = attacker.Value;

                    if (targetIndex >= snowmen.Length)
                    {
                        targetIndex = targetIndex % snowmen.Length;
                    }

                    if (attackerIndex == targetIndex) // Draw
                    {
                        Console.WriteLine($"{attackerIndex} performed harakiri");
                        attacker.IsDead = true;
                        continue;
                    }

                    var winner = Math.Abs(attackerIndex - targetIndex);

                    if (winner % 2 == 0)
                    { // Attacker wins
                        snowmen[targetIndex].IsDead = true;
                        Console.WriteLine($"{attackerIndex} x {targetIndex} -> {attackerIndex} wins");
                    }
                    else if(winner % 2 == 1)
                    { // Traget wins
                        snowmen[attackerIndex].IsDead = true;
                        Console.WriteLine($"{attackerIndex} x {targetIndex} -> {targetIndex} wins");
                    }
                }

                snowmen = snowmen.Where(s => s.IsDead == false).ToArray();
            }
        }
    }

    public class Snowman
    {
        public int Value { get; set; }

        public bool IsDead { get; set; }
    }
}

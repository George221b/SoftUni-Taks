using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SecondNature
{
    public class SecondNature
    {
        public static void Main()
        {
            // Q 1, 2, 3
            // S 3, 2, 1

            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var flowers = new Queue<int>(input);

            input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var buckets = new Stack<int>(input);

            var secondNature = new List<int>();
            int flower = -1;
            while (flowers.Count > 0 && buckets.Count > 0)
            {
                var bucket = 0;
                flower = flowers.Peek();

                // pops buckets untill there is enough water to water the flower
                while (buckets.Count > 0)
                {
                    bucket += buckets.Pop();

                    // second nature
                    if (flower == bucket)
                    {
                        secondNature.Add(flower);
                        flowers.Dequeue();
                        flower = 0;
                        break;
                    }

                    if (flower < bucket)
                    {

                        // removes the flower, since it is watered
                        flowers.Dequeue();
                        bucket -= flower;
                        flower = 0;
                        if (buckets.Count > 0)
                        {
                            buckets.Push(buckets.Pop() + bucket);
                        }
                        else
                        {
                            buckets.Push(bucket);
                        }

                        break;
                    }

                    if (flower > bucket && buckets.Count == 0)
                    {
                        flower -= bucket;
                        flowers.Dequeue();
                        break;
                    }

                    if (flower > bucket)
                    {
                        flower -= bucket;
                        bucket = 0;
                    }
                }
            }

            if (buckets.Count > 0)
            {
                Console.WriteLine(string.Join(" ", buckets.ToArray()));
            }
            else
            {
                if (flower != 0)
                {
                    Console.WriteLine($"{flower} {string.Join(" ", flowers.ToArray())}");
                }
                else
                {
                    Console.WriteLine(string.Join(" ", flowers.ToArray()));
                }
            }

            if (secondNature.Count > 0)
            {
                Console.WriteLine(string.Join(" ", secondNature));
            }
            else
            {
                Console.WriteLine("None");
            }

        }
    }
}
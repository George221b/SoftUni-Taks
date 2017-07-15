using System;

namespace _12.CharacterMultiplier
{
    public class Startup
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();

            string strOne = input[0];
            string strTwo = input[1];

            Console.WriteLine(CharacterMultiplier(strOne, strTwo));

        }

        static int CharacterMultiplier(string strOne, string strTwo)
        {
            int result = 0;

            if (strOne.Length >= strTwo.Length)
            {
                for (int i = 0; i < strOne.Length; i++)
                {
                    int first = (int)(strOne[i]);

                    if (i < strTwo.Length)
                    {
                        int second = (int)(strTwo[i]);
                        result += first * second;
                    }
                    else
                    {
                        result += first;
                    }

                }

            }
            else
            {
                for (int i = 0; i < strTwo.Length; i++)
                {
                    int first = (int)(strTwo[i]);


                    if (i < strOne.Length)
                    {
                        int second = (int)(strOne[i]);
                        result += first * second;
                    }
                    else
                    {
                        result += first;
                    }
                }
            }

            return result;
        }
    }
}
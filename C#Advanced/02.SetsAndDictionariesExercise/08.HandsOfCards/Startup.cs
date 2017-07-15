using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.HandsOfCards
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dict = new Dictionary<string, HashSet<string>>();

            while (input != "JOKER")
            {
                var inputTokens = input.Split(new[] {": "}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string player = inputTokens[0];
                var cards = inputTokens[1].Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries);

                if (!dict.ContainsKey(player))
                {
                    dict[player] = new HashSet<string>(cards);
                }
                else
                {
                    foreach (var card in cards)
                    {
                        dict[player].Add(card);    
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var currentPlayer in dict)
            {
                Console.WriteLine($"{currentPlayer.Key}: {CalculateCardScore(currentPlayer.Value)}");
            }
        }

        private static int CalculateCardScore(HashSet<string> currentPlayerValue)
        {
            var result = 0;

            foreach (var card in currentPlayerValue)
            {
                var currentCard = card;
                if (card.Length == 3) currentCard = card.Replace("10", "!");
                var cardType = currentCard.Substring(currentCard.Length - 2, 1);
                var cardPower = currentCard.Replace(cardType, "");

                int power = 0;
                if (!int.TryParse(cardType, out power))
                {
                    switch (cardType)
                    {
                        case "J":
                            power = 11;
                            break;
                        case "Q":
                            power = 12;
                            break;
                        case "K":
                            power = 13;
                            break;
                        case "A":
                            power = 14;
                            break;
                        case "!":
                            power = 10;
                            break;
                    }
                }

                switch (cardPower)
                {
                    case "S":
                        result += power * 4;
                        break;
                    case "H":
                        result += power * 3;
                        break;
                    case "D":
                        result += power * 2;
                        break;
                    case "C":
                        result += power * 1;
                        break;
                }
            }

            return result;
        }
    }
}

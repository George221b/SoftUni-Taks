using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using _08.CardGame.Enums;
using _08.CardGame.Models;

namespace _08.CardGame
{
    public class Startup
    {
        public static void Main()
        {
            var deck = new Deck();
            var fPlayer = new Player();
            var sPlayer = new Player();
            var firstPlayerName = Console.ReadLine();
            var secondPlayerName = Console.ReadLine();
            fPlayer.Name = firstPlayerName;
            sPlayer.Name = secondPlayerName;

            try
            {
                FillPlayerWith5Cards(fPlayer, deck);
                FillPlayerWith5Cards(sPlayer, deck);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            string result = GetWinner(fPlayer, sPlayer);
            Console.WriteLine(result);
        }

        private static string GetWinner(Player fPlayer, Player sPlayer)
        {
            var f = fPlayer.HighestCard();
            var s = sPlayer.HighestCard();

            if (f.Power > s.Power)
            {
                return $"{fPlayer.Name} wins with {f}.";
            }

            return $"{sPlayer.Name} wins with {s}.";
        }

        private static void FillPlayerWith5Cards(Player p, Deck deck)
        {
            while (p.Cards.Count != 5)
            {
                try
                {
                    var currentCard = Console.ReadLine();
                    if (deck.DrawnCardInDeck(currentCard))
                    {
                        p.AddCard(currentCard);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static List<string> GetStringDeck()
        {
            var result = new List<string>();

            var ranks = Enum.GetNames(typeof(CardRank));
            var suits = Enum.GetNames(typeof(CardSuit));

            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    result.Add($"{rank} of {suit}");
                }
            }

            return result;
        }
    }
}

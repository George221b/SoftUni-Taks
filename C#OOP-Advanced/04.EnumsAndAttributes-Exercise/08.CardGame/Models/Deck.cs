using System;
using System.Collections.Generic;
using _08.CardGame.Enums;

namespace _08.CardGame.Models
{
    public class Deck
    {
        public Deck()
        {
            this.Cards = this.GetStringDeck();
            this.PlayedCards = new List<string>();
            this.CardCount = this.Cards.Count;
        }

        public List<string> Cards { get; set; }
        public List<string> PlayedCards { get; set; }
        public int CardCount { get; set; }

        public bool DrawnCardInDeck(string card)
        {
            if (this.Cards.Contains(card))
            {
                this.Cards.Remove(card);
                this.PlayedCards.Add(card);
                this.CardCount--;
                return true;
            }

            if (this.PlayedCards.Contains(card))
            {
                throw new ArgumentException("Card is not in the deck.");
            }

            if (!Cards.Contains(card) && !PlayedCards.Contains(card))
            {
                throw new ArgumentException("No such card exists.");
            }

            return false;
        }

        private List<string> GetStringDeck()
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

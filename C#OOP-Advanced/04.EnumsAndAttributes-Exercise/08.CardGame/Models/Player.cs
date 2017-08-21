using System.Collections.Generic;
using System.Linq;

namespace _08.CardGame.Models
{
    class Player
    {
        public Player()
        {
            this.Cards = new List<Card>();
        }

        public string Name { get; set; }
        public List<Card> Cards { get; set; }

        public void AddCard(string card)
        {
            var tokens = card.Split().ToArray();

            Card currentCard = new Card(tokens[0], tokens[2]);

            this.Cards.Add(currentCard);
        }

        public Card HighestCard()
        {
            int max = int.MinValue;
            foreach (var card in this.Cards)
            {
                if (card.Power >= max)
                {
                    max = card.Power;
                }
            }

            return this.Cards.First(x => x.Power == max);
        }
    }
}

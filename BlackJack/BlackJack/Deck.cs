using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlackJack.Enums;

namespace BlackJack
{
    public class Deck
    {
        public Deck()
        {
            this.Cards = this.Generate();
        }

        public List<Card> Cards;

        private List<Card> Generate()
        {
            List<Card> deck = new List<Card>();

            for (int suit = 0; suit < 4; suit++)
            {
                for (int face = 0; face < 13; face++)
                {
                    Card card = new Card(suit, face);
                    deck.Add(card);
                }
            }

            List<Card> shuffledDeck = Shuffle(deck);

            return shuffledDeck;
        }

        private List<Card> Shuffle(List<Card> deck)
        {
            Random random = new Random();
            for (int i = deck.Count() - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                Card temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }
            return deck;
        }

        public void DealCard(IPlayer player, bool isVisible = true)
        {
            Card cardToDeal = Cards[Cards.Count - 1];

            if (!isVisible)
                cardToDeal.Visibility = Visibility.Hidden;

            player.Hand.Add(cardToDeal);

            this.RemoveCard(cardToDeal);
        }

        private void RemoveCard(Card card)
        {
            Cards.Remove(card);
        }

        public void DealStartingHand(IPlayer player)
        {
            if (player.PlayerType.Equals(PlayerType.Computer))
            {
                DealCard(player, false);
            }
            else
            {
                DealCard(player);
            }

            DealCard(player);
        }
    }
}

using static BlackJack.Enums;

namespace BlackJack
{
    public class Card
    {
        public Card(int suit, int face)
        {
            this.Suit = (Suit)suit;
            this.Face = (Face)face;
            this.Visibility = Visibility.Visible;
        }

        public Suit Suit { get; set; }

        public Face Face { get; set; }

        public int Value
        {
            get
            {
                if (Face.Equals(Face.Jack) || Face.Equals(Face.Queen) || Face.Equals(Face.King))
                {
                    return 10;
                }
                else if (Face.Equals(Face.Ace))
                {
                    return 11;
                }
                else
                {
                    return (int)Face + 1;
                }
            }
            set { }
        }

        public Visibility Visibility { get; set; }
    }
}

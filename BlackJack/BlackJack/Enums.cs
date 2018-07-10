namespace BlackJack
{
    public static class Enums
    {
        public enum Suit
        {
            Clubs,
            Diamonds,
            Hearts,
            Spades
        }

        public enum Face
        {
            Ace,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King
        }

        public enum Visibility
        {
            Visible,
            Hidden
        }

        public enum GameState
        {
            NewGame,
            GameInProgress,
            GameOver
        }

        public enum PlayerType
        {
            Human,
            Computer
        }
    }
}

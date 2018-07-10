using static BlackJack.Enums;

namespace BlackJack
{
    public interface ICard
    {
        Suit Suit { get; }

        Value Value { get; }

        Visibility Visibility { get; }
    }
}

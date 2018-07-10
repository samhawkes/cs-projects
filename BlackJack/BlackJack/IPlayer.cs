using System.Collections.Generic;
using static BlackJack.Enums;

namespace BlackJack
{
    public interface IPlayer
    {
        string Name { get; set; }
        int Score { get; set; }
        List<Card> Hand { get; set; }
        PlayerType PlayerType { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlackJack.Enums;


//Gunna leave this here for now until the game is finished. I want this to act as a kind of "wrapper" for what is happening in the game.
//For example, if the state changes to NewGame, then reset scores and reshuffle deck, but don't eliminate the names.
//Can maybe add some stuff in for Game.WhosTurn or something to decide what to call when it's different player's turns.

namespace BlackJack
{
    public class Game
    {
        public Game()
        {
            //_state = GameState.NewGame;
        }

        public GameState State
        {
            get
            {
                return _state;
            }
            set
            {
                if (_state != value && StateChanged != null)
                {
                    GameStateChangedEventArgs args = new GameStateChangedEventArgs();
                    args.CurrentState = _state;
                    args.NewState = value;

                    StateChanged(this, args);
                }
                _state = value;
            }
        }

        public event GameStateChangedDelegate StateChanged;

        protected GameState _state;
    }

    public delegate void GameStateChangedDelegate(object sender, GameStateChangedEventArgs args);

    public class GameStateChangedEventArgs : EventArgs
    {
        public GameState CurrentState { get; set; }
        public GameState NewState { get; set; }
    }
}

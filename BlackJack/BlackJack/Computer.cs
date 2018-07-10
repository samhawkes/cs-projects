using System;
using System.Collections.Generic;
using System.Linq;
using static BlackJack.Enums;

namespace BlackJack
{
    public class Computer : IPlayer
    {
        public Computer()
        {
            this.Initialise();
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        protected string _name;

        public int Score { get; set; }

        public List<Card> Hand { get; set; }

        public PlayerType PlayerType
        {
            get
            {
                return PlayerType.Computer;
            }
        }

        private List<string> ComputerNames = new List<string>
        {
            "Steve",
            "Frank",
            "Bobby",
            "HotDogman",
            "Alfonso",
            "Eric",
            "George",
            "Harold"
        };

        private string SetComputerName()
        {
            Random random = new Random();
            return ComputerNames.ElementAt(random.Next(ComputerNames.Count));
        }

        public void Initialise()
        {
            this.Name = this.SetComputerName();
            this.Score = 0;
            this.Hand = new List<Card>();

            Console.WriteLine($"Your opponent today will be: {this.Name} \n");
        }
    }
}
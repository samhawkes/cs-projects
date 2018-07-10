using System;
using System.Collections.Generic;
using static BlackJack.Enums;

namespace BlackJack
{
    public class Human : IPlayer
    {
        public Human()
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
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Please enter a valid name!");
                }
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
                return PlayerType.Human;
            }
        }


        private void Initialise()
        {
            Console.WriteLine("\nWhat is your name?\n");

            bool goodName = false;

            while (goodName == false)
            {
                try
                {
                    this.Name = Console.ReadLine();
                    goodName = true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message + "\n");
                }
            }

            this.Score = 0;
            this.Hand = new List<Card>();

            Console.WriteLine($"\nHello {this.Name}! \n");
        }
    }
}
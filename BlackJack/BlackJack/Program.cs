using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Player player = new Player();
            Computer computer = new Computer();

            Console.WriteLine("***** Welcome to BlackJack! *****");

            player.Initialise();
            computer.Initialise();

            Deck deck = new Deck();
        }

    }
}

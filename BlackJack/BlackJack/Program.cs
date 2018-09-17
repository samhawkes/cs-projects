using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
    public class Program
    {
        private static Deck deck;
        private static Human human;
        private static Computer computer;

        public static void Main(string[] args)
        {
            Console.WriteLine("***** Welcome to BlackJack! *****");

            human = new Human();
            computer = new Computer();
            deck = new Deck();

            DealStartingHand();

            HumansTurn();

            ComputersTurn();
        }

        private static void DealStartingHand()
        {
            deck.DealStartingHand(human);

            Console.WriteLine($"You have been dealt {human.Hand[0].CardName} and {human.Hand[1].CardName}.\n");

            deck.DealStartingHand(computer);

            Console.WriteLine($"{computer.Name} has been dealt {computer.Hand[0].CardName} and a face down card.\n");
        }

        private static void HumansTurn()
        {
            bool active = true;

            while (active)
            {
                active = false;
            }
        }

        private static void ComputersTurn()
        {

        }
    }
}

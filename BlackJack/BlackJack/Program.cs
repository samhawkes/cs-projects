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

            Initialise(player);
            InitialiseCPU(computer);

            List<Card> deck = GenerateDeck();
        }

        private static void Initialise(Player player)
        {
            Console.WriteLine("***** Welcome to BlackJack! *****");
            Console.WriteLine("\nWhat is your name?\n");

            bool goodName = false;

            while (goodName == false)
            {
                try
                {
                    player.Name = Console.ReadLine();
                    goodName = true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message + "\n");
                }
            }

            Console.WriteLine($"\nYour name is: {player.Name} \n");
        }

        private static void InitialiseCPU(Computer computer)
        {
            computer.Name = computer.SetComputerName();

            Console.WriteLine($"The computers name is: {computer.Name} \n");
        }

        private static List<Card> GenerateDeck()
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

            List<Card> shuffledDeck = ShuffleDeck(deck);

            return shuffledDeck;
        }

        private static List<Card> ShuffleDeck(List<Card> deck)
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlackJack.Enums;

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

            
        }

        private static void Initialise(Player player)
        {
            Console.WriteLine("***** Welcome to BlackJack! *****");
            Console.WriteLine("\nWhat is your name?");

            var goodName = false;

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
    }
}

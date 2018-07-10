using System;

namespace BlackJack
{
    internal class Player
    {
        internal Player()
        {
        }

        internal string Name
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

        public void Initialise()
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

            Console.WriteLine($"\nHello {this.Name}! \n");
        }
    }
}
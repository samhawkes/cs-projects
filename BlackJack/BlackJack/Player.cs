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
    }
}
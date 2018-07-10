﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
    internal class Computer
    {
        internal string Name
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


        internal string SetComputerName()
        {
            Random random = new Random();
            return ComputerNames.ElementAt(random.Next(ComputerNames.Count));
        }
    }
}
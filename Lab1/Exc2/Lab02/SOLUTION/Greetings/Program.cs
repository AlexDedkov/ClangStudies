﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Greetings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName;

            Console.WriteLine("Please enter your name");
            myName = Console.ReadLine();
            Console.WriteLine("Hello {0}", myName);

        }
    }
}

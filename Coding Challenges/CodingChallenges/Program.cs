﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            for(int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    total += i;
                }
            }

            Console.WriteLine($"The total is: {total}");
        }
    }
}

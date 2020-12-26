﻿using System;
using System.Linq;

namespace _3._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"{num[i]} => {Math.Round(num[i],MidpointRounding.AwayFromZero)}");
            }
        }
    }
}

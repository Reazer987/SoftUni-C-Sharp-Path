﻿using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            
           

            while (destination!="End")
            {
                double money = int.Parse(Console.ReadLine());
                double savedMoney = 0;
                while (savedMoney<money)
                {
                    savedMoney += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }
            
        }
    }
}
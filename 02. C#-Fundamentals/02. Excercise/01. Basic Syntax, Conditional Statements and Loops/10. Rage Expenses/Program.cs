﻿using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double hedsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double money = hedsetPrice * (lostGames / 2);
            money += mousePrice * (lostGames / 3);
            money += keyboardPrice * (lostGames / 6);
            money += displayPrice * (lostGames / 12);

            Console.WriteLine($"Rage expenses: { money:f2} lv.");
          
        }
    }
}

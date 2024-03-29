﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            names = names.Where(name => name.Length <=lenght).ToList();

            Action<List<string>> print = names => Console.WriteLine(string.Join(Environment.NewLine, names));
            print(names);
        }
    }
}

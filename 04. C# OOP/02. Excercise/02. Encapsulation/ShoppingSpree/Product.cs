﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _03.ShoppingSpree
{
    public class Product
    {
        private string name;
        private int cost;

        public Product(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name cannot be empty");
                }
                name = value;
            }

        }
        public int Cost
        {
            get
            {
                return cost;
            }


            private set
            {
                if (value < 0)
                {
                    throw new Exception("Money cannot be negative");
                }

                cost = value;
            }
        }


    }
}

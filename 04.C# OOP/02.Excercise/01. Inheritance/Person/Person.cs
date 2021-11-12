﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
   public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            Name = name;

            if (age>0)
            {
                Age = age;
            }        
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name: {Name}, Age: {Age}");
            return sb.ToString();
        }
    }
}

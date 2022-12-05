﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ClassBoxData
{
   public class Box
    {
        private double lenght;
        private double width;
        private double height;
        public Box(double lenght, double width, double height)
        {
            Lenght = lenght;
            Width = width;
            Height = height;
        }

        public double Lenght
        {
            get
            {
                return lenght;
            }
           private set
            {
                if (value<=0)
                {
                    Console.WriteLine("Lenght cannot be zero or negative.");
                }
                lenght = value;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine(("Height cannot be zero or negative."));
                }
                height = value;
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine(("Width cannot be zero or negative."));
                }
                width = value;
            }
        }

      

        public double Volume()
        {
            double result = Lenght * Width * Height;
            return result;
        }
        public double LateralSurfaceArea()
        {
            double result = (2 * (Lenght * Height)) + (2 * (Width * Height));
            return result;
        } 
        public double SurfaceArea()
        {
            double result = 2 * (Lenght * Width) + 2 * (Lenght * Height) + 2 * (Width * Height);
            return result;
        }
    }
}

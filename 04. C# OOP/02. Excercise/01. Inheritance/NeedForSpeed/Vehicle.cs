﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
   public class Vehicle
    {
        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
            FuelConsumption = DefaultFuelConsumption;
        }

        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        public double DefaultFuelConsumption => 1.25;
        public virtual double 	FuelConsumption { get; set; }

        public virtual void Drive(double kilometers)
        {
            Fuel-= FuelConsumption*kilometers;
        }
    }
}

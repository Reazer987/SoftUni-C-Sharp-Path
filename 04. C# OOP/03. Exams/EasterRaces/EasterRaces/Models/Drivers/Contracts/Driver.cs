﻿using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Models.Drivers.Contracts
{
    public  class Driver : IDriver
    {
        private string name;

        public Driver(string name)
        {
            Name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidName, value, 5));
                }
                name = value;
            }
        }

        public ICar Car { get; private set; }

        public int NumberOfWins { get; private set; }

        public bool CanParticipate => false;

        public void AddCar(ICar car)
        {

            if (car == null)
            {
                throw new ArgumentNullException(ExceptionMessages.CarInvalid);
            }
            Car = car;
        }

        public void WinRace()
        {
            NumberOfWins++;
        }
    }
}

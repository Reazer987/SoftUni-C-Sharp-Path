﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
  public  class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string teamName)
        {
            TeamName = teamName;
            firstTeam = new List<Person>();
            reserveTeam = new List<Person>();
        }

        public string TeamName { get; set; }
        public IReadOnlyList<Person> FirstTeam => firstTeam;
        public IReadOnlyList<Person> ReserveTeam => reserveTeam;

        public void AddPlayer(Person person)
        {
            if (person.Age<40)
            {
                firstTeam.Add(person);
            }
            else
            {
                reserveTeam.Add(person);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"First team has {FirstTeam.Count} players.");
            sb.AppendLine($"Reserve team has {ReserveTeam.Count} players.");

            return sb.ToString().TrimEnd();
          
        }


    }
}


using SportsBet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsBet
{
    class Program
    {
        static void Main(string[] args)
        {
            // AAdding all the NFL teams?
    
            List<Team> Teams = new List<Team>();
            // Add more sports

            //Team team = new Team("Tampa Bay Buccaneers");
            Teams.Add(new Team("Tampa Bay Buccaneers"));
            Teams.Add(new Team("Chicago Bears"));
            Teams.Add(new Team("New York Giants"));

            foreach (Team team in Teams)
            {
                Console.WriteLine(team.teamname);
                team.Test();
            }
        }
    }
}

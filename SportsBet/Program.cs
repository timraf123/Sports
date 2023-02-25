
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
            // Adding all the NFL teams?
            Sports sport = new Sports("NFL");
            sport.addTeam(new Team("Tampa Bay Buccaneers"));
            //Team team = new Team("Tampa Bay Buccaneers");
            sport.addTeam(new Team("Chicago Bears"));
            sport.addTeam(new Team("New York Giants"));

     
            foreach (Team team in sport.teams)
            {
                Console.WriteLine(team.teamname);
               team.Test();
            }

            Sports nba = new Sports("NBA");
            nba.addTeam(new Team("Los Angeles Lakers"));
            nba.addTeam(new Team("Chicago Bulls"));
            nba.addTeam(new Team("Miami Heat"));
            foreach (Team team in nba.teams)
            {
                Console.WriteLine(team.teamname);
                //team.Test();
            }

            Team t = nba.getTeam("Los Angeles Lakers");
            t.Test();
        }
    }
}

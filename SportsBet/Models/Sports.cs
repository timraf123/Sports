using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsBet.Models
{
    public class Sports
    {
        public string sportName;
        public Team team;
        public List<Team> teams = new List<Team>();
        public Sports(string sport)
        {
            sportName = sport;
        }

        public void addTeam(Team team)
        {
            teams.Add(team);
            team.load();
        }
        public Team getTeam(string team )
        {
            Team t = teams.SingleOrDefault(x => x.teamname == team);
            return t;
        }
    }
}

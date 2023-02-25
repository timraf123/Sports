
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SportsBet.Models.Player;

namespace SportsBet.Models
{
    //public class DepthChart : IEnumerable
    public class DepthChart 
    {
 

        /// <summary>
        /// o Adds a player to the depth chart at a given position
        /// Adding a player without a position_depth would add them to the end of the depth chart at that position
        /// The added player would get priority.Anyone below that player in the depth chart would get moved down a
        ///position_depth
        /// </summary>
        /// <param name="position"></param>
        /// <param name="player"></param>
        /// <param name="position_depth"></param>
        /// 
          Dictionary<string, Player> depthChart = new Dictionary<string, Player>();
        // addPlayerToDepthChart(“QB”, TomBrady, 0);
        public List<Player> Players; // = new List<Player>();
        public Dictionary<PositionEnum, List<Player>> TeamDepthChart = new Dictionary<PositionEnum, List<Player>>();
     
        public DepthChart()
        {
        
        }

        public void AddPlayer(Player p, List<Player> list)
        {
            list.Add(p);
        }

        //public void LoadCharts()
        //{
        //    AddPlayer(new Player(1, "TOM Brady", Player.PositionEnum.QB, 1), Players);
        //    AddPlayer(new Player(31, "CCC vvvv", Player.PositionEnum.QB,2), Players);
        //    AddPlayer(new Player(51, "BBB NNN", Player.PositionEnum.QB,3), Players);

        //    AddPlayer(new Player(51, "TOM SSSS", Player.PositionEnum.LG,1), Players);
        //    AddPlayer(new Player(51, "BBB XX", Player.PositionEnum.LG,2), Players);
        //    AddPlayer(new Player(51, "BBB DDD", Player.PositionEnum.LG,3), Players);
        //}


        public void LoadDepthChart()
        {

            foreach (PositionEnum i in Enum.GetValues(typeof(PositionEnum)))
            {
                List<Player> players = new List<Player>();
                LoadPlayers(players);
                TeamDepthChart.Add(i, players);
            }
        }
        public void LoadPlayers(List<Player> list)
        {
            //AddPlayer(new Player(1, "TOM Brady", Player.PositionEnum.QB, 1), list);
            //AddPlayer(new Player(31, "CCC vvvv", Player.PositionEnum.QB, 2), list);
            //AddPlayer(new Player(51, "BBB NNN", Player.PositionEnum.QB, 3), list);

            //AddPlayer(new Player(51, "TOM SSSS", Player.PositionEnum.LG, 1), list);
            //AddPlayer(new Player(51, "BBB XX", Player.PositionEnum.LG, 2), list);
            //AddPlayer(new Player(51, "BBB DDD", Player.PositionEnum.LG, 3), list);

            AddPlayer(new Player(1, "TOM Brady"), list);
            AddPlayer(new Player(31, "CCC vvvv"), list);
            AddPlayer(new Player(51, "BBB NNN"), list);
        }
        /// <summary>
        /// o Adds a player to the depth chart at a given position
        // Adding a player without a position_depth would add them to the end of the depth chart at that position
        // The added player would get priority.Anyone below that player in the depth chart would get moved down a position_depth
        /// </summary>
        /// <param name="position"></param>
        /// <param name="player"></param>
        /// <param name="position_depth"></param>
        public int addPlayerToDepthChart(PositionEnum position, Player player, int? position_depth)
        {
            // get players for position

            List<Player> players = TeamDepthChart[position];
            if (position_depth == null || position_depth == 0)
            {
                players.Add(player);
            }
            else
            {
                players.Insert((int)position_depth, player);
           
            }
            return getPlayerDepth(players, player);
        }




        public int getPlayerDepth(List<Player> players, Player player)
        {
            return players.FindIndex(a => a.number == player.number);
     
        }
        /// <summary>
        /// o Print out the full depth chart with every position on the team and every player within the Depth Chart
        /// </summary>
        public void getFullDepthChart()
        {

            Console.WriteLine("DEPTH CHART ");

            for (int index = 0; index < TeamDepthChart.Count; index++)
            {

                KeyValuePair<PositionEnum, List<Player>> chart = TeamDepthChart.ElementAt(index);
                List<Player> players = chart.Value;
              
                foreach (Player p in players)
                {
                    Console.WriteLine($"{chart.Key}: {p.name}");

                }
            }
        }

        /// <summary>
        /// o Print out the full depth chart with every position on the team and every player within the Depth Chart
        /// </summary>
        public void getDepthChartForPosition(PositionEnum position)
        {

            Console.WriteLine("DEPTH CHART For Position " + position);
            List<Player> players = TeamDepthChart[position];
            foreach (Player p in players)
            {
                Console.WriteLine(p.name);
            }
        }
        /// <summary>
        ///  Removes a player from the depth chart for a given position and returns that player
        /// An empty list should be returned if that player is not listed in the depth chart at that position
        /// </summary>
        /// <param name="position"></param>
        /// <param name="player"></param>
        public List<Player> removePlayerFromDepthChart(PositionEnum position, Player player)
        {
            List<Player> players = TeamDepthChart[position];
            List<Player> returnPlayers = new List<Player>();
            Player item = players.SingleOrDefault(x => x.number== player.number);
            if (item != null)
            {
                returnPlayers.Add(item);
                bool b = players.Remove(item);
            }

            return returnPlayers;
        }


        /// <summary>
        /// o For a given player and position, we want to see all players that are “Backups”, those with a lower position_depth
        /// o An empty list should be returned if the given player has no Backups
        /// o An empty list should be returned if the given player is not listed in the depth chart at that position
        /// </summary>
        /// <param name="position"></param>
        /// <param name="player"></param>
        public List<Player>  getBackups(PositionEnum position, Player player)
        {
            List<Player> players = TeamDepthChart[position];
            List<Player> pBackups = new List<Player>();
  

            foreach (Player p in players)
            {
                if ( p.name != player.name)
                {
                    pBackups.Add(p);
                }
            }

            Console.WriteLine("BACKUPS For " + player.name);
            foreach (Player p in pBackups)
            {
                if (p.name != player.name)
                {
                    Console.WriteLine(p.name + " " + p.number + " " + p.position);
 
                } 
            }

            return pBackups;
        }
 
    }
  
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsBet.Models
{
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
        public void addPlayerToDepthChart(string position, Player player, int position_depth)
        {
        }

        /// <summary>
        ///  Removes a player from the depth chart for a given position and returns that player
        /// An empty list should be returned if that player is not listed in the depth chart at that position
        /// </summary>
        /// <param name="position"></param>
        /// <param name="player"></param>
        public void removePlayerFromDepthChart(string position, Player player)
        {
        }

        /// <summary>
        /// o For a given player and position, we want to see all players that are “Backups”, those with a lower position_depth
        /// o An empty list should be returned if the given player has no Backups
        /// o An empty list should be returned if the given player is not listed in the depth chart at that position
        /// </summary>
        /// <param name="position"></param>
        /// <param name="player"></param>
        public void getBackups(string position, Player player)
        {
        }

        /// <summary>
        /// o Print out the full depth chart with every position on the team and every player within the Depth Chart
        /// </summary>
        public void getFullDepthChart()
        {
        }


    }
}

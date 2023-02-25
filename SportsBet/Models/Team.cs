using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SportsBet.Constants;

namespace SportsBet.Models
{
    public class Team
    {
        public string teamname;
        public DepthChart depthChart = new DepthChart();
        public Team(string name)
        {
            teamname = name;
        }
        public void addPlayerToDepthChart(string position, Player player, int position_depth)
        {
        }
        public void Test()
        {
            Console.WriteLine(teamname);
            depthChart.LoadDepthChart();
            depthChart.getFullDepthChart();
          //  depthChart.getlDepthChartForPosition(Player.PositionEnum.LG);
            Player pnewPlayer = new Player(52, "Dan Marino");
            int posn = depthChart.addPlayerToDepthChart(Player.PositionEnum.LG,  pnewPlayer, 2);
            depthChart.getDepthChartForPosition(Player.PositionEnum.LG);
           // depthChart.getFullDepthChart();
            Player pRemove = new Player(52, "Dan Marino");
            List<Player> backups =  depthChart.getBackups(Player.PositionEnum.LG, pRemove);
            List<Player> players = depthChart.removePlayerFromDepthChart(Player.PositionEnum.LG, pRemove);
            Player playerToRemove = new Player(33, "Dan Smith");
            players = depthChart.removePlayerFromDepthChart(Player.PositionEnum.LG, playerToRemove);
            depthChart.getDepthChartForPosition(Player.PositionEnum.LG);
      
            Console.ReadLine();
        }

    }

}
   
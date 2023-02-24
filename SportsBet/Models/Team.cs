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
            //  Player pnewPlayer = new Player(51, "Dan Marino", Player.PositionEnum.LG, 3);
            depthChart.getlDepthChartForPosition(Player.PositionEnum.LG);
            Player pnewPlayer = new Player(51, "Dan Marino");
            //Console.ReadLine();
            depthChart.addPlayerToDepthChart(Player.PositionEnum.LG,  pnewPlayer, 2);
            depthChart.getlDepthChartForPosition(Player.PositionEnum.LG);
           // depthChart.getFullDepthChart();
            Player pRemove = new Player(51, "Dan Marino");
            depthChart.removePlayerFromDepthChart(Player.PositionEnum.LG, pRemove);

            depthChart.getBackups(Player.PositionEnum.LG, pRemove);
            depthChart.getlDepthChartForPosition(Player.PositionEnum.LG);
           // depthChart.getFullDepthChart();
            Console.ReadLine();
        }

    }

}

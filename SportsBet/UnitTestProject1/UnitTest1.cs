using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using SportsBet.Models;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Team team = new Team("Tampa Bay Buccaneers");

            team.depthChart.LoadDepthChart();
            Player pnewPlayer = new Player(52, "Dan Marino");
            int depth = 2;
            int playerDepth = team.depthChart.addPlayerToDepthChart(Player.PositionEnum.LG, pnewPlayer, depth);
            Assert.AreEqual(depth, playerDepth);
            List<Player> players = team.depthChart.removePlayerFromDepthChart(Player.PositionEnum.LG, pnewPlayer);
            Assert.AreEqual(players.Count, 1);
            Player playerToRemove = new Player(33, "Dan Smith");
            players = team.depthChart.removePlayerFromDepthChart(Player.PositionEnum.LG, playerToRemove);
            Assert.AreEqual(players.Count, 0);

        }
        [TestMethod]
        public void TestMethod2() 
        {
            Sports nba = new Sports("NBA");
            nba.addTeam(new Team("Los Angeles"));
             Team t = nba.getTeam("Los Angeles");
            Assert.IsNotNull(t.depthChart);
            t.depthChart.getFullDepthChart();
            Player playerToRemove = new Player(33, "Dan Smith");
            List<Player> players =  t.depthChart.removePlayerFromDepthChart(Player.PositionEnum.LG, playerToRemove);
            Assert.AreEqual(players.Count, 0);

            Player pnewPlayer = new Player(52, "Dan Marino");
            int depth = 2;
            int playerDepth = t.depthChart.addPlayerToDepthChart(Player.PositionEnum.LG, pnewPlayer, depth);
            Assert.AreEqual(depth, playerDepth);

            System.Diagnostics.Trace.WriteLine("TESTING" + t.teamname);
        }

    }
}

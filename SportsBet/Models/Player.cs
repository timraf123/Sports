using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsBet.Models
{
    public class Player
    {
        public int number;
        public string name;
        public PositionEnum position;
        public int depth;

        // addPlayerToDepthChart(“QB”, TomBrady, 0);
        //addPlayerToDepthChart (position, player, position_depth)
       ///public enum PositionEnum { QB, HB, WR, TE, LT, LG, C, RG, RT, DE, DT, OLB, MLB, CB, FS, SS }
        public enum PositionEnum { LWR, RWR, SWR, LT, LG, C, RG, RT, TE, QB, RB, DE, NT, DT, LO, LI, RI, RO, LC, SS, FS, RC, NB, PT, PK, LS, H, KO, PR, KR }

        public string Name { get; set; }
        public int Depth { get; set; }
        //public TypeEnum Type { get; set; }
        public Player(int n, string s)
        {
            number = n;
            name = s;
        }

        public Player(string s)
        {

            name = s;
        }
        public Player(int n, string s, PositionEnum p, int d)
        {
            number = n;
            name = s;
            position = p;
            depth = d;
        }







    }
}
 
        
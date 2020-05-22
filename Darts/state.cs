using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class State
    {
        public Point dart1P1Position, dart2P1Position, dart3P1Position, dart1P2Position, dart2P2Position, dart3P2Position = new Point(0,0);
        public int scoreP1, scoreP2 = 0;
        public String player1, player2;
    }
}

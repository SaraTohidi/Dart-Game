using Darts.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    class BadComputerPlayer : IComputer
    {
        Random rand = new Random();
        public Point CalculateNewPoint(Point position)
        {
            int offSet = rand.Next(-35, 35);
            return new Point(position.X + offSet, position.Y + offSet);

        }
    }
}

﻿using Darts.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    class GoodComputerPlayer : IComputer
    {
        Random rand = new Random();

        public Point CalculateNewPoint(Point position)
        {
            int offSet = rand.Next(-5, 5);
            return new Point(position.X + offSet, position.Y  + offSet);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts.Interfaces
{
    public interface IComputer
    {
        Point CalculateNewPoint(Point position);
    }
}

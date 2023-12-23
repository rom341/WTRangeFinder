using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarThunderMinimapRangefinder
{
    public class PointWorker
    {
        static public double GetDistance(Point p1, Point p2)
        {
            double result = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2) * 1.0);
            return result;
        }
        static public bool IsPointValid(Point point)
        {
            if (point.X == -1 && point.Y == -1)
            {
                return false;
            }
            return true;
        }
    }
}

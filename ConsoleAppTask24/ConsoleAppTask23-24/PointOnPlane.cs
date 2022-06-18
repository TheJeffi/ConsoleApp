using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask22._2
{
    internal class PointOnPlane
    {
        private double _x;
        private double _y;

        public double X { get { return _x; } set { _x = value; } }
        public double Y { get { return _y; } set { _y = value; } }
        public double GetDistanceTo(PointOnPlane point)
        {
            return Math.Round(Math.Sqrt(Math.Pow((point.X - _x), 2) + Math.Pow((point.Y - _y), 2)),2);
        }

        public PointOnPlane()
        {
            _x = 0;
            _y = 0;
        }
    }
}

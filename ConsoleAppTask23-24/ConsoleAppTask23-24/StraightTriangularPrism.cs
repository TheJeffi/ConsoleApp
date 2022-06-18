using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask22._2
{
    internal class StraightTriangularPrism : Cylinder
    {
        protected PointOnPlane pointThree;
        public PointOnPlane PointThree { get { return pointThree; } set { pointThree = value; } }

        public override double GetFootSquare()
        {
            double p = GetFootPerimeter() / 2;
            return Math.Round(Math.Sqrt(p * (p - pointOne.GetDistanceTo(PointTwo)) * (p - pointTwo.GetDistanceTo(PointThree)) * (p - pointThree.GetDistanceTo(pointTwo))), 2);
        }

        public override double GetFootPerimeter()
        {
            return Math.Round(pointOne.GetDistanceTo(PointTwo) + pointTwo.GetDistanceTo(PointThree) + pointThree.GetDistanceTo(pointTwo), 2);
        }
        public  StraightTriangularPrism():base()
        {
            pointThree = new PointOnPlane();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask22._2
{
    internal class StraightPrismWithQuadrangularBase : StraightTriangularPrism
    {
        protected PointOnPlane pointFour;
        public PointOnPlane PointFour { get { return pointFour; } set { pointFour = value; } }

        public bool IsCube ()
        {
            double side1 = pointOne.GetDistanceTo(pointTwo);
            double side2 = pointTwo.GetDistanceTo(pointThree);
            double side3 = pointThree.GetDistanceTo(pointFour);
            double side4 = pointFour.GetDistanceTo(pointOne);
            return (side2 == side1 && side3 == side1 && side4 == side1 && height == side1);
        }
        public bool IsParallelepiped ()
        {

            CalculateAllSide(out double side1,out double side2,out double side3,out double side4);

            bool checkParallelY = Math.Abs(pointOne.Y - pointFour.Y) == Math.Abs(pointTwo.Y - pointThree.Y);

            bool checkParallelX = Math.Abs(pointTwo.X - PointOne.X) == Math.Abs(PointThree.X - PointFour.X);

            return (side1 == side3 && checkParallelY) && (side2 == side4 && checkParallelX);
        }

        public bool IsRectangularParallelepiped ()
        {
            return (IsParallelepiped() && pointOne.X == pointFour.X && pointTwo.X == pointThree.X && pointOne.Y == pointTwo.Y && pointThree.Y == pointFour.Y);
        }

        public StraightPrismWithQuadrangularBase():base()
        {
            pointFour = new PointOnPlane();
        }

        public override double GetFootPerimeter()
        {
            CalculateAllSide(out double side1, out double side2, out double side3, out double side4);
            return Math.Round((side1 + side2 + side3 + side4),2);
        }
        public override double GetFootSquare()
        {
            CalculateAllSide(out double side1, out double side2, out double side3, out double side4);
            return Math.Round((side1 * side2 * side3 * side4),2);
        }

        private void CalculateAllSide(out double side1, out double side2, out double side3, out double side4)
        {
            side1 = pointOne.GetDistanceTo(pointTwo);
            side2 = pointTwo.GetDistanceTo(pointThree);
            side3 = pointThree.GetDistanceTo(pointFour);
            side4 = pointFour.GetDistanceTo(pointOne);
        }
    }
}

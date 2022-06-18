using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask22._2
{
    internal class Cylinder
    {
        protected PointOnPlane pointOne;
        protected PointOnPlane pointTwo;
        public PointOnPlane PointOne { get { return pointOne; } set { pointOne = value; } }
        public PointOnPlane PointTwo { get { return pointTwo; } set { pointTwo = value; } }
        protected double height;

        public double Height { get { return height; } set { height = value; }  }
        public virtual double GetFootSquare()
        {
            return Math.Round(Math.PI * Math.Pow(pointOne.GetDistanceTo(pointTwo),2),2);
        }

        public virtual double GetFootPerimeter()
        {
            return Math.Round(2 * Math.PI * pointOne.GetDistanceTo(pointTwo),2);
        }

        public double GetVolume()
        {
            return Math.Round(GetFootSquare() * height,2);
        }

        public double GetVolumeSideSurface()
        {
            return Math.Round(GetFootPerimeter() * height,2);
        }

        public Cylinder ()
        {
            pointOne = new PointOnPlane();
            pointTwo = new PointOnPlane();
        }
    }
}

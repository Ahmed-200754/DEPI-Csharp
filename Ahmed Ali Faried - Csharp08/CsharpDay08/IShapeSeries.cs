using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay08
{
    #region Shape Series
    internal interface IShapeSeries
    {
        int CurrentShapeArea { get; set; }
        void GetNextArea();
        void ResetSeries();
    }

    public class SquareSeries : IShapeSeries
    {
        private int side = 0;

        public int CurrentShapeArea { get; set; }

        public void GetNextArea()
        {
            side++;
            CurrentShapeArea = side * side;
        }

        public void ResetSeries()
        {
            side = 0;
            CurrentShapeArea = 0;
        }
    }

    public class CircleSeries : IShapeSeries
    {
        private int radius = 0;

        public int CurrentShapeArea { get; set; }

        public void GetNextArea()
        {
            radius++;
            CurrentShapeArea = (int)(Math.PI * radius * radius);
        }

        public void ResetSeries()
        {
            radius = 0;
            CurrentShapeArea = 0;
        }
    }
    #endregion

    #region Sorting for Shapes

    public class Shape01 : IComparable<Shape01>
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public int CompareTo(Shape01 other)
        {
            return Area.CompareTo(other.Area);
        }
    }
    #endregion

    #region Extend the Shape Hierarchy
    public abstract class GeometricShape
    {
        public double Dimension1 { get; set; }
        public double Dimension2 { get; set; }

        public abstract double CalculateArea();
        public abstract double Perimeter { get; }
    }

    public class Triangle : GeometricShape
    {
        public override double CalculateArea()
        {
            return 0.5 * Dimension1 * Dimension2;
        }
        public override double Perimeter
        {
            get { return Dimension1 + Dimension2 + Math.Sqrt(Dimension1* Dimension1 + Dimension2* Dimension2);}

        }
    }

    public class Rectangle01 : GeometricShape
    {
        public override double CalculateArea()
        {
            return Dimension1 * Dimension2;
        }

        public override double Perimeter
        {
            get { return 2 * (Dimension1 + Dimension2); }
        }
    }

    #endregion
}

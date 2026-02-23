using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay08
{
    #region Problem02
    internal abstract class Shape
    {
        public abstract double GetArea();

        public void Display()
        {
            Console.WriteLine($"The area of the shape is: {GetArea()}");
        }
    }

    class Circle : Shape
    {
        private double radius;
        public Circle(double _radius)
        {
            radius = _radius;
        }
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double _width, double _height)
        {
            width = _width;
            height = _height;
        }
        public override double GetArea()
        {
            return width * height;
        }
    }

    public interface IShape
    {
        double GetArea();
        void Display();
    }

    public class InterfaceRectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double GetArea()
        {
            return Width * Height;
        }
        public void Display()
        {
            Console.WriteLine($"Rectangle Area: {GetArea()}");
        }
    }

    public class InterfaceCircle : IShape
    {
        public double Radius { get; set; }
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
        public void Display()
        {
            Console.WriteLine($"Circle Area: {GetArea()}");
        }
    } 
    #endregion
}

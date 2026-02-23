using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay08
{
    internal class ShapeFactory
    {
        public static GeometricShape CreateShape(string shapeType, double dim1, double dim2)
        {
            switch (shapeType.ToLower())
            {
                case "rectangle":
                    return new Rectangle01 { Dimension1 = dim1, Dimension2 = dim2 };

                case "triangle":
                    return new Triangle { Dimension1 = dim1, Dimension2 = dim2 };

                default:
                    throw new ArgumentException("Invalid shape type");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CsharpDay06
{
    internal struct Point
    {
        private int x;
        private int y;

        #region Problem01
        //public Point(int _x, int _y)
        //{
        //    x = _x;
        //    y = _y;
        //}
        //public Point()
        //{
        //    x = 0;
        //    y = 0;
        //}
        //public override string ToString()
        //{
        //    return $"({x},{y})";
        //} 
        #endregion

        #region Problem04
        public Point(int _x)
        {
            x = _x;
            y = 0;
        }

        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public void Print()
        {
            Console.WriteLine($"({x},{y})");
        }
        #endregion

        #region Problem05
        override public string ToString()
        {
            return $"(this is Point X: {x} this is Point Y: {y})";
        }
        #endregion

        #region Problem06
        public void modifypoint( int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay07
{
    internal class Parent
    {
        #region Problem03
        public int X { get; set; }
        public int Y { get; set; }

        public Parent(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }
        #endregion

        #region Problem04
        public virtual int Product()
        {
            return X * Y;
        }
        #endregion

        #region Problem05
        public override string ToString()
        {
            return $"({X} , {Y})";
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay07
{
    internal class Child : Parent
    {
        #region Problem03
        public int Z { get; set; }
        public Child(int _X, int _Y, int _Z) : base(_X, _Y)
        {
            Z = _Z;
        }
        #endregion

        #region Problem04
        //public new int Product()
        //{
        //    return X * Y * Z;
        //}

        public override int Product()
        {
            return X * Y * Z;
        }
        #endregion

        #region Problem05
        override public string ToString()
        {
            return $"({X} , {Y} , {Z})";
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay07
{
    
    internal class Calculator
    {
        #region Problem02
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Sum(double a, double b)
        {
            return a + b;
        } 
        #endregion
    } 
    
}

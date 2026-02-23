using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay08
{
    #region Problem07
    internal interface ILogger
    {
        public void log()
        {
            Console.WriteLine("customer logged in successfully ");
        }
    }

    internal class ConsoleLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("customer logged in successfully in class ");
        }
    } 
    #endregion
}

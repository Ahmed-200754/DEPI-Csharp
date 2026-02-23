using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay08
{
    #region Problem05
    internal interface IWalkable
    {
        public void Walk();
    }
    class Robot : IWalkable
    {
        public void Walk()
        {
            Console.WriteLine("Robot walking normally with wheels.");
        }
        void IWalkable.Walk()
        {
            Console.WriteLine("Robot walking like a human (interface behavior).");
        }
    }

    #endregion
}

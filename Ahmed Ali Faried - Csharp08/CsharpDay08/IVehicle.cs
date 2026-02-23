using CsharpDay08;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay08
{
    #region Problem01
    internal interface IVehicle
    {
        public void startengine();
        public void stopengine();
    }

    class Car : IVehicle
    {
        public void startengine()
        {
            Console.WriteLine("Car engine started");
        }
        public void stopengine()
        {
            Console.WriteLine("Car engine stopped");
        }
    }

    class Bike : IVehicle
    {
        public void startengine()
        {
            Console.WriteLine("Bike engine started");
        }
        public void stopengine()
        {
            Console.WriteLine("Bike engine stopped");
        }
    } 
    #endregion



}
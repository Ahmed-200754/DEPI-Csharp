using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay07
{
    internal class Car
    {
        #region Problem01
        private int Id;
        private string Brand;
        private double Price;

        public Car()
        {

        }
        public Car(int _Id)
        {
            Id = _Id;
        }
        public Car(int _Id, string _Brand)
        {
            Id = _Id;
            Brand = _Brand;
        }
        public Car(int _Id, string _Brand, double _Price)
        {
            Id = _Id;
            Brand = _Brand;
            Price = _Price;
        } 
        #endregion
    }
}

using System;
using System.Security.Cryptography;

namespace CsharpDay07
{
    internal class Program
    {
        static void Main()
        {
            #region Problem01
            Car car01 = new Car();
            Car car02 = new Car(2001);
            Car car03 = new Car(2015, "BMW");
            Car car04 = new Car(2023, "Volkswagen", 4112980.45);
            #endregion

            #region Problem02
            Calculator C01 = new Calculator();
            Calculator C02 = new Calculator();
            Calculator C03 = new Calculator();

            Console.WriteLine(C01.Sum(5,12));
            Console.WriteLine(C02.Sum(5, 12, 15));
            Console.WriteLine(C03.Sum(5.5, 12.3));
            #endregion

            #region Problem03
            Child child01 = new Child(2, 4, 6);
            #endregion

            #region Problem04
            Parent Ch01 = new Child(1, 2, 3);
            Parent Ch02 = new Child(1, 2, 3);
            Console.WriteLine(Ch01.Product());//This will use the product method with new keyword so it will print 2
            Console.WriteLine(Ch02.Product());//This will use the product method with the override keyword so it will print 6
            #endregion

            #region Problem05
            Parent P01 = new Parent(1, 2);
            Child Schild01 = new Child(1, 2, 3);
            Console.WriteLine(P01.ToString());
            Console.WriteLine(Schild01.ToString());
            #endregion
        }
    }
}

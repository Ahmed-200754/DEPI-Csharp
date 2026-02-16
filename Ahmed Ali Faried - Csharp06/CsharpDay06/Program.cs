using System;

namespace CsharpDay06
{
    internal class Program
    {
        static void Main()
        {

            #region Problem02
            //TypeA a = new TypeA();
            //a.print();
            //Console.WriteLine("This is G:", a.G);
            //Console.WriteLine("This is H:", a.H); 
            #endregion

            #region Problem03
            //Employee emp1 = new Employee();

            //emp1.Name = "Ahmed Ali";
            #endregion

            #region Problem04
            Point P1 = new Point(5, 6);
            Point P2 = new Point(10);
            P1.Print();
            P2.Print();
            #endregion

            #region Problem05
            Console.WriteLine(P1.ToString());
            Console.WriteLine(P2.ToString());
            #endregion

            #region Problem06
            Employee refemp = new Employee(111,"Ahmed Ali",15000);
            Console.WriteLine($"original employee name is {refemp.Name} ,and his ID is {refemp.EmpId} ,the salary is {refemp.Salary}");
            refemp.modifyemployee(123,"Ahmed Torky",12000);
            Console.WriteLine($"after modifications employee name is {refemp.Name} ,and his ID is {refemp.EmpId} ,the salary is {refemp.Salary}");

            Point valueP = new Point(20, 10);
            Console.WriteLine($"original point is {valueP.ToString()}");
            valueP.modifypoint(100 , 200);
            Console.WriteLine($"after modifications point is {valueP.ToString()}");
            #endregion
        }
    }
}

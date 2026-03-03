using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpDay10
{
    internal class Program
    {
        public class Employee : IComparable<Employee>
        {
            public string Name { get; set; }
            public double Salary { get; set; }

            public Employee(string name, double salary)
            {
                Name = name;
                Salary = salary;
            }

            public int CompareTo(Employee other)
            {
                return Salary.CompareTo(other.Salary);
            }
        }

        #region Problem01
        public class SortingAlgorithm<T> where T : IComparable<T>
        {
            public void Sort(T[] array)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j].CompareTo(array[j + 1]) > 0)
                        {
                            Swap(ref array[j], ref array[j + 1]);
                        }
                    }
                }
            }

            private void Swap(ref T a, ref T b)
            {
                T temp = a;
                a = b;
                b = temp;
            }
        }
        #endregion

        #region Problem02
        public class SortingTwo<T>
        {
            public static void Sort(T[] array, Func<T, T, int> comparer)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (comparer(array[j], array[j + 1]) > 0)
                        {
                            T temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }
        }
        #endregion

        #region Problem04
        public class Manager : Employee, IComparable<Manager>
        {
            public Manager(string name, double salary) : base(name, salary) { }

            public int CompareTo(Manager other)
            {
                return Salary.CompareTo(other.Salary);
            }
        }
        #endregion

        #region Problem07
        public static class Utils
        {
            public static void Swap<T>(ref T a, ref T b)
            {
                T temp = a;
                a = b;
                b = temp;
            }
        }
        #endregion

        #region Problem09
        public static T GetDefault<T>()
        {
            return default(T);
        }
        #endregion

        #region Problem10
        public class EmployeeCloneable : Employee, ICloneable
        {
            public EmployeeCloneable(string name, double salary) : base(name, salary) { }
            public object Clone() => new EmployeeCloneable(Name, Salary);
        }

        public class SortingAlgorithmCloneable<T> where T : ICloneable, IComparable<T>
        {
            public T[] SortClone(T[] array)
            {
                T[] cloned = array.Select(x => (T)x.Clone()).ToArray();
                // sort cloned
                Array.Sort(cloned);
                return cloned;
            }
        }
        #endregion

        static void Main()
        {
            #region Problem01
            Employee[] employees1 = {
                new Employee("John", 50000),
                new Employee("Jane", 60000),
                new Employee("Bob", 45000)
            };
            SortingAlgorithm<Employee> sorter1 = new SortingAlgorithm<Employee>();
            sorter1.Sort(employees1);
            Console.WriteLine("Employees sorted by salary:");
            foreach (var emp in employees1)
                Console.WriteLine($"{emp.Name}: {emp.Salary}");
            #endregion

            #region Problem02
            int[] integers = { 5, 2, 8, 1, 9 };
            SortingTwo<int>.Sort(integers, (a, b) => b.CompareTo(a)); // descending
            Console.WriteLine("\nIntegers sorted descending:");
            Console.WriteLine(string.Join(", ", integers));
            #endregion

            #region Problem03
            string[] strings = { "apple", "pie", "banana", "a" };
            SortingTwo<string>.Sort(strings, (s1, s2) => s1.Length.CompareTo(s2.Length));
            Console.WriteLine("\nStrings sorted by length:");
            Console.WriteLine(string.Join(", ", strings));
            #endregion

            #region Problem04
            Manager[] managers = {
                new Manager("Alice", 70000),
                new Manager("Charlie", 65000),
                new Manager("Diana", 75000)
            };
            SortingAlgorithm<Manager> managerSorter = new SortingAlgorithm<Manager>();
            managerSorter.Sort(managers);
            Console.WriteLine("\nManagers sorted by salary:");
            foreach (var mgr in managers)
                Console.WriteLine($"{mgr.Name}: {mgr.Salary}");
            #endregion

            #region Problem05
            Func<Employee, Employee, bool> nameLenComp = (e1, e2) => e1.Name.Length < e2.Name.Length;
            Employee[] employees5 = {
                new Employee("John", 50000),
                new Employee("Alexander", 60000),
                new Employee("Bo", 45000)
            };
            SortingTwo<Employee>.Sort(employees5, (e1, e2) => e1.Name.Length.CompareTo(e2.Name.Length));
            Console.WriteLine("\nEmployees sorted by name length:");
            foreach (var emp in employees5)
                Console.WriteLine($"{emp.Name}: {emp.Name.Length}");
            #endregion

            #region Problem06
            int[] integers6 = { 5, 2, 8, 1, 9 };

            SortingTwo<int>.Sort(integers6, delegate (int a, int b) { return a.CompareTo(b); });
            Console.WriteLine("\nSorted with anonymous function:");
            Console.WriteLine(string.Join(", ", integers6));

            int[] integers6b = { 5, 2, 8, 1, 9 };
            SortingTwo<int>.Sort(integers6b, (a, b) => a.CompareTo(b));
            Console.WriteLine("Sorted with lambda:");
            Console.WriteLine(string.Join(", ", integers6b));
            #endregion

            #region Problem07
            int x = 10, y = 20;
            Console.WriteLine($"\nBefore swap: x={x}, y={y}");
            Utils.Swap(ref x, ref y);
            Console.WriteLine($"After swap: x={x}, y={y}");
            #endregion

            #region Problem08
            Employee[] employees8 = {
                new Employee("John", 50000),
                new Employee("Alice", 50000),
                new Employee("Bob", 45000)
            };
            SortingTwo<Employee>.Sort(employees8, (e1, e2) =>
            {
                int salCmp = e1.Salary.CompareTo(e2.Salary);
                return salCmp != 0 ? salCmp : string.Compare(e1.Name, e2.Name);
            });
            Console.WriteLine("\nEmployees sorted by salary, then name:");
            foreach (var emp in employees8)
                Console.WriteLine($"{emp.Name}: {emp.Salary}");
            #endregion

            #region Problem09
            int intDefault = GetDefault<int>();
            string strDefault = GetDefault<string>();
            Console.WriteLine($"\nDefault values: int={intDefault}, string={(strDefault == null ? "null" : strDefault)}");
            #endregion

            #region Problem10
            EmployeeCloneable[] empClone = { new EmployeeCloneable("A", 5000), new EmployeeCloneable("B", 3000) };
            SortingAlgorithmCloneable<EmployeeCloneable> sorter10 = new SortingAlgorithmCloneable<EmployeeCloneable>();
            var sortedClone = sorter10.SortClone(empClone);
            Console.WriteLine("\nCloned and sorted employees:");
            foreach (var emp in sortedClone)
                Console.WriteLine($"{emp.Name}: {emp.Salary}");
            #endregion

            #region Problem11
            Func<string, string> transformer = null;
            List<string> strs11 = new List<string> { "hello", "world" };

            transformer = s => s.ToUpper();
            var upper = strs11.Select(transformer).ToList();
            Console.WriteLine("\nUppercase:");
            Console.WriteLine(string.Join(", ", upper));

            transformer = s => new string(s.Reverse().ToArray());
            var reversed = strs11.Select(transformer).ToList();
            Console.WriteLine("Reversed:");
            Console.WriteLine(string.Join(", ", reversed));
            #endregion

            #region Problem12
            Func<int, int, int> op12 = null;
            int x12 = 10, y12 = 5;

            op12 = (a, b) => a + b;
            Console.WriteLine($"\nAdd: {op12(x12, y12)}");
            
            op12 = (a, b) => a - b;
            Console.WriteLine($"Subtract: {op12(x12, y12)}");
            
            op12 = (a, b) => a * b;
            Console.WriteLine($"Multiply: {op12(x12, y12)}");
            
            op12 = (a, b) => a / b;
            Console.WriteLine($"Divide: {op12(x12, y12)}");
            #endregion

            #region Problem13
            Func<int, string> intToStr = i => i.ToString();
            List<int> ints13 = new List<int> { 1, 2, 3 };
            var strList = ints13.Select(intToStr).ToList();
            Console.WriteLine("\nInt to string:");
            Console.WriteLine(string.Join(", ", strList));
            #endregion

            #region Problem14
            Func<int, int> square = i => i * i;
            List<int> ints14 = new List<int> { 1, 2, 3, 4 };
            var squares = ints14.Select(square).ToList();
            Console.WriteLine("\nSquares:");
            Console.WriteLine(string.Join(", ", squares));
            #endregion

            #region Problem15
            Action<string> printer = s => Console.WriteLine(s);
            List<string> strs15 = new List<string> { "a", "b", "c" };
            Console.WriteLine("\nPrinting with Action:");
            foreach (var s in strs15) printer(s);
            #endregion

            #region Problem16
            Predicate<int> isEven = i => i % 2 == 0;
            List<int> ints16 = new List<int> { 1, 2, 3, 4, 5, 6 };
            var evens = ints16.FindAll(isEven);
            Console.WriteLine("\nEven numbers:");
            Console.WriteLine(string.Join(", ", evens));
            #endregion

            #region Problem17
            List<string> strs17 = new List<string> { "apple", "banana", "art", "apricot" };
            var startA = strs17.FindAll(delegate (string s) { return s.StartsWith("a"); });
            Console.WriteLine("\nStrings starting with 'a':");
            Console.WriteLine(string.Join(", ", startA));
            #endregion

            #region Problem18
            Func<int, int, int> mathOp18 = delegate (int a, int b) { return a + b; };
            Console.WriteLine($"\nProblem 18 - Math operation (5 + 3): {mathOp18(5, 3)}");
            #endregion

            #region Problem19
            List<string> strs19 = new List<string> { "hi", "hello", "world", "example" };
            var longE = strs19.Where(s => s.Length > 3 || s.Contains('e')).ToList();
            Console.WriteLine("\nStrings length > 3 or contains 'e':");
            Console.WriteLine(string.Join(", ", longE));
            #endregion

            #region Problem20
            Func<double, double, double> div = (a, b) => a / b;
            Func<double, double, double> pow = (a, b) => Math.Pow(a, b);
            Console.WriteLine($"\nDivision (10/3): {div(10, 3)}");
            Console.WriteLine($"Power (2^3): {pow(2, 3)}"); 
            #endregion
        }
    }
}

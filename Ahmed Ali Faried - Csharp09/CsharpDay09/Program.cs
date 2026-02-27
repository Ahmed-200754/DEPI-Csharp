using System;
using System.Collections.Generic;

namespace CsharpDay09
{
    #region Problem01
        enum Weekdays
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday
        }
        #endregion

    #region Problem02
        enum Grade : short
        {
            A,
            B,
            C,
            D,
            E,
            F = 1
        }
        #endregion

    #region Problem03
    enum Gender
    {
        male,
        female
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender gender { get; set; }

        public string Department { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Age} - {gender} - {Department}";
        }
    }
    #endregion

    #region Problem04
    class Parent
    {
        public virtual decimal Salary { get; set; } = 5000;
    }
    class Child : Parent
    {
        public sealed override decimal Salary
        {
            get { return 7000; }
        }
        public void DisplaySalary()
        {
            Console.WriteLine($"Salary = {Salary}");
        }
    }
    #endregion

    #region Problem05
    static class Utility
    {
        public static double RectanglePerimeter(double l, double w)
            => 2 * (l + w);

        #region Problem08
        public static double CelsiusToF(double c)
            => (c * 9 / 5) + 32; 
        #endregion

        public static double FahrenheitToC(double f)
            => (f - 32) * 5 / 9;
    }
    #endregion

    #region Problem06
    class ComplexNumber
    {
        private double Real;
        private double Imag;

        public ComplexNumber(double r, double i)
        {
            Real = r;
            Imag = i;
        }

        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            double newReal = (a.Real * b.Real) - (a.Imag* b.Imag);
            double newImaginary = (a.Real * b.Imag) + (a.Imag * b.Real);
            return new ComplexNumber(newReal, newImaginary);
        }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
    }
    #endregion

    #region Problem07
    enum GenderByte : byte
    {
        male,
        female
    }
    #endregion

    #region Problem09
    enum Grades
    {
        A, B, C, D, F
    }
    #endregion

    #region Problem10
    class Employee
    {
        public int Id;
        public string Name;

        public override bool Equals(object obj)
        {
            return obj is Employee e && e.Id == Id;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
    class Helper2<T>
    {
        public static int SearchArray(T[] arr, T value)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i].Equals(value))
                    return i;

            return -1;
        }
        public static void ReplaceArray(T[] arr, T oldVal, T newVal)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i].Equals(oldVal))
                    arr[i] = newVal;
        }
    }
    #endregion

    #region Problem11
    class Helper
    {
        public static T Max<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
    #endregion

    #region Problem13
    struct Rectangle
    {
        public int Length;
        public int Width;
    }

    class Swap01
    {
        public static void Swap(ref Rectangle a, ref Rectangle b)
        {
            Rectangle temp = a;
            a = b;
            b = temp;
        }
    }
    #endregion

    #region Problem14
    class Department
    {
        public string Name;

        public override bool Equals(object obj)
        {
           return obj is Department d && d.Name == Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
    #endregion

    #region Problem15
    public struct Circle
    {
        public double Radius { get; set; }
        public string Color { get; set; }

        public Circle(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }
        public static bool operator ==(Circle left, Circle right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(Circle left, Circle right)
        {
            return !(left == right);
        }
    }
    #endregion

    #region Generic class stack
    public class GenericStack<T>
    {
        private List<T> items = new List<T>();

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (items.Count == 0) throw new InvalidOperationException("Stack empty");
            T item = items[^1];
            items.RemoveAt(items.Count - 1);
            return item;
        }

        public T Peek()
        {
            if (items.Count == 0) throw new InvalidOperationException("Stack empty");
            return items[^1];
        }
    }

    #endregion


    internal class Program
    {
        static void Main()
        {
            #region Problem01
            Weekdays day = Weekdays.Monday;

            for (int i = 1; i <= 5; i++)
            {
                day = (Weekdays)i;
                Console.WriteLine($"{day} = {(int)day}");
            }
            #endregion

            #region Problem02
            Grade grades = Grade.A;

            for (int i = 0; i < 5; i++)
            {
                grades = (Grade)i;
                Console.WriteLine($"{grades} = {(int)grades}");
            }
            #endregion

            #region Problem03
            Person p1 = new Person { Name = "Ahmed", Age = 18, gender = Gender.male, Department = "IT" };
            Person p2 = new Person { Name = "Sara", Age = 23, gender = Gender.female, Department = "HR" };

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            #endregion

            #region Problem04
            Child c = new Child();
            c.DisplaySalary();
            #endregion

            #region Problem05
            Console.WriteLine(Utility.RectanglePerimeter(5, 3));
            #endregion

            #region Problem06
            ComplexNumber n1 = new ComplexNumber(2, 3);
            ComplexNumber n2 = new ComplexNumber(1, 4);
            Console.WriteLine(n1 * n2);
            #endregion

            #region Problem07
            Console.WriteLine(sizeof(byte));
            Console.WriteLine(sizeof(int));
            #endregion

            #region Problem08
            Console.WriteLine(Utility.CelsiusToF(32));
            #endregion

            #region Problem09
            if (Enum.TryParse("A", out Grades g))
                Console.WriteLine(g);
            #endregion

            #region Problem10
            Employee[] emps =
            {
        new Employee{Id=1,Name="Ali"},
        new Employee{Id=2,Name="Sara"}
        };
            Console.WriteLine(Helper2<Employee>.SearchArray(emps, new Employee { Id = 2 }));
            #endregion

            #region Problem11
            Console.WriteLine(Helper.Max(5, 9));
            Console.WriteLine(Helper.Max(5.5, 3.1));
            Console.WriteLine(Helper.Max("Ali", "Zed"));
            #endregion

            #region Problem12
            int[] nums = { 1, 2, 2, 3 };
            Helper2<int>.ReplaceArray(nums, 2, 9);
            #endregion

            #region Problem13
            Rectangle r1 = new Rectangle { Length = 2, Width = 3 };
            Rectangle r2 = new Rectangle { Length = 7, Width = 8 };
            Swap01.Swap(ref r1, ref r2);
            #endregion

            #region Problem15
            Circle c1 = new Circle(5, "Red");
            Circle c2 = new Circle(8, "blue");

            Console.WriteLine(c1.Equals(c2));
            if (c1 == c2)
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not Equal");
            #endregion

            #region Reversing an array
            int[] num = { 1, 2, 3 };
            int[] rev = Reverse(num);
            for (int i = 0; i < rev.Length; i++)
            {
                Console.WriteLine(rev[i]);
            }
            #endregion

            #region Generic class stack
            var stack = new GenericStack<int>();
            stack.Push(10); stack.Push(20);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            #endregion

            #region Swapping element
            Swap(num, 0, 2);
            Console.WriteLine("After swap:");
            foreach (int item in num)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Maximum element
            Console.WriteLine(Max(num));
            #endregion
        }

        #region Reversing an array
        public static T[] Reverse<T>(T[] arr)
        {
            T[] reversed = new T[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                reversed[i] = arr[arr.Length - 1 - i];
            }
            return reversed;
        }
        #endregion

        #region Swapping elements
        public static void Swap<T>(T[] arr, int i, int j)
        {
            if (i < 0 || j < 0 || i >= arr.Length || j >= arr.Length)
                throw new ArgumentOutOfRangeException();
            T temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        #endregion

        #region Maximum element
        public static T Max<T>(T[] arr) where T : IComparable<T>
        {
            if (arr.Length == 0) throw new ArgumentException("Array empty");
            T max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(max) > 0) max = arr[i];
            }
            return max;
        } 
        #endregion
    }
}

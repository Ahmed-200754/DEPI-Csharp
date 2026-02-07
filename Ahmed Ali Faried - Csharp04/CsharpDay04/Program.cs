using System;

namespace CsharpDay04
{
    internal class Program
    {
        static void Main()
        {
            #region Problem01

            int[] a1 = new int[3];                  
            int[] a2 = { 1, 2, 3 };                 
            int[] a3 = new[] { 4, 5, 6 };           

            for (int i = 0; i < a1.Length; i++)
                a1[i] = i * 10;

            foreach (var x in a1)
                Console.WriteLine(x);

            try
            {
                Console.WriteLine(a1[10]); 
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("IndexOutOfRangeException occurred");
            }

            #endregion


            #region Problem02

            int[] arr1 = { 1, 2, 3 };

            int[] arr2 = arr1; // shallow
            arr2[0] = 100;
            Console.WriteLine(arr1[0]); // affected

            int[] arr3 = (int[])arr1.Clone(); // deep
            arr3[0] = 500;
            Console.WriteLine(arr1[0]); // not affected

            #endregion


            #region Problem03

            int[,] grades = new int[3, 3];

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Student {i + 1} Subject {j + 1}: ");
                    grades[i, j] = int.Parse(Console.ReadLine());
                }

            for (int i = 0; i < grades.GetLength(0); i++)
            {
                for (int j = 0; j < grades.GetLength(1); j++)
                    Console.Write(grades[i, j] + " ");
                Console.WriteLine();
            }

            #endregion


            #region Problem04

            int[] nums = { 5, 2, 8, 1, 3 };

            Array.Sort(nums);
            Array.Reverse(nums);

            Console.WriteLine(Array.IndexOf(nums, 3));

            int[] copy = new int[nums.Length];
            Array.Copy(nums, copy, nums.Length);

            Array.Clear(nums, 0, 2);

            #endregion


            #region Problem05

            int[] arr = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            foreach (int x in arr)
                Console.Write(x + " ");

            int k = arr.Length - 1;
            while (k >= 0)
                Console.Write(arr[k--] + " ");

            Console.WriteLine();

            #endregion


            #region Problem06

            int number;
            do
            {
                Console.Write("Enter positive odd number: ");
            }
            while (!int.TryParse(Console.ReadLine(), out number) || number <= 0 || number % 2 == 0);

            Console.WriteLine("Valid number: " + number);

            #endregion


            #region Problem07

            int[,] matrix =
            {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j],4}");
                Console.WriteLine();
            }

            #endregion


            #region Problem08

            Console.Write("Enter month number: ");
            int m = int.Parse(Console.ReadLine());

            if (m == 1) Console.WriteLine("January");
            else if (m == 2) Console.WriteLine("February");
            else Console.WriteLine("Other");

            switch (m)
            {
                case 1: Console.WriteLine("January"); break;
                case 2: Console.WriteLine("February"); break;
                default: Console.WriteLine("Other"); break;
            }

            #endregion


            #region Problem09

            int[] values = { 9, 4, 7, 4, 1 };

            Array.Sort(values);

            Console.WriteLine(Array.IndexOf(values, 4));
            Console.WriteLine(Array.LastIndexOf(values, 4));

            #endregion


            #region Problem10

            int sum1 = 0, sum2 = 0;

            for (int i = 0; i < values.Length; i++)
                sum1 += values[i];

            foreach (int x in values)
                sum2 += x;

            Console.WriteLine(sum1 + " " + sum2);

            #endregion


            #region Problem01-Part02

            Console.Write("Enter day number (1-7): ");
            int d = int.Parse(Console.ReadLine());

            DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), d.ToString());
            Console.WriteLine(day);

            #endregion
            }
        }

        enum DayOfWeek
        {
            Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }

    }

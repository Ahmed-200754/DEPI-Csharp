#nullable enable
using System;
using System.Linq;

namespace CsharpDay05
{
    internal class Program
    {
        static void Main()
        {
            #region Problem01-01
            //int num1, num2;
            //try
            //{
            //    Console.Write("Enter first number: ");
            //    num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Enter second number: ");
            //    num2 = Convert.ToInt32(Console.ReadLine());
            //    int result = num1 / num2;
            //    Console.WriteLine($"Result: {result}");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Error: Cannot divide by zero.");
            //}
            //finally
            //{
            //    Console.WriteLine("Operation complete");
            //}

            #endregion

            #region Problem02-01
            //TestDefensiveCode();
            #endregion

            #region Problem03-01
            //int? intnull = 10;
            //int? intnull2 = intnull ?? 0;
            //Console.WriteLine(intnull2);
            //int intnull3 = intnull.HasValue ? intnull.Value : 0;

            #endregion

            #region Problem04-01
            //int[] arr = new int[5];
            //try
            //{
            //    arr[10] = 5;
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            #endregion

            #region Problem05-01
            //int[,] matrix = new int[3, 3];
            //Console.WriteLine("Enter values for a 3x3 matrix:");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        while (true)
            //        {
            //            Console.Write($"Element [{i},{j}]: ");
            //            if (int.TryParse(Console.ReadLine(), out matrix[i, j]))
            //            {
            //                break;
            //            }
            //            Console.WriteLine("Invalid input. Please enter an integer.");
            //        }
            //    }
            //}
            //Console.WriteLine("The Results is: ");
            //for (int i = 0; i < 3; i++)
            //{
            //    int rowSum = 0;
            //    for (int j = 0; j < 3; j++)
            //    {
            //        rowSum += matrix[i, j];
            //    }
            //    Console.WriteLine($"Sum of Row {i + 1}: {rowSum}");
            //}

            //for (int j = 0; j < 3; j++)
            //{
            //    int colSum = 0;
            //    for (int i = 0; i < 3; i++)
            //    {
            //        colSum += matrix[i, j];
            //    }
            //    Console.WriteLine($"Sum of Column {j + 1}: {colSum}");
            //}
            #endregion

            #region Problem06-01
            //int[][] jaggedArray = new int[3][];
            //jaggedArray[0] = new int[2]; 
            //jaggedArray[1] = new int[4]; 
            //jaggedArray[2] = new int[3]; 

            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    Console.WriteLine($"--- Entering data for Row {i} (Size: {jaggedArray[i].Length}) ---");
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        while (true)
            //        {
            //            Console.Write($"Enter value for Row {i}, Element {j}: ");
            //            if (int.TryParse(Console.ReadLine(), out jaggedArray[i][j]))
            //            {
            //                break;
            //            }
            //            Console.WriteLine("Invalid input. Please enter an integer.");
            //        }
            //    }
            //}
            //Console.WriteLine("\n--- Displaying Jagged Array Contents ---");
            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    Console.Write($"Row {i}: ");
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.WriteLine(jaggedArray[i][j] + " ");
            //    }
            //}

            #endregion

            #region Problem07-01
            //string? userInput;

            //Console.WriteLine("enter a text message:");
            //string? rawInput = Console.ReadLine();

            //if (string.IsNullOrWhiteSpace(rawInput))
            //{
            //    userInput = null;
            //    Console.WriteLine("Variable is now null.");
            //}
            //else
            //{
            //    userInput = rawInput;
            //    Console.WriteLine($"Variable 'userInput' contains: {userInput}");
            //}
            //string confirmedInput = userInput!;

            //Console.WriteLine($"The length of the string is: {confirmedInput.Length}");
            #endregion

            #region Problem08-01
            //int myVal = 100;
            //object boxed = myVal;
            //try
            //{
            //    if (boxed is int unboxed)
            //    {
            //        Console.WriteLine($"Unboxed value: {unboxed}");
            //    }
            //    short invalid = (short)boxed;
            //}
            //catch (InvalidCastException ex)
            //{
            //    Console.WriteLine($"Cast Error: {ex.Message}");
            //} 
            #endregion

            #region Problem09-01
            //int num1 = 5;
            //int num2 = 10;

            //SumAndMultiply(num1, num2, out int calculatedSum, out int calculatedProduct);
            //Console.WriteLine($"The Sum is: {calculatedSum}");
            //Console.WriteLine($"Product: {calculatedProduct}");
            #endregion

            #region Problem10-01
            //Console.WriteLine("Call 1: Default count ");
            //RepeatString("Hello");

            //Console.WriteLine("Positional arguments ");
            //RepeatString("World", 3);

            //Console.WriteLine("Named arguments (out of order) ");
            //RepeatString(count: 2, message: "Named Parameters");

            //Console.WriteLine("Named argument for optional parameter ");
            //RepeatString("Flexibility", count: 1);
            #endregion

            #region Problem11-01
            //int[]? numbers = null;

            //int? length = numbers?.Length;

            //Console.WriteLine($"Array length is: {length?.ToString() ?? "Array is null"}");
            #endregion

            #region Problem12-01
            //Console.WriteLine("Enter a day of the week:");
            //string? dayInput = Console.ReadLine();

            //int dayNumber = dayInput?.Trim().ToLower() 
            //switch
            //{
            //    "monday" => 1,
            //    "tuesday" => 2,
            //    "wednesday" => 3,
            //    "thursday" => 4,
            //    "friday" => 5,
            //    "saturday" => 6,
            //    "sunday" => 7,
            //    _ => 0
            //};

            //Console.WriteLine($"Day Number: {dayNumber}");
            #endregion

            #region Problem13-01
            //int sum1 = SumArray(1, 2, 3, 4);
            //Console.WriteLine($"Sum of individual values: {sum1}");
            //int sum2 = SumArray(new int[] { 10, 20 });
            //Console.WriteLine($"Sum of array values: {sum2}");
            #endregion

            #region Problem01-02
            //Console.Write("Enter a positive integer: ");
            //if (int.TryParse(Console.ReadLine(), out int rangeEnd) && rangeEnd > 0)
            //{
            //    for (int i = 1; i <= rangeEnd; i++)
            //    {
            //        Console.Write(i + (i == rangeEnd ? "" : ", "));
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Problem02-02
            //Console.Write("Enter an integer for displaying its multiplication table: ");
            //if (int.TryParse(Console.ReadLine(), out int tableTarget))
            //{
            //    for (int i = 1; i <= 12; i++)
            //    {
            //        Console.Write((tableTarget * i) + (i == 12 ? "" : ", "));
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Problem03-02
            //Console.Write("Enter a number to find all even numbers up to it: ");
            //if (int.TryParse(Console.ReadLine(), out int evenLimit))
            //{
            //    for (int i = 1; i <= evenLimit; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.Write(i + (i == evenLimit || i == evenLimit - 1 ? "" : ", "));
            //        }
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Problem04-02
            //Console.Write("Enter an integer: ");
            //int baseVal = int.Parse(Console.ReadLine() ?? "0");
            //Console.Write("Enter it's power: ");
            //int exponentVal = int.Parse(Console.ReadLine() ?? "0");

            //long powerResult = 1;
            //for (int i = 0; i < exponentVal; i++)
            //{
            //    powerResult *= baseVal;
            //}
            //Console.WriteLine($"Result: {powerResult}");
            #endregion

            #region Problem05-02
            //Console.Write("Enter text to reverse: ");
            //string? inputString = Console.ReadLine() ?? "";
            //char[] chars = inputString.ToCharArray();
            //Array.Reverse(chars);
            //Console.WriteLine(new string(chars));
            #endregion

            #region Problem06-02
            //Console.Write("Enter an integer to reverse: ");
            //string? intToReverse = Console.ReadLine() ?? "";
            //char[] digitChars = intToReverse.ToCharArray();
            //Array.Reverse(digitChars);
            //Console.WriteLine(new string(digitChars));
            #endregion

            #region Problem07-02
            //Console.Write("Enter array size (N): ");
            //int nSize = int.Parse(Console.ReadLine() ?? "0");
            //int[] distanceArr = new int[nSize];

            //for (int i = 0; i < nSize; i++)
            //{
            //    Console.Write($"Index {i}: ");
            //    distanceArr[i] = int.Parse(Console.ReadLine() ?? "0");
            //}

            //int maxDist = 0;
            //for (int i = 0; i < distanceArr.Length; i++)
            //{
            //    for (int j = distanceArr.Length - 1; j > i; j--)
            //    {
            //        if (distanceArr[i] == distanceArr[j])
            //        {
            //            int currentDist = j - i - 1;
            //            if (currentDist > maxDist) maxDist = currentDist;
            //            break;
            //        }
            //    }
            //}
            //Console.WriteLine($"Longest distance: {maxDist}");
            #endregion

            #region Problem08-02
            //Console.Write("Enter a sentence: ");
            //string? sentenceInput = Console.ReadLine() ?? "";
            //Console.WriteLine(string.Join(" ", sentenceInput.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse()));
            #endregion

        }

        #region Problem02-01
        //public static void TestDefensiveCode()
        //{
        //    int X, Y, Z;

        //    do
        //    {
        //        Console.WriteLine("Enter first Number (Positive Integer): ");
        //    }
        //    while (!int.TryParse(Console.ReadLine(), out X) || X <= 0);

        //    do
        //    {
        //        Console.WriteLine("Enter Second Number (Greater than 1): ");
        //    }
        //    while (!int.TryParse(Console.ReadLine(), out Y) || Y <= 1);

        //    Z = X / Y;
        //    Console.WriteLine($"Result of X / Y: {Z}");

        //    int[] arr = { 1, 2, 3 };
        //    if (arr?.Length > 69)
        //    {
        //        arr[69] = 90;
        //    }
        //} 
        #endregion

        #region Problem09-01
        //static void SumAndMultiply(int a, int b, out int sum, out int product)
        //{
        //    sum = a + b;
        //    product = a * b;
        //}

        #endregion

        #region Problem10-01
        //public static void RepeatString(string message, int count = 5)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine(message);
        //    }
        //    Console.WriteLine();
        //}
        #endregion

        #region Problem13-01
        //public static int SumArray(params int[] numbers)
        //{
        //    int total = 0;
        //    if (numbers != null)
        //    {
        //        foreach (int n in numbers) total += n;
        //    }
        //    return total;
        //} 
        #endregion
    }
}

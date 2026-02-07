using System;
using System.Text;

namespace CsharpDay03
{
    class Program
    {
        static void Main()
        {
            #region Problem01
            Console.WriteLine("enter a string text: ");
            string text = Console.ReadLine();
            try
            {
                int X = int.Parse(text);
                Console.WriteLine("text converted using int.Parse: " + X);
                int Y = Convert.ToInt32(text);
                Console.WriteLine("text converted using Convert.ToInt32: " + Y);
            }
            catch
            {
                Console.WriteLine("The text entered is not a valid integer.");
            }
            #endregion

            #region Problem02
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();
            bool flag = int.TryParse(input, out int number);

            if (flag)
            {
                Console.WriteLine("The number you entered is: " + number);

            }
            else
            {
                Console.WriteLine("The input is not a valid integer ");
            }
            #endregion

            #region Problem03
            object variable;
            variable = 30;
            Console.WriteLine(variable.GetHashCode());
            variable = "this is a string object";
            Console.WriteLine(variable.GetHashCode());
            variable = 25.5;
            Console.WriteLine(variable.GetHashCode());
            #endregion

            #region Problem04
            object obj1 = new object();
            object obj2 = new object();
            obj1 = 90;
            obj2 = obj1;
            obj1 = 120;
            Console.WriteLine(obj2);
            #endregion

            #region Problem05
            string message05 = "Hello Ahmed, ";
            Console.WriteLine(message05.GetHashCode());
            message05 += "Hi Willy";
            Console.WriteLine(message05.GetHashCode());
            #endregion

            #region Problem06
            StringBuilder message = new StringBuilder("Hi Willy");
            Console.WriteLine(message.GetHashCode());
            message.Append(", How are you?");
            Console.WriteLine(message.GetHashCode());
            #endregion

            #region Problem07
            Console.Write("Enter the first number: ");
            int input1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int input2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum is " + input1 + " + " + input2 + " = " + (input1 + input2));
            Console.WriteLine("Sum is {0} + {1} = {2}", input1, input2, (input1 + input2));
            String sum = $"Sum is {input1} + {input2} = {input1 + input2}";
            Console.WriteLine(sum);
            #endregion

            #region Problem08
            StringBuilder sb = new StringBuilder("Hello world ");
            sb.Append("Welcome ");
            sb.Replace("world", "Ahmed");
            sb.Insert(6, "Awesome ");
            sb.Remove(0, 6);

            Console.WriteLine("Final Text: " + sb); 
            #endregion

        }
    }
}

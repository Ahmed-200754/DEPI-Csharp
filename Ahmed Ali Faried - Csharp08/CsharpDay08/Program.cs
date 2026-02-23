using System;

namespace CsharpDay08
{
    internal class Program
    {
        #region Shape series
        public static void PrintTenShapes(IShapeSeries series)
        {
            series.ResetSeries();

            for (int i = 0; i < 10; i++)
            {
                series.GetNextArea();
                Console.WriteLine(series.CurrentShapeArea);
            }
        }
        #endregion

        #region Own Sorting
        public static void SelectionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                        minIndex = j;
                }

                int temp = numbers[i];
                numbers[i] = numbers[minIndex];
                numbers[minIndex] = temp;
            }
        }
        #endregion
        static void Main()
        {
            #region Problem01
            Car car = new Car();
            car.startengine();
            car.stopengine();

            Bike bike = new Bike();
            bike.startengine();
            bike.stopengine();
            #endregion

            #region Problem02
            Circle circle = new Circle(10);
            Console.WriteLine($"Area of Circle: {circle.GetArea()}");

            Rectangle square = new Rectangle(5, 10);
            Console.WriteLine($"Area of Rectangle: {square.GetArea()}");

            InterfaceCircle interfaceCircle = new InterfaceCircle();
            interfaceCircle.Radius = 10;
            Console.WriteLine($"Area of Circle using Interface: {interfaceCircle.GetArea()}");

            InterfaceRectangle interfaceRectangle = new InterfaceRectangle();
            interfaceRectangle.Width = 5;
            interfaceRectangle.Height = 10;
            Console.WriteLine($"Area of Rectangle using Interface: {interfaceRectangle.GetArea()}");

            #endregion

            #region Problem03
            Product[] products = new Product[]
        {
            new Product(1, "Laptop", 1200.50),
            new Product(2, "Mouse", 25.99),
            new Product(3, "Keyboard", 75.00),
            new Product(4, "Monitor", 300.25)
        };

            Console.WriteLine("Products before sorting:");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }

            Array.Sort(products);

            Console.WriteLine("Products after being sorted by price: ");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }

            #endregion

            #region Problem04
            Student s01 = new Student(1, "Ahmed", 90);

            Student studentshallow = s01;

            Student studentdeep = new Student(s01);

            s01.Name = "Ali";
            s01.Grade = 50;

            Console.WriteLine("Original:");
            Console.WriteLine(s01);

            Console.WriteLine("Shallow Copy:");
            Console.WriteLine(studentshallow);

            Console.WriteLine("Deep Copy:");
            Console.WriteLine(studentdeep);
            #endregion

            #region Problem05
            Robot r = new Robot();
            r.Walk();

            IWalkable walker = r;
            walker.Walk();
            #endregion

            #region Problem06
            Account acc = new Account();

            acc.AccountId = 101;
            acc.AccountHolder = "Ahmed";
            acc.Balance = 5000;
            acc.Display();
            #endregion

            #region Problem07
            ILogger logger = new ConsoleLogger();
            logger.log();
            #endregion

            #region Problem08
            Book book01 = new Book();
            Book book02 = new Book("Csharp");
            Book book03 = new Book("Csharp", "Ahmed Ali");
            #endregion

            #region Shape Series
            SquareSeries squareSeries = new SquareSeries();
            PrintTenShapes(squareSeries);
            Console.WriteLine();
            CircleSeries circleSeries = new CircleSeries();
            PrintTenShapes(circleSeries);
            #endregion

            #region Sorting for Shapes
            Shape01[] shapes =
            {
            new Shape01 { Name = "Square", Area = 16 },
            new Shape01 { Name = "Circle", Area = 28.27 },
            new Shape01 { Name = "Rectangle", Area = 10 }
            };

            Array.Sort(shapes);

            foreach (var s in shapes)
                Console.WriteLine($"{s.Name} : {s.Area}");
            #endregion

            #region Extend the Shape Hierarchy
            GeometricShape rect = new Rectangle01 { Dimension1 = 4, Dimension2 = 5 };
            GeometricShape triangle = new Triangle { Dimension1 = 4, Dimension2 = 3 };

            Console.WriteLine(rect.CalculateArea());
            Console.WriteLine(triangle.CalculateArea());
            #endregion

            #region Own Sorting
            int[] areas = { 16, 28, 10, 50, 7 };

            SelectionSort(areas);

            foreach (int a in areas)
                Console.WriteLine(a);
            #endregion

            #region Factory Pattern
            GeometricShape s1 = ShapeFactory.CreateShape("rectangle", 5, 4);
            GeometricShape s2 = ShapeFactory.CreateShape("triangle", 3, 6);

            Console.WriteLine(s1.CalculateArea());
            Console.WriteLine(s2.CalculateArea()); 
            #endregion



        }

    }
}

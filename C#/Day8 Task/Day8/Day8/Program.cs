using Day8.Abstract;
using Day8.Interface;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Day8
{
    class Program
    {
        static void PrintTenShaps(IShapeSeries series)
        {
            for (int i = 0; i < 10; i++)
            {
                series.GetNextArea();
                Console.WriteLine(series.CurrentArea);
            }
            series.ResetSeries();
        }

        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void SelectionSort(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) == 1)
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            #region Problem1
            //Car car = new Car();
            //car.StartEngine();
            //car.StopEngine();

            //Console.WriteLine();

            //Bike bike = new Bike();
            //bike.StartEngine();
            //bike.StopEngine();
            #endregion

            #region Problem2
            //// using abstract
            //Rectangle rec = new Rectangle(14, 10);
            //Circle circle = new Circle(10);

            //rec.Display();
            //Console.WriteLine($"Rectangle area = {rec.CalcArea()}");

            //circle.Display();
            //Console.WriteLine($"Circle area = {circle.CalcArea()}");

            //// using interface
            //RecI reci = new RecI(12, 8);
            //CircleI circleI = new CircleI(7);

            //Console.WriteLine(reci.CalcArea());
            //Console.WriteLine(circleI.CalcArea());
            #endregion

            #region Problem3
            //Product[] products =
            //{
            //    new Product(1, "Tee", 120),
            //    new Product(2, "Coffee", 150),
            //    new Product(3, "Milk", 20),
            //    new Product(4, "Meat", 350)
            //};
            //Array.Sort(products);
            //foreach (Product item in products)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            #endregion

            #region Problem4
            //Student Stu1 = new Student(1, "Abdo", 88);
            //Student Stu2 = new Student(Stu1);
            //Student Stu3 = Stu1;
            //Console.WriteLine("After Copy");
            //Console.WriteLine(Stu1.ToString());
            //Console.WriteLine(Stu2.ToString());
            //Console.WriteLine(Stu3.ToString());

            //Console.WriteLine();

            //Stu2.Id = 2;
            //Stu2.Name = "Ali";
            //Stu3.Id = 3;
            //Stu3.Name = "Ahmed";
            //Console.WriteLine("After edit");
            //Console.WriteLine(Stu1.ToString());
            //Console.WriteLine(Stu2.ToString());
            //Console.WriteLine(Stu3.ToString());
            #endregion

            #region Problem5
            //Robot robot = new Robot();
            //robot.Walk();
            //IWalkable walkableRobot = robot;
            //walkableRobot.Walk();
            #endregion

            #region Problem6
            //Account account = new Account();
            //account.AccountId = 1;
            //account.AccountHolder = "Abdo";
            //account.Balance = 0;
            //Console.WriteLine(account.ToString());
            #endregion

            #region Problem7
            //ILogger DefaultLog = new DefaultLogger();
            //DefaultLog.Log();
            //ConsoleLogger ConLog = new ConsoleLogger();
            //ConLog.Log();
            #endregion

            #region Problem8
            //Book book1 = new Book();
            //Book book2 = new Book("Art of coding");
            //Book book3 = new Book("Jartin rules", "Amr Abdelhameed");

            //Console.WriteLine(book1.ToString());
            //Console.WriteLine(book2.ToString());
            //Console.WriteLine(book3.ToString());
            #endregion

            ////////////////////////// Part02 ////////////////////////

            #region Problem1
            //SquarSeries Square = new SquarSeries();
            //Console.WriteLine("Square Area");
            //PrintTenShaps(Square);

            //CircleSeries Circle = new CircleSeries();
            //Console.WriteLine("Circle Area");
            //PrintTenShaps(Circle);
            #endregion

            #region Problem2
            //Shape2[] Shapes =
            //{
            //    new Shape2("Circle", 20),
            //    new Shape2("Square", 22),
            //    new Shape2("Triangle", 15),
            //    new Shape2("Rectangle", 30)
            //};

            //Array.Sort(Shapes);
            //foreach(Shape2 shape in Shapes)
            //{
            //    Console.WriteLine(shape.ToString());
            //}
            #endregion

            #region Problem3
            //GRectangle rec = new GRectangle(10, 8);
            //Triangle tri = new Triangle(4, 6);

            //Console.WriteLine("Rectangle: ");
            //Console.WriteLine($"Area: {rec.CalcArea()}");
            //Console.WriteLine($"Perimeter = {rec.Perimeter}");

            //Console.WriteLine("Triangle");
            //Console.WriteLine($"Area: {tri.CalcArea()}");
            //Console.WriteLine($"Perimeter: {tri.Perimeter}");
            #endregion

            #region Problem4
            //int[] arr = { 15, 7, 20, 4, 1, 24, 8};
            //SelectionSort(arr);
            //foreach(int i in arr)
            //{
            //    Console.Write($"{i}  ");
            //}
            #endregion


        }
    }
}
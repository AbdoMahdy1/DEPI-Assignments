using System;
using System.Linq;

namespace Day5
{
    internal class Program
    {

        public static void TestDefensiveCode()
        {
            int X, Y, Z;
            do
                Console.WriteLine("Enter First Number");
            while (!int.TryParse(Console.ReadLine(), out X) || X <= 0);
            do
                Console.WriteLine("Enter Second Number");
            while (!int.TryParse(Console.ReadLine(), out Y) || Y <= 1);
            Z = X / Y;

            int[] arr = { 1, 2, 3 };
            if (arr?.Length > 98)
                arr[98] = 76;
        }

        public static void MulSum(int x, int y, out int sum, out int mul)
        {
            sum = x + y;
            mul = x * y;
        }

        public static void print(string s, int n = 5)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(s);
            }
        }

        public static int SumArr(params int[] arr)
        {
            int sum = 0;

            foreach (int i in arr)
            {
                sum += i;
            }

            return sum;
        }



        static void Main(string[] args)
        {
            #region Problem1
            //try
            //{
            //    Console.Write("Enter first number: ");
            //    int num1 = int.Parse(Console.ReadLine());
            //    Console.Write("Enter second number: ");
            //    int num2 = int.Parse(Console.ReadLine());
            //    int result = num1 / num2;
            //    Console.WriteLine($"Division = {result}");
            //}

            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Error: Division by zero is not allowed");
            //}

            //finally
            //{
            //    Console.WriteLine("Operation complete.");
            //} 
            #endregion

            #region Problem2
            //try
            //{
            //TestDefensiveCode();
            //}
            //catch (Exception ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region Problem3
            //int? num = null;
            //int num1 = num ?? 5;
            //int num2 = num.HasValue ? num.Value : 10;
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            #endregion

            #region Problem4
            //int[] arr = { 1, 2, 3, 4, 5 };
            //try
            //{
            //arr[10] = 1;

            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region Problem5
            //int[,] arr = new int[3,3];

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(0); j++)
            //    {
            //        arr[i,j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //int SumRow = 0;
            //int SumCol = 0;

            //for (int i = 0;i < arr.GetLength(1); i++)
            //{
            //    for(int j = 0;j < arr.GetLength(1); j++)
            //    {
            //        SumRow += arr[i,j];
            //        SumCol += arr[j,i];
            //    }
            //    Console.WriteLine($"Sum of row {i+1} is: {SumRow}");
            //    Console.WriteLine($"Sum of Column {i+1} is: {SumCol}");
            //    SumRow = 0;
            //    SumCol = 0;
            //}
            #endregion

            #region Problem6
            //int[][] arr = new int[3][];

            //Console.Write("Enter size of row 1: ");
            //int num = int.Parse(Console.ReadLine());
            //arr[0] = new int[num];
            //Console.Write("Enter size of row 2: ");
            //num = int.Parse(Console.ReadLine());
            //arr[1] = new int[num];
            //Console.Write("Enter size of row 3: ");
            //num = int.Parse((string)Console.ReadLine());
            //arr[2] = new int[num];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"Enter vales for row {i+1}: ");
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        arr[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0;i < arr.Length; i++)
            //{
            //    Console.Write($"Values of row {i + 1}: ");
            //    for(int j = 0;j < arr[i].Length; j++)
            //    {
            //        Console.Write($"{arr[i][j]}  ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Problem7
            //Console.WriteLine("Enter string");
            //string? str = Console.ReadLine()!;
            #endregion

            #region Problem8
            //int x = 10;
            //object obj = x;
            //obj = Console.ReadLine();
            //try
            //{
            //    x = (int)obj;
            //}
            //catch(InvalidCastException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region Problem9
            //int x = 5, y = 10, sum, mul;
            //MulSum(x, y, out sum, out mul);
            //Console.WriteLine($"Sum: {sum}");
            //Console.WriteLine($"Mul: {mul}");
            #endregion

            #region Problem10
            //print(s: "Hello");
            #endregion

            #region Problem11
            //int[]? arr = null;
            //Console.WriteLine("Length: " + arr?.Length);

            //arr = new int[] { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Length: " + arr?.Length);
            #endregion

            #region Problem12
            //Console.Write("Enter number of day of the weak: ");
            //int day = int.Parse(Console.ReadLine());

            //switch (day)
            //{
            //    case 1: Console.WriteLine("The day is Monday");
            //        break;
            //    case 2: Console.WriteLine("The day is Tuesday");
            //        break;
            //    case 3: Console.WriteLine("The day is Wednesday");
            //        break;
            //    case 4: Console.WriteLine("The day is Thursday");
            //        break;
            //    case 5: Console.WriteLine("The day is Friday");
            //        break;
            //    case 6: Console.WriteLine("The day is Saturday");
            //        break;
            //    case 7: Console.WriteLine("The day is Sunday");
            //        break;
            //}
            #endregion

            #region Problem13
            //Console.WriteLine($"Sum of an array = {SumArr(12, 4, 5, 23, 9)}");
            //int[] arr = {1, 2, 3, 4, 5};
            //Console.WriteLine($"Sum of an array = {SumArr(arr)}");
            #endregion

            /////////////////////////////// Part02 /////////////////////////////


            #region Problem1
            //Console.Write("Enter any positive int: ");
            //int n = int.Parse(Console.ReadLine());
            //for(int i = 1; i <= n; i++)
            //{
            //    Console.Write($"{i} ");
            //}
            #endregion

            #region Problem2
            //Console.Write("Enter any positive int: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write($"Multiplication table of number {n}: ");
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write($"{i * n} ");
            //}
            #endregion

            #region Problem3
            //Console.Write("Enter any positive int: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write($"Even number before {n}: ");
            //for (int i = 1; i <= n; i++)
            //{
            //    if(i % 2 == 0)
            //        Console.Write($"{i} ");
            //    else
            //        continue;
            //}
            #endregion

            #region Problem4
            //Console.Write("Enter first int: ");
            //int n1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter first int: ");
            //int n2 = int.Parse(Console.ReadLine());

            //int res = 1;
            //for (int i = 0; i < n2; i++)
            //{
            //    res *= n1;
            //}

            //Console.Write($"Result of {n1}^{n2} = {res}");
            #endregion

            #region Problem5
            //Console.Write("Enter any string: ");
            //string input = Console.ReadLine();

            //Console.Write("Reversed string: ");
            //for(int i  = input.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(input[i]);
            //}
            #endregion

            #region Problem6
            //Console.Write("Enter any number: ");
            //int n = int.Parse(Console.ReadLine());

            //Console.Write("Reverse number: ");
            //int temp = n;
            //int reverse = 0;
            //while(temp > 0)
            //{
            //    int digit = 0;
            //    digit = temp % 10;
            //    reverse = reverse * 10 + digit;
            //    temp /= 10;
            //}

            //Console.WriteLine(reverse);
            #endregion

            #region Problem7
            //Console.Write("Enter a sentence: ");
            //string sentence = Console.ReadLine();

            //Console.WriteLine(string.Join(" ", sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse()));
            #endregion

        }
    }
}

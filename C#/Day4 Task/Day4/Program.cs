using System;
using System.Diagnostics;

namespace Day4
{
    class Program
    {

        enum DayOfWeek
        {
            Saturday = 1,
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
        }
        static void Main(string[] args)
        {
            #region Problem1
            //int[] arr1 = new int[3];
            //int[] arr2 = new int[] { };
            //int[] arr3;
            //arr1 = new int[] { 1, 2, 3 };
            //try
            //{
            //    Console.WriteLine(arr1[0]);
            //    Console.WriteLine(arr1[1]);
            //    Console.WriteLine(arr1[2]);
            //    Console.WriteLine(arr1[3]);
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Index is out of range.");
            //}
            #endregion

            #region Problem2
            //int[] arr1;
            //int[] arr2;
            //// Shallow Copy
            //arr1 = new int[] { 1, 2, 3 };
            //arr2 = arr1;
            //arr2[0] = 4;
            //foreach(int i in arr1)
            //{
            //    Console.WriteLine(i);
            //}

            ////Deep Copy
            //arr1 = new int[] { 1, 2, 3 };
            //arr2 = (int[])arr1.Clone();
            //arr2[0] = 4;
            //foreach(int i in arr1)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Problem3
            //int[,] arr = new int[3,3];
            //for(int i = 0; i < arr.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter Grades for stuedent number {i+1}");
            //    for(int j = 0; j < arr.GetLength(0); j++)
            //    {
            //        arr[i,j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for(int i = 0; i < arr.GetLength(0); i++)
            //{
            //    Console.Write($"Grades for stuedent number {i+1} is: ");
            //    for(int j = 0; j < arr.GetLength(0); j++)
            //    {
            //        Console.Write("\t" + arr[i,j]);
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Problem4
            //int[] arr = { 2, 4, 1, 3 };
            //Console.Write("The original array:");
            //foreach (int i in arr) Console.Write("  " + i);
            //Console.WriteLine();

            //Array.Sort(arr);
            //Console.Write("After sorting:");
            //foreach (int i in arr) Console.Write("  " + i);
            //Console.WriteLine();

            //Array.Reverse(arr);
            //Console.Write("After reverse:");
            //foreach (int i in arr) Console.Write("  " + i);
            //Console.WriteLine();

            //Console.WriteLine("Index of element \"3\" is: " + Array.IndexOf(arr, 3, 0));

            //int[] arr2 = new int[arr.Length];
            //Array.Copy(arr, arr2, arr.Length);
            //Console.Write("Copied array:");
            //foreach(int i in arr2) Console.Write("  " + i);
            //Console.WriteLine();

            //Array.Clear(arr, 0, arr.Length);
            //Console.Write("After clearing:");
            //foreach(int i in arr) Console.Write("  " + i);
            //Console.WriteLine();

            #endregion

            #region Problem5
            //int[] arr = { 1, 2, 3, 4, 5 };
            //Console.Write("Using for:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(" " + arr[i]);
            //}
            //Console.WriteLine();

            //Console.Write("Using foreach:");
            //foreach (int i in arr)
            //{
            //    Console.Write(" " + i);
            //}
            //Console.WriteLine();

            //int n = arr.Length - 1;
            //Console.Write("Using While:");
            //while (n >= 0)
            //{
            //    Console.Write(" " + arr[n]);
            //    n--;
            //}
            #endregion

            #region Problem6
            //int Num;
            //bool flag;
            //do
            //{
            //    Console.Write("Enter odd positive number: ");
            //    flag = int.TryParse(Console.ReadLine(), out Num);
            //}
            //while(Num % 2  == 0 || Num <= 0 || !flag);
            #endregion

            #region Problem7
            //int[,] arr = new int[3, 3] { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };
            //for(int i = 0;  i < arr.GetLength(0); i++)
            //{
            //    for(int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i,j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Problem8
            //int num;
            //bool flag;
            //do
            //{
            //    Console.Write("Enter a month number: ");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //}
            //while (num < 1 || num > 12 || !flag);

            //// Using if
            //if (num == 1)
            //    Console.WriteLine("The month is January");
            //else if (num == 2)
            //    Console.WriteLine("The month is Fabuary");
            //else if (num == 3)
            //    Console.WriteLine("The month is March");
            //else if (num == 4)
            //    Console.WriteLine("The month is April");
            //else if (num == 5)
            //    Console.WriteLine("The month is May");
            //else if (num == 6)
            //    Console.WriteLine("The month is June");
            //else if (num == 7)
            //    Console.WriteLine("The month is July");
            //else if (num == 8)
            //    Console.WriteLine("The month is August");
            //else if (num == 9)
            //    Console.WriteLine("The month is September");
            //else if (num == 10)
            //    Console.WriteLine("The month is October");
            //else if (num == 11)
            //    Console.WriteLine("The month is November");
            //else
            //    Console.WriteLine("the month is December");

            //Console.Clear();

            //// Using switch
            //switch (num)
            //{
            //    case 1: Console.WriteLine("The month is January");
            //        break;
            //    case 2: Console.WriteLine("The month is Fabruary");
            //        break;
            //    case 3: Console.WriteLine("The month is March");
            //        break;
            //    case 4: Console.WriteLine("The month is April");
            //        break;
            //    case 5: Console.WriteLine("The month is May");
            //        break;
            //    case 6: Console.WriteLine("The month is June");
            //        break;
            //    case 7: Console.WriteLine("The month is July");
            //        break;
            //    case 8: Console.WriteLine("The month is August");
            //        break;
            //    case 9: Console.WriteLine("The month is September");
            //        break;
            //    case 10: Console.WriteLine("The month is October");
            //        break;
            //    case 11: Console.WriteLine("The month is November");
            //        break;
            //    default: Console.WriteLine("The month is December");
            //        break;
            //}

            #endregion

            #region Problem9
            //int[] arr = { 4, 3, 1, 5, 2, 4};

            //Console.Write("Before Sorting: ");
            //foreach (int i in arr) Console.Write(" " + i);
            //Console.WriteLine();

            //Array.Sort(arr);
            //Console.Write("After Sorting: ");
            //foreach(int i in arr) Console.Write(" " + i);
            //Console.WriteLine();

            //Console.WriteLine($"The index of element \"3\" is: {Array.IndexOf(arr, 3)}");
            //Console.WriteLine($"The last index of element \"4\" is: {Array.LastIndexOf(arr, 4)}");
            #endregion

            #region Problem10
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8};
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}
            //Console.WriteLine($"Sum Using for: {sum}");

            //sum = 0;
            //foreach (int i in arr)
            //{
            //    sum += i;
            //}
            //Console.WriteLine($"Sum Using foreach: {sum}");
            #endregion

            //////////////////////////////////// Part02 /////////////////////////////////

            #region EnumProblem
            //int num = int.Parse(Console.ReadLine());
            //DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), num.ToString());
            //Console.WriteLine(day);
            #endregion

        }
    }
}

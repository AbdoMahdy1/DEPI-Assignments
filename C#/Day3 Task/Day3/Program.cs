using System;
using System.Text;
using System.Threading.Channels;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Problem1
            //try
            //{
            //    Console.Write("Enter Number1: ");
            //    int Num = int.Parse(Console.ReadLine());
            //    Console.Write("Enter Number2: ");
            //    int Num2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Number 1: " + Num);
            //    Console.WriteLine("Number 2: " + Num2);

            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid input! Please enter a valid number.");
            //}

            //catch (ArgumentNullException)
            //{
            //    Console.WriteLine("No input provided. Please enter a number.");
            //}
            #endregion

            #region Problem2
            //Console.Write("Enter Number: ");
            //string S = Console.ReadLine();
            //int Num;
            //if(int.TryParse(S, out Num))
            //    Console.WriteLine("The Number is: " + Num);
            //else
            //    Console.WriteLine("Error: Failed to convert.");
            #endregion

            #region Problem3
            //Student stu1 = new Student();
            //stu1.name = "Abdo";
            //stu1.age = 21;
            //stu1.GPA = 3.1D;
            //Console.WriteLine(stu1.name.GetHashCode());
            //Console.WriteLine(stu1.age.GetHashCode());
            //Console.WriteLine(stu1.GPA.GetHashCode());
            #endregion

            #region Problem4
            //Student stu1 = new Student();
            //Student stu2 = new Student();
            //stu1.name = "Abdo";
            //stu1.age = 21;
            //stu1.GPA = 3.1D;
            //stu2 = stu1;
            //stu2.name = "Ali";
            //stu2.age = 20;
            //stu2.GPA = 2.6D;
            //Console.WriteLine(stu1.name);
            //Console.WriteLine(stu1.age);
            //Console.WriteLine(stu1.GPA);
            #endregion

            #region Problem5
            //string s = "Hello World";
            //Console.WriteLine("Original: " + s);
            //Console.WriteLine(s.GetHashCode());
            //s += ", Hi Willy";
            //Console.WriteLine("Modified: " + s);
            //Console.WriteLine(s.GetHashCode());
            #endregion

            #region Problem6
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Hello");
            //Console.WriteLine("Befor: " + sb.GetHashCode());
            //sb.Append(", Hi Willy");
            //Console.WriteLine("After: " + sb.GetHashCode());
            #endregion

            #region Problem7
            //Console.Write("Enter Number1: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter Number2: ");
            //int num2 = int.Parse(Console.ReadLine());
            //int sum = num1 + num2;
            //Console.WriteLine("Sum by concatenation: " + sum);
            //Console.WriteLine("Sum string formating: {0}", sum);
            //Console.WriteLine($"Sum by interpolation: {sum}");

            #endregion

            #region Problem8
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Hello World!");
            //Console.WriteLine("After Append: " + sb);
            //sb.Replace("World", "Ahmed");
            //Console.WriteLine("After replace: " + sb);
            //sb.Insert(12, " This is C# Project");
            //Console.WriteLine("After Insertion: " + sb);
            //sb.Remove(0,12);
            //Console.WriteLine("After remove: " + sb);
            #endregion
        }
    }
}

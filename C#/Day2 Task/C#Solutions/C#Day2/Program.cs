using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace C_Day2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Problem1
            //Add both single - line and multi-line comments in the following code segmentexplaining its purpose
            //int x = 10;
            //int y = 20;
            //int sum = x + y; //Is 30
            //Console.WriteLine(sum); /* This will print the sum of the two numbers */
            #endregion

            #region Problem2
            //Identify and fix the errors in this code snippet
            //int x = "10"; First error is that the variable is int and the value is string
            //console.WriteLine(x + y); second is that y is not declared variable
            //correction:-
            //int x = 10;
            //int y = 5;
            //Console.WriteLine(x + y);
            #endregion

            #region Problem3
            //Declare variables using proper naming conventions to store
            //string FullName; //Your full name.
            //int Age; //Your age.
            //int Salary; //Your monthly salary.
            //bool Student; //Whether you are a student.
            #endregion

            #region Problem4
            //Write a program to demonstrate that changing the value of a reference type affects allreferences pointing to that object.
            //Student Stu1 = new Student();
            //Student Stu2 = new Student();
            //Stu1.Name = "Abdo";
            //Stu2 = Stu1;
            //Console.WriteLine("Before Changing.");
            //Console.WriteLine("Stu1 Name: " + Stu1.Name);
            //Console.WriteLine("Stu2 Name: " + Stu2.Name);
            //Stu2.Name = "Ahmed";
            //Console.WriteLine("After Changing.");
            //Console.WriteLine("Stu1 Name: " + Stu1.Name);
            //Console.WriteLine("Stu2 Name: " + Stu2.Name);

            #endregion

            #region Problem5
            //Create a program that calculates the following using variables x = 15 and y = 4
            //int x = 15;
            //int y = 4;
            //Console.WriteLine("Sum: " + (x + y));
            //Console.WriteLine("Dif: " + (x - y));
            //Console.WriteLine("Mul: " + (x * y));
            //Console.WriteLine("Div: " + (x / y));
            //Console.WriteLine("Mod: " + (x % y));
            #endregion

            #region Problem6
            //Write a program that checks if a given number is both Greater than 10 and Even.
            //int Number = int.Parse(Console.ReadLine());
            //bool Check = false;
            //if (Number > 10 && (Number % 2 == 0))
            //    Check = true;
            //Console.WriteLine(Check);
            #endregion

            #region Problem7
            //Implement a program that takes a double input from the user and casts it to an int. Use both implicit and explicit casting.
            //double Num1 = double.Parse(Console.ReadLine());
            ////int Num2 = Num1; //compile - time error
            //int Num3 = (int)Num1;
            //Console.WriteLine(Num1);
            //Console.WriteLine(Num3);
            #endregion

            #region Problem8
            //Console.Write("Enter your age: ");
            //int age = int.Parse(Console.ReadLine());
            //if(age > 0)
            //    Console.WriteLine("Valid");
            //else
            //    Console.WriteLine("Not Valid");
            #endregion

            #region Problem9
            //Write a program that demonstrates the difference between prefix and postfix increment operators using a variable x.
            //int x = 10;
            //Console.WriteLine(x++); // print 10 then will be 11
            //Console.WriteLine(++x); // it was 11 then increased to 12 and print 12
            #endregion

            
        }
    }
}

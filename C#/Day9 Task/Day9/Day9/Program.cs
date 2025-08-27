using System;
using System.Runtime.InteropServices;

namespace Day9
{
    class Program
    {
        #region Enums
        enum GenderInt
        {
            Male = 1,
            Female
        }

        enum GenderByte
        {
            Male = 1,
            Female
        }
        #endregion

        #region Methods
        static void PrintArr<T>(T[] arr, string message)
        {
            Console.Write($"{message}: ");
            foreach (T item in arr)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine();
        }

        static void ReverseArr<T>(T[] array)
        {
            T[] TempArr = new T[array.Length];
            Array.Copy(array, TempArr, array.Length);

            for (int i = array.Length - 1; i >= 0; i--)
            {
                array[TempArr.Length -1 - i] = TempArr[i];
            }            
        }

        static int SearchArr<T>(T[] Arr, T Value)
        {
            for (int i = 0; i < Arr?.Length; i++)
            {
                if (Value.Equals((Arr[i])))
                    return i;
            }
            return -1;
        }

        static void SwapArr<T>(T[] Arr, T Value1, T Value2)
        {
            int in1 = SearchArr<T>(Arr, Value1);
            int in2 = SearchArr<T>(Arr, Value2);

            Arr[in1] = Value2;
            Arr[in2] = Value1;
        }

        static int ArrMax<T>(T[] Arr) where T : IComparable<T>
        {
            if (Arr == null || Arr.Length == 0)
                throw new ArgumentException("Array is empty or null");

            T max = Arr[0];

            for (int i = 1; i < Arr.Length; i++)
            {
                if (Arr[i].CompareTo(max) > 0)
                {
                    max = Arr[i];
                }
            }

            return SearchArr<T>(Arr, max);
        }
        #endregion

        static void Main(string[] args)
        {
            #region Problem1

            #endregion

            #region Problem2
            //Console.WriteLine($"Rectangle Perimeter = {Utility.CalcRecPer(10, 8)}");
            #endregion

            #region Problem3
            //ComplexNumber c1 = new ComplexNumber { Real = 5, Imag = 4};
            //ComplexNumber c2 = new ComplexNumber { Real = 8, Imag = 6};
            //ComplexNumber c3 = default;
            //c3 = c1 * c2;

            //Console.WriteLine(c1.ToString());
            //Console.WriteLine(c2.ToString());
            //Console.WriteLine();
            //Console.WriteLine(c3.ToString());

            #endregion

            #region Problem4
            //Console.WriteLine("Memory usage of enums:");

            //Console.WriteLine($"Default Gender (int): {sizeof(int)} bytes");
            //Console.WriteLine($"Gender with byte    : {sizeof(byte)} bytes");
            #endregion

            #region Problem5
            //Console.WriteLine(Utility.ConvertCelsToFahren(40));
            #endregion

            #region Problem6

            #endregion

            #region Problem7
            //Console.WriteLine($"Int Max = {Helper<int>.Max(4, 8)}");
            //Console.WriteLine($"Double Max = {Helper<double>.Max(10.2, 7.6)}");
            //Console.WriteLine($"String Max = {Helper<string>.Max("Abdelsalam", "Mahdy")}");
            #endregion

            #region Problem8
            //int[] Numbers = { 1, 2, 3, 4, 5, 6 };
            //string[] Fruits = { "Apple", "Peach", "Watermelon", "Pear", "Banana" };

            //PrintArr<int>(Numbers, "Old Numbers");
            //Console.WriteLine();
            //PrintArr<string>(Fruits, "Old Fruits");

            //Helper<int>.ReplaceArr(Numbers, 1, 7);
            //Console.WriteLine();
            //PrintArr<int>(Numbers, "New Numbers");

            //Helper<string>.ReplaceArr(Fruits, "Peach", "Grip");

            //Console.WriteLine();
            //PrintArr<string>(Fruits, "New Fruits");
            #endregion

            #region Problem9
            //Rectangle Rec = new Rectangle(15, 10);
            //Console.WriteLine($"Original: {Rec.ToString()}");
            //Rec.Swap();
            //Console.WriteLine($"After Swapping: {Rec.ToString()}");

            #endregion


            //////////////////////////// Part02 //////////////////////////

            #region Problem1
            //int[] Numbers = { 1, 2, 3, 4, 5, 6 };
            //string[] Fruits = { "Apple", "Peach", "Watermelon", "Pear", "Banana" };

            //PrintArr<int>(Numbers, "Old Numbers");
            //Console.WriteLine();

            //ReverseArr<int>(Numbers);
            //PrintArr<int>(Numbers, "Reversed Numbers");

            //Console.WriteLine();
            //PrintArr<string>(Fruits, "Old Fruits");

            //Console.WriteLine();
            //ReverseArr<string>(Fruits);
            //PrintArr<string>(Fruits, "Reversed Fruits");
            #endregion

            #region Problem2

            #endregion

            #region Problem3
            //int[] Numbers = { 1, 2, 3, 4, 5, 6 };
            //string[] Fruits = { "Apple", "Peach", "Watermelon", "Pear", "Banana" };

            //PrintArr<int>(Numbers, "Old Numbers");
            //Console.WriteLine();
            //SwapArr<int>(Numbers, 1, 6);
            //PrintArr<int>(Numbers, "Swapped Numbers");

            //Console.WriteLine();
            //PrintArr<string>(Fruits, "Old Fruits");

            //Console.WriteLine();
            //SwapArr<string>(Fruits, "Apple", "Banana");
            //PrintArr<string>(Fruits, "Swapped Fruits");
            #endregion

            #region Problem4
            //int[] Numbers = { 1, 2, 3, 4, 5, 6 };
            //string[] Fruits = { "Apple", "Peach", "Watermelon", "Pear", "Banana" };

            //Console.WriteLine($"Max in Numbers is: {Numbers[ArrMax(Numbers)]}");
            //Console.WriteLine($"Max in Fruits is : {Fruits[ArrMax(Fruits)]}");
            #endregion
        }
    }
}
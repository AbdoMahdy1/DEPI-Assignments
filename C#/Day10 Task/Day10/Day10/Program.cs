using System;

namespace Day10
{
    class Program
    {

        #region Delegates
        public delegate void SortArr(int[] arr);
        public delegate int IntFuncDelegate(int x, int y);
        #endregion

        #region Mthods

        #endregion

        static void Main(string[] args)
        {
            #region Problem1
            //Employee[] employees =
            //{
            //    new Employee(1, 5000, "Ahmed"),
            //    new Employee(2, 4500, "Mohamed"),
            //    new Employee(3, 4700, "Emad"),
            //    new Employee(4, 5200, "Mohsen")
            //};

            //SortingAlgorithm<Employee>.Sort(employees);
            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee.ToString());
            //}
            #endregion

            #region Problem2
            //int[] Numbers = {1, 2, 3, 4, 5};
            //SortingTwo.SortDesc(Numbers);
            //foreach (int num in Numbers)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion

            #region Problem3
            //string[] words = { "apple", "banana", "kiwi", "cherry", "fig" };

            //SortingTwo<string>.Sort(words, (x, y) => x.Length.CompareTo(y.Length));

            //foreach (string word in words)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region Problem4
            //Manager[] managers =
            //{
            //    new Manager(1, 4500),
            //    new Manager(2, 4200),
            //    new Manager(3, 5000),
            //    new Manager(4, 4000)
            //};
            //SortingAlgorithm<Manager>.Sort(managers);
            //foreach(Manager manager in managers)
            //{
            //    Console.WriteLine(manager.ToString());
            //}
            #endregion

            #region Problem5
            //Employee[] employees =
            //{
            //    new Employee(1, 5000, "Abdo"),
            //    new Employee(2, 4500, "Ahmed"),
            //    new Employee(3, 4700, "Ali"),
            //    new Employee(4, 5200, "Ibrahim")
            //};
            //SortingTwo<Employee>.Sort(employees, Employee.CompareNames);
            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee.ToString());
            //}
            #endregion

            #region Problem6
            //SortArr sort = delegate (int[] arr)
            //{
            //    SortingTwo<int>.SortAesc(arr);
            //};
            //int[] numbers = { 3, 45, 13, 78, 5, 20, 17 };
            //sort(numbers);
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();

            //SortArr sort2 = (int[] arr) => SortingTwo<int>.SortAesc(arr);
            //int[] numbers2 = { 3, 45, 13, 78, 5, 20, 17 };
            //sort2 (numbers2);
            //foreach (int i in numbers2)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Problem7
            //int[] arr = { 1, 2, 3, 4, 5 };
            //SortingAlgorithm<int>.Swap(ref arr[0], ref arr[4]);
            //foreach (int x in arr)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion

            #region Problem8
            //Employee[] employees =
            //{
            //    new Employee(1, 5000, "Abdo"),
            //    new Employee(2, 4500, "Ahmed"),
            //    new Employee(3, 4700, "Ali"),
            //    new Employee(4, 5000, "Ibrahim")
            //};
            //SortingTwo<Employee>.Sort(employees, Employee.Compare);
            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee.ToString());
            //}
            #endregion

            #region Problem9
            //IntFuncDelegate AddingInts = (int x, int y) => { return x + y; };
            //IntFuncDelegate MultipInts = (int x, int y) => { return x * y; };
            //IntFuncDelegate SubInts = (int x, int y) => { return x - y; };
            //IntFuncDelegate DivInts = (int x, int y) => { return x / y; };
            //int x = 15;
            //int y = 10;
            //Console.WriteLine(AddingInts(x, y));
            //Console.WriteLine(MultipInts(x, y));
            //Console.WriteLine(SubInts(x,y));
            //Console.WriteLine(DivInts(x,y));
            #endregion


        }
    }
}
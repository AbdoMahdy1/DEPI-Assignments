using System;
using System.Linq;
using System.Collections;
using static Day02.ListGenerators;
using System.ComponentModel;

namespace Day02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Restriction-Operators
            //var OutOfStock = ProductList.Where((P) => P.UnitsInStock == 0);
            //foreach (var Product in OutOfStock)
            //{
            //    Console.WriteLine(Product);
            //}

            //var InStockAndCost = ProductList.Where((P) => P.UnitsInStock > 0 && P.UnitPrice > 3);
            //foreach (var Product in InStockAndCost)
            //{
            //    Console.WriteLine(Product);
            //}

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var String = Arr.Where((I) => I.Length < Array.IndexOf(Arr, I));
            //foreach(var Product in String)
            //{
            //    Console.WriteLine(Product);
            //}
            #endregion

            #region Element-Operators
            //var FirstOutStock = ProductList.First((p) => p.UnitsInStock == 0);
            //   Console.WriteLine(FirstOutStock);


            //var PriceOver = ProductList.FirstOrDefault((P) => P.UnitPrice > 1000);
            //Console.WriteLine(PriceOver);

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int SecondGreaterThanFive = Arr.Where((I) => I > 5)
            //                                .Skip(1)
            //                                .First();
            //Console.WriteLine(SecondGreaterThanFive);
            #endregion

            #region Aggrgate-Operators
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int NumOfOdds = Arr.Count(I => I % 2 == 1);
            //Console.WriteLine(NumOfOdds);

            //var Customers = CustomerList.Select((C) => new {C.Name, NumOfOrders = C.Orders.Length});
            //foreach(var Customer in Customers)
            //{
            //    Console.WriteLine(Customer);
            //}

            //var ProCategory = ProductList.GroupBy(P => P.Category)
            //                                .Select(G => new { Category = G.Key, NumofProducts = G.Count() });
            //foreach (var item in ProCategory)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int SumOfArr = Arr.Sum();
            //Console.WriteLine(SumOfArr);

            //var InStockPerCate = ProductList.Where(P => P.UnitsInStock != 0)
            //                                .GroupBy(P => P.Category)
            //                                .Select(G => new { Category = G.Key, InStock = G.Count() });
            //foreach (var item in InStockPerCate)
            //{
            //    Console.WriteLine(item);
            //}

            //var CheapPerCate = ProductList.GroupBy(P => P.Category)
            //                                .Select((G) => new { Category = G.Key, Cheapest = G.Min(P => P.UnitPrice) });
            //foreach (var Prod in CheapPerCate)
            //{
            //    Console.WriteLine(Prod);
            //}
            //Console.WriteLine();

            //var MostPrice = ProductList.GroupBy(P => P.Category)
            //                            .Select(G => new { Category = G.Key, MostExpensive = G.Max(P => P.UnitPrice) });
            //foreach (var Prod in MostPrice)
            //{
            //    Console.WriteLine(Prod);
            //}
            //Console.WriteLine();

            //var AvgPrice = ProductList.GroupBy(P => P.Category)
            //                            .Select(G => new { Category = G.Key, AveragePrice = G.Average(P => P.UnitPrice) });
            //foreach (var Prod in AvgPrice)
            //{
            //    Console.WriteLine(Prod);
            //}
            #endregion

            #region Ordering-Operators
            //var SortedProducts = ProductList.OrderBy(P => P.ProductName)
            //                                .Select(P => new {P.ProductName});
            //foreach (var product in SortedProducts)
            //{
            //    Console.WriteLine(product);
            //}


            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //Array.Sort(Arr, new InsensitiveComparer());
            //foreach (string str in Arr)
            //{
            //    Console.WriteLine(str);
            //}


            //var ProdFromHighest = ProductList.OrderByDescending(P => P.UnitsInStock)
            //                                    .Select(P => new { P.ProductName, P.UnitsInStock});
            //foreach( var prod in ProdFromHighest)
            //{
            //    Console.WriteLine(prod);
            //}


            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Sorted = Arr.OrderBy(X => X.Length)
            //                .ThenBy(X => X);
            //foreach ( var x in Sorted)
            //{
            //    Console.WriteLine(x);
            //}


            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var SortedArr = Arr.OrderBy(x => x.Length)
            //                   .ThenBy(x => x, new InsensitiveComparer());
            //foreach (var x in SortedArr)
            //{
            //    Console.WriteLine(x);
            //}


            //var SortedProd = ProductList.OrderBy(P => P.Category)
            //                            .ThenByDescending(P => P.UnitPrice)
            //                            .Select(P => new { P.ProductName, P.Category, P.UnitPrice });
            //foreach (var item in SortedProd)
            //{
            //    Console.WriteLine(item);
            //}


            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var SortedArr = Arr.OrderBy(x => x.Length)
            //                   .ThenByDescending(x => x, new InsensitiveComparer());
            //foreach (var x in SortedArr)
            //{
            //    Console.WriteLine(x);
            //}


            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var ArrList = Arr.Reverse()
            //                    .Where((W) => W[1] == 'i');
            //foreach (var W in ArrList)
            //{
            //    Console.WriteLine(W);
            //}

            #endregion

            #region Transforming-Operators
            //var Products = ProductList.Select(P => P.ProductName);
            //foreach (var Product in Products)
            //{
            //    Console.WriteLine(Product);
            //}


            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var List = words.Select(w => new { Lower = w.ToLower(), Upper = w.ToUpper() });
            //foreach(var word in List)
            //{
            //    Console.WriteLine(word);
            //}


            //var List = ProductList.Select(P => new { P.ProductName, Price = P.UnitPrice });
            //foreach (var item in List)
            //{
            //    Console.WriteLine(item);
            //}


            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var EqualIndex = Arr.Select((Item, index) => new { Number = Item, Equal = Item == index });
            //foreach (var item in EqualIndex)
            //{
            //    Console.WriteLine($"{item.Number}: {item.Equal}");
            //}


            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var Pairs = from a in numbersA
            //            from b in numbersB
            //            where a < b
            //            select (new { A = a, B = b });
            //foreach (var P in Pairs)
            //{
            //    Console.WriteLine($"{P.A} is less than {P.B}");
            //}


            //var orders = CustomerList.Select(C => new { Orders = C.Orders.Where(o => o.Total < 500).Select(o => new { o.Id, o.Total })  });
            //foreach (var order in orders)
            //{
            //    foreach (var item in order.Orders)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}


            //var orders = CustomerList.Select(C => new { Orders = C.Orders.Where(o => o.OrderDate >= new DateTime(1998, 01, 01)).Select(o => new { o.Id, o.OrderDate })  });
            //foreach (var order in orders)
            //{
            //    foreach (var item in order.Orders)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion

            #region Partitioning
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var arr = Arr.TakeWhile(I => I >= Array.IndexOf(Arr, I));
            //foreach ( var i in arr )
            //{
            //    Console.WriteLine(i);
            //}


            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var arr = Arr.SkipWhile(I => I % 3 != 0);
            //foreach (var i in arr)
            //{
            //    Console.WriteLine(i);
            //}


            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var arr = Arr.SkipWhile(I => I >= Array.IndexOf(Arr, I));
            //foreach (var i in arr)
            //{
            //    Console.WriteLine(i);
            //}


            #endregion

            #region Quantifiers
            //var list = ProductList.GroupBy(P => P.Category)
            //                        .Where(G => G.Any(P => P.UnitsInStock == 0))
            //                        .Select(G => new {G.Key, Products = G.ToList()});
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //    foreach(var Prod in  item.Products)
            //    {
            //        Console.WriteLine(Prod);
            //    }
            //}


            //var list2 = ProductList.GroupBy(P => P.Category)
            //                        .Where(G => G.All(P => P.UnitsInStock > 0))
            //                        .Select(G => new {G.Key, Products = G.ToList()});
            //Console.WriteLine();
            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //    foreach(var Prod in  item.Products)
            //    {
            //        Console.WriteLine(Prod);
            //    }
            //}
            #endregion
        }
    }

    class InsensitiveComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
        }
    }
}
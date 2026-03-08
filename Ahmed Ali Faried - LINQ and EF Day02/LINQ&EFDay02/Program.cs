using System;
using System.Collections;
using System.Collections.Generic;
using day10_G01;
using System.Linq;
using static day10_G01.ListGenerators;
using System.Reflection.Metadata.Ecma335;
using System.Net.WebSockets;
using System.Threading;
using System.Security.Cryptography;

namespace LINQ_EFDay01
{
    internal class Program
    {
        static void Main()
        {
            #region Restriction Operators
            //var Res01 = ProductList.Where((P) => P.UnitsInStock == 0);
            //var Res02 = ProductList.Where((P) => P.UnitsInStock > 0 && P.UnitPrice > 3);
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight","nine" };
            //var Res03 = Arr.Select((A, I) => new { Name = A, Value = I })
            //               .Where((A) => A.Name.Length < A.Value);

            //foreach (var item in Res02)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Element Operators
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Res01 = ProductList.FirstOrDefault((P) => P.UnitsInStock == 0);
            //var Res02 = ProductList.FirstOrDefault((P) => P.UnitPrice > 1000);
            //var Res03 = Arr.Where(x => x > 5)
            //               .Skip(1)
            //               .First();

            //Console.WriteLine(Res01);
            //Console.WriteLine(Res02?.ProductName ?? "NA");
            //Console.WriteLine(Res03);
            #endregion

            #region Aggregate Operators
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            var Res01 = Arr.Where((A) => A % 2 == 1).Count();
            var Res02 = CustomerList.Select((C) => new { customers = C.Name, ordercount = C.Orders.Count() });
            var Res03 = ProductList.GroupBy((P) => P.Category)
                                   .Select((P) => new { Categories = P.Key, Productcount = P.Count() });
            var Res04 = Arr.Sum();
            //var Res05 = words.Sum(w => w.Length);
            //Console.WriteLine(totalChars);
            var Res06 = ProductList.GroupBy(p => p.Category)
                                 .Select(g => new
                                 {
                                     Category = g.Key,
                                     TotalUnits = g.Sum(p => p.UnitsInStock)
                                 });
            //var Res07 = words.Min(w => w.Length);
            //Console.WriteLine(shortest);
            var Res08 = ProductList.GroupBy(p => p.Category)
                                    .Select(g => new
                                    {
                                        Category = g.Key,
                                        CheapestPrice = g.Min(p => p.UnitPrice)
                                    });
            var Res09 =
                from p in ProductList
                group p by p.Category into g
                let minPrice = g.Min(p => p.UnitPrice)
                from p in g
                where p.UnitPrice == minPrice
                select p;
            //var Res10 = words.Max(w => w.Length);
            //Console.WriteLine(longest);
            var Res11 = ProductList.GroupBy(p => p.Category)
                                    .Select(g => new
                                    {
                                        Category = g.Key,
                                        MaxPrice = g.Max(p => p.UnitPrice)
                                    });
            var Res12 = ProductList.GroupBy(p => p.Category)
                                   .SelectMany(g => g.Where(p => p.UnitPrice == g.Max(x => x.UnitPrice)));
            //var Res13 = words.Average(w => w.Length);
            //Console.WriteLine(avgLength);
            var Res14 = ProductList.GroupBy((P) => P.Category)
                .Select((P) => new
                {
                    Avgprice = P.Average((P) => P.UnitPrice),
                    Category = P.Key
                });

            Console.WriteLine(Res04);
            foreach (var item in Res14)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Ordering Operators
            //var Ord01 = ProductList.OrderBy((P) => P.ProductName);
            //string[] ArrOrd02 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Ord02 = ArrOrd02.OrderBy((W) => W, StringComparer.OrdinalIgnoreCase);
            //var Ord03 = ProductList.OrderByDescending((P) => P.UnitsInStock);
            //string[] ArrOrd04 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Ord04 = ArrOrd04.OrderBy((W) => W.Length)
            //                    .ThenBy((W) => W);
            //string[] ArrOrd05 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Ord05 = ArrOrd05.OrderBy((W) => W.Length)
            //                    .ThenBy((W) => W, StringComparer.OrdinalIgnoreCase);
            //var Ord06 = ProductList.OrderBy((P) => P.Category)
            //                       .ThenByDescending((P) => P.UnitPrice);
            //string[] ArrOrd07 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Ord07 = ArrOrd07.OrderBy((W) => W.Length)
            //                    .ThenByDescending((W) => W, StringComparer.OrdinalIgnoreCase);
            //string[] ArrOrd08 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Ord08 = ArrOrd08.Where((W) => W.Length >= 2 && W[1] == 'i')
            //                    .Reverse();

            //foreach (var item in Ord08)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Transformation Operators
            //var Trans01 = ProductList.Select((P) => P.ProductName);
            //string[] ArrTrans02 = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var Trans02 = ArrTrans02.Select((W) => new { Upper = W.ToUpper(), Lower = W.ToLower() });
            //var Trans03 = ProductList.Select((P) => new
            //                         {
            //                             P.ProductName,
            //                             P.Category,
            //                             Price = P.UnitPrice,
            //                             P.UnitsInStock
            //                         });
            //int[] ArrTrans04 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Trans04 = ArrTrans04.Select((N, I) => new { Number = N, InPlace = (N == I) });
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var Trans05 = numbersA.SelectMany((A) => numbersB.Where((B) => A < B)
            //                                                 .Select((B) => new { A, B }));
            //var Trans06 = CustomerList.SelectMany((C) => C.Orders)
            //                          .Where((O) => O.Total < 500.00);
            //var Trans07 = CustomerList.SelectMany((C) => C.Orders)
            //                          .Where((O) => O.OrderDate.Year >= 1998);

            //foreach (var item in Trans07)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Partitioning Operators
            //var Part01 = CustomerList.Where((C) => C.City == "Washington")
            //                         .SelectMany((C) => C.Orders)
            //                         .Take(3);
            //var Part02 = CustomerList.Where((C) => C.City == "Washington")
            //                         .SelectMany((C) => C.Orders)
            //                         .Skip(2);
            //int[] numbersPart03 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Part03 = numbersPart03.TakeWhile((N, I) => N >= I);
            //int[] numbersPart04 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Part04 = numbersPart04.SkipWhile((N) => N % 3 != 0);
            //int[] numbersPart05 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Part05 = numbersPart05.SkipWhile((N, I) => N >= I);

            //foreach (var item in Part05)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Quantifiers
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var Quant01 = words.Any((W) => W.Contains("ei"));
            //Console.WriteLine(Quant01);
            //var Quant02 = ProductList.GroupBy((P) => P.Category)
            //                         .Where((G) => G.Any((P) => P.UnitsInStock == 0));
            //var Quant03 = ProductList.GroupBy((P) => P.Category)
            //                         .Where((G) => G.All((P) => P.UnitsInStock > 0));

            //foreach (var group in Quant03)
            //{
            //    Console.WriteLine($"Category: {group.Key}");
            //    foreach (var item in group)
            //        Console.WriteLine($"  {item}");
            //}
            #endregion
        }
    }
}

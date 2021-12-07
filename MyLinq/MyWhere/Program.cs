using System;
using System.Collections.Generic;
using System.Linq;

namespace MyWhere
{
    static class Program
    {
        static IEnumerable<T> MyWhere<T>(this IEnumerable<T> items, Func<T, bool> predicate)
        {
            var result = new List<T>();
            foreach (var item in items)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }
        static IEnumerable<TResult> MySelect<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            var result = new List<TResult>();
            foreach (var item in source)
            {
                var convertedItem = selector(item);
                result.Add(convertedItem);
            }

            return result;
        }


        static void Main(string[] args)
        {
            var source = new int[5] { 1, 2, 3, 4, 5 };
            var result = source.Select(x => x > 2);
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace Main
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
        static IEnumerable<TResult> MySelectMany<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
        {
            var result = new List<TResult>();
            foreach (var item in source)
            {
                var convertedItems = selector(item);
                result.AddRange(convertedItems);
            }

            return result;
        }

        static void Main()
        {
        }
    }
}
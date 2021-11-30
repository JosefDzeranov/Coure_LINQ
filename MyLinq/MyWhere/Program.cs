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

        static void Main(string[] args)
        {
            var source = new int[5] {1, 2, 3, 4, 5};
            var result = source.Where(x => x > 2);
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
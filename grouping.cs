
using System;
using System.Linq;

namespace VS2026Handbook_Ch12
{
    internal class grouping
    {
        static void Main(string[] args)
        {
            var items = new[]
            {
                (Category: "Books", Qty: 4),
                (Category: "Pens", Qty: 8),
                (Category: "Books", Qty: 3)
            };

            foreach (var g in items.GroupBy(x => x.Category))
            {
                Console.WriteLine(
                    $"{g.Key}: {g.Sum(x => x.Qty)}");
            }
        }
    }
}


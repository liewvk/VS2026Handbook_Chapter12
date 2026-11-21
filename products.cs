
using System;
using System.Collections.Generic;
using System.Linq;

namespace VS2026Handbook_Ch12
{
    internal class products
    {
        static void Main(string[] args)
        {
            var products = new List<(string Name, decimal Price)>
            {
                ("Notebook", 8.50m),
                ("Pen", 1.20m),
                ("Folder", 5.00m)
            };

            var expensive = products
                .Where(p => p.Price >= 5m)
                .OrderBy(p => p.Name);

            foreach (var product in expensive)
            {
                Console.WriteLine(
                    $"{product.Name}: {product.Price:F2}");
            }
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;

namespace VS2026Handbook_Ch12
{
    internal class prices
    {
        static void Main(string[] args)
        {
            var prices = new Dictionary<string, double>
            {
                ["Keyboard"] = 69.90,
                ["Mouse"] = 25.00,
                ["Monitor"] = 499.00,
                ["USB hub"] = 44.00
            };

            foreach (var item in prices
                .Where(p => p.Value >= 50)
                .OrderBy(p => p.Value))
            {
                Console.WriteLine(
                    $"{item.Key}: RM{item.Value:F2}");
            }
        }
    }
}


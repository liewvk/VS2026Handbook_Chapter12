
using System;
using System.Linq;

namespace VS2026Handbook_Ch12
{
    internal class values
    {
        static void Main(string[] args)
        {
            decimal[] values = { 125m, 230m, 90m };

            Console.WriteLine($"Total: {values.Sum():F2}");

            Console.WriteLine($"Average: {values.Average():F2}");

            foreach (var value in values.Where(v => v > 100m))
            {
                Console.WriteLine(
                    $"Above threshold: {value:F2}");
            }
        }
    }
}


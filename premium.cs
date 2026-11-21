
using System;
using System.Linq;

namespace VS2026Handbook_Ch12
{
    internal class premium
    {
        static void Main(string[] args)
        {
            decimal[] prices = { 9m, 25m, 48m, 7m };

            var premium = prices.Where(p => p >= 20m);

            Console.WriteLine(string.Join(", ", premium));
        }
    }
}


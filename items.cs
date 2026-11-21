
using System;
using System.Linq;

namespace VS2026Handbook_Ch12
{
    internal class items
    {
        static void Main(string[] args)
        {
            var items = new (string Name, decimal Price)[]
            {
                ("Python", 250.0m),
                ("C#", 290.0m),
                ("AI", 420.0m)
            };

            foreach (var item in items)
            {
                Console.WriteLine(
                    $"{item.Name,-20} RM{item.Price,8:F2}");
            }

            Console.WriteLine(
                $"Subtotal: RM{items.Sum(x => x.Price):F2}");

            Console.WriteLine(
                $"Largest cost: {items.MaxBy(x => x.Price)!.Name}");
        }
    }
}
   

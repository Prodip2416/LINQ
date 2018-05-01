using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantifiersInLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //var result = numbers.All(x => x < 10);

            //Console.WriteLine(result);

            //int[] numbers = { 1, 2, 3, 4, 5 };

            //var result = numbers.Any(x => x < 10);

            //Console.WriteLine(result);

            int[] numbers = { 1, 2, 3, 4, 5 };

            var result = numbers.Contains(6);

            Console.WriteLine(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerationOperatorsInLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //var evenNumbers = Enumerable.Range(1, 10).Where(x => x%2 == 0);

            //foreach (int i in evenNumbers)
            //{
            //    Console.WriteLine(i);
            //}

            //var evenNumbers = Enumerable.Repeat("Prodip", 5);

            //foreach (var i in evenNumbers)
            //{
            //    Console.WriteLine(i);
            //}

            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 1, 4, 5 };

            var result = numbers1.Concat(numbers2);
         //   var result = numbers1.Union(numbers2);
            foreach (var v in result)
            {
                Console.WriteLine(v);
            }


        }
    }
}

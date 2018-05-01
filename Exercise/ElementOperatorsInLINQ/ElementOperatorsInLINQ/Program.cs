using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementOperatorsInLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9};

            //var a = numbers.First();
            //Console.WriteLine(a);

            //  Console.WriteLine("-------------------------");
            //int[] numbers = { };

            //var a = numbers.First();
            //Console.WriteLine(a);

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var a = numbers.FirstOrDefault();
            //Console.WriteLine(a);

            //int[] numbers = { };

            //var a = numbers.FirstOrDefault();
            //Console.WriteLine(a);

            Console.WriteLine("--------Last and Last& Default----------------");

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var a = numbers.Last();
            //Console.WriteLine(a);

            //int[] numbers = { };

            //var a = numbers.Last();
            //Console.WriteLine(a);

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var a = numbers.LastOrDefault();
            //Console.WriteLine(a);

            //int[] numbers = {  };

            //var a = numbers.LastOrDefault();
            //Console.WriteLine(a);

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 ,9};

            //var a = numbers.LastOrDefault(x=>x%2==0);         // you can apply condition
            //Console.WriteLine(a);

            //System.Console.WriteLine("----------Element and ElementAt ---------------");

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var a = numbers.ElementAt(5);
            //Console.WriteLine(a);

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var a = numbers.ElementAt(50);
            //Console.WriteLine(a);

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var a = numbers.ElementAtOrDefault(5);
            //Console.WriteLine(a);

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var a = numbers.ElementAtOrDefault(50);
            //Console.WriteLine(a);


            // First() , Last(), ElementAt() thro an exception but FirstOrDefault(), LastOrDefault() , ElementAtOrDefault() never thro an exception


            //int[] numbers = {  };
            //var a = numbers.Single();
            //Console.WriteLine(a);

            //int[] numbers = { };
            //var a = numbers.SingleOrDefault();
            //Console.WriteLine(a);

            int[] numbers = { };
            var a = numbers.DefaultIfEmpty();

            foreach (var i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}

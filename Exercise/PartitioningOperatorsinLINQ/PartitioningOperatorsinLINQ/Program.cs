using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartitioningOperatorsinLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] countries = { "Australia", "Canada", "Germany", "US", "India", "UK", "Italy" };

            // take only first 3 element............
            //IEnumerable<string> result = countries.Take(3);
            //foreach (string s in result)
            //{
            //    Console.WriteLine(s);
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            // Skip 1st 3 element...........
            //IEnumerable<string> results = countries.Skip(3);
            //foreach (string s in results)
            //{
            //    Console.WriteLine(s);
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            // when condition is true than stop

            IEnumerable<string> results1 = countries.TakeWhile(s=>s.Length>2);
            foreach (string s in results1)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            Console.WriteLine();

            // when condition is true than start take....
            IEnumerable<string> results2 = countries.SkipWhile(s => s.Length > 2);
            foreach (string s in results2)
            {
                Console.WriteLine(s);
            }

        }
    }
}

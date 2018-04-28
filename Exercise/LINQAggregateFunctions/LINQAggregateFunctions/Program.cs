using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAggregateFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] countries = {"USA", "BD", "UK", "Canada", "Indian"};

            string result = countries.Aggregate((a, b) => a + "," + b);
            Console.WriteLine(result);

            // SUM()...MIN(),,,,MAX(),,,Average(),,,,COunt().....Aggreate()....
        }
    }
}

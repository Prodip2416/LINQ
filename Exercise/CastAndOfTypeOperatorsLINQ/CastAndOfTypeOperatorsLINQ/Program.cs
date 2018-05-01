using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastAndOfTypeOperatorsLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList num= new ArrayList();
            num.Add(1);
            num.Add(2);
            num.Add(3);
            num.Add("ABC");

            //IEnumerable<int> a = num.Cast<int>();

            //foreach (int i in a)
            //{
            //    Console.WriteLine(i);
            //}

            // Cast write exception when can not convert match data type
            // but OfType not thro exception 

            IEnumerable<int> a = num.OfType<int>();
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupByInLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
          //  var employees = Employee.GetAllEmployees().GroupBy(x => x.Department);

            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee.Key+" - "+employee.Count());
            //    Console.WriteLine("-------------");
            //    Console.WriteLine();
            //    foreach (var employee1 in employee)
            //    {
            //        Console.WriteLine(employee1.Name + " - "+employee1.Department);
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}


            var group = Employee.GetAllEmployees()
                .GroupBy(x => new {x.Department, x.Gender})
                .OrderBy(g => g.Key.Department)
                .ThenBy(g => g.Key.Gender)
                .Select(g => new
                {
                    dept=g.Key.Department,
                    gender=g.Key.Gender,
                    Employees=g.OrderBy(x=>x.Name)
                });


            foreach (var a in group)
            {
                Console.WriteLine("{0} department in {1} employees and count {2}",a.dept,a.gender,a.Employees.Count());
                Console.WriteLine("---------------------------------------------------");
                foreach (var g in a.Employees)
                {
                    Console.WriteLine(g.Name+"\t"+g.Gender+"\t"+g.Department);   
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}

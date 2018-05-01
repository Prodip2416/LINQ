using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AsEnumerableAndAsQueryableinLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
           DataClassesDataContext db = new DataClassesDataContext();

            var emp = db.Employees.Where(x => x.Gender=="Male").OrderByDescending(x => x.Salary).Take(5);

            foreach (var employee in emp)
            {
                Console.WriteLine(employee.Name+"\t"+employee.Salary+"\t"+employee.Gender);
            }
        }
    }
}

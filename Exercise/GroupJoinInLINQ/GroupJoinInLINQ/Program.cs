using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupJoinInLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeesByDepartment = Department.GetAllDepartments()
                .GroupJoin(Employee.GetAllEmployees(),
                    d => d.ID,
                    e => e.DepartmentID,
                    (dept, emp) => new
                    {
                        Department=dept,
                        Employee=emp
                    });


            foreach (var department in employeesByDepartment)
            {
                Console.WriteLine(department.Department.Name);
                foreach (var a in department.Employee)
                {
                    Console.WriteLine("  "+a.Name);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}

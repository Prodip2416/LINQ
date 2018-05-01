using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionOperatorsInLINQ
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }
    }

    class Employee
    {
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string City { get; set; }        
    }
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> countries = new List<string> { "US", "India", "UK", "Australia", "Canada" };

            //string[] result = (from c in countries orderby c ascending select c).ToArray();

            //foreach (string str in result)
            //{
            //    Console.WriteLine(str);
            //}

            //List<Student> listStudents = new List<Student>
            //{
            //    new Student { StudentID= 101, Name = "Tom", TotalMarks = 800 },
            //    new Student { StudentID= 102, Name = "Mary", TotalMarks = 900 },
            //    new Student { StudentID= 103, Name = "Pam", TotalMarks = 800 }
            //};

            //Dictionary<int, string> result = listStudents.ToDictionary(x => x.StudentID, x => x.Name);

            //foreach (KeyValuePair<int, string> kvp in result)
            //{
            //    Console.WriteLine(kvp.Key + " " + kvp.Value);
            //}

            //

            List<Employee> listEmployees = new List<Employee>
            {
                new Employee() { Name = "Ben", JobTitle = "Developer", City = "London" },
                new Employee() { Name = "John", JobTitle = "Sr. Developer", City = "Bangalore" },
                new Employee() { Name = "Steve", JobTitle = "Developer", City = "Bangalore" },
                new Employee() { Name = "Stuart", JobTitle = "Sr. Developer", City = "London" },
                new Employee() { Name = "Sara", JobTitle = "Developer", City = "London" },
                new Employee() { Name = "Pam", JobTitle = "Developer", City = "London" }
            };

            // Group employees by JobTitle
            var employeesByJobTitle = listEmployees.ToLookup(x => x.JobTitle);

            Console.WriteLine("Employees Grouped By JobTitle");
            foreach (var kvp in employeesByJobTitle)
            {
                Console.WriteLine(kvp.Key);
                // Lookup employees by JobTitle
                foreach (var item in employeesByJobTitle[kvp.Key])
                {
                    Console.WriteLine("\t" + item.Name + "\t" + item.JobTitle + "\t" + item.City);
                }
            }

            Console.WriteLine(); Console.WriteLine();

            // Group employees by City
            var employeesByCity = listEmployees.ToLookup(x => x.City);

            Console.WriteLine("Employees Grouped By City");
            foreach (var kvp in employeesByCity)
            {
                Console.WriteLine(kvp.Key);
                // Lookup employees by City
                foreach (var item in employeesByCity[kvp.Key])
                {
                    Console.WriteLine("\t" + item.Name + "\t" + item.JobTitle + "\t" + item.City);
                }
            }
        }
    }
    }


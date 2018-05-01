using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQqueryDeferredExecution
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listStudents = new List<Student>
            {
                new Student { StudentID= 101, Name = "Tom", TotalMarks = 800 },
                new Student { StudentID= 102, Name = "Mary", TotalMarks = 900 },
                new Student { StudentID= 103, Name = "Pam", TotalMarks = 800 }
            };

            // Since we are using Count() operator, the LINQ Query is executed at this point
            int result = (from student in listStudents
                          where student.TotalMarks == 800
                          select student).Count();

            // Adding a new student object with TotalMarks = 800 to the source
            // will have no effect on the result as the query is already executed
            listStudents.Add(new Student { StudentID = 104, Name = "Tim", TotalMarks = 800 });

            // The above query is executed at the point where it is defined.
            // This is proved as Tim is not included in the count
            Console.WriteLine("Students with Total Marks = 800 : " + result);
        }
    }
        public class Student
        {
            public int StudentID { get; set; }
            public string Name { get; set; }
            public int TotalMarks { get; set; }
        }
    }

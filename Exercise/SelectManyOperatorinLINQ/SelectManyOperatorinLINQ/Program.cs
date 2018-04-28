using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectManyOperatorinLINQ
{
   public class Program
    {
        static void Main(string[] args)
        {
            //var result = from student in Student.GetAllStudetns()
            //             from subject in student.Subjects
            //             select new { StudnetName = student.Name, Subject = subject };

            //foreach (var v in result)
            //{
            //    Console.WriteLine(v.StudnetName + " - " + v.Subject);
            //}

            var result = Student.GetAllStudetns().SelectMany(s => s.Subjects, (a, b) =>
                             new { StudentName = a.Name, Subject = b });

            foreach (var v in result)
            {
                Console.WriteLine(v.StudentName + " - " + v.Subject);
            }
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public List<string> Subjects { get; set; }

        public static List<Student> GetAllStudetns()
        {
            List<Student> listStudents = new List<Student>
        {
            new Student
            {
                Name = "Tom",
                Gender = "Male",
                Subjects = new List<string> { "ASP.NET", "C#" }
            },
            new Student
            {
                Name = "Mike",
                Gender = "Male",
                Subjects = new List<string> { "ADO.NET", "C#", "AJAX" }
            },
            new Student
            {
                Name = "Pam",
                Gender = "Female",
                Subjects = new List<string> { "WCF", "SQL Server", "C#" }
            },
            new Student
            {
                Name = "Mary",
                Gender = "Female",
                Subjects = new List<string> { "WPF", "LINQ", "ASP.NET" }
            },
        };

            return listStudents;
        }
    }
}

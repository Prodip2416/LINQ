using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace OrderingOperatorinLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Student> students = Student.GetAllStudents().OrderBy(x => x.Name);

            foreach (var student in students)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine();
            Console.WriteLine("--------------DESC-----------------");
            Console.WriteLine();

            IEnumerable<Student> result = Student.GetAllStudents().OrderByDescending(s => s.Name);
            foreach (Student student in result)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }

        public static List<Student> GetAllStudents()
        {
            List<Student> listStudents = new List<Student>
        {
            new Student
            {
                StudentID= 101,
                Name = "Tom",
                TotalMarks = 800
            },
            new Student
            {
                StudentID= 102,
                Name = "Mary",
                TotalMarks = 900
            },
            new Student
            {
                StudentID= 103,
                Name = "Valarie",
                TotalMarks = 800
            },
            new Student
            {
                StudentID= 104,
                Name = "John",
                TotalMarks = 800
            },
        };

            return listStudents;
        }
    }
}

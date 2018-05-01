using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingOperatorsLINQ_II
{
    class Program
    {
        static void Main(string[] args)
        {
            IOrderedEnumerable<Student> result=Student.GetAllStudetns().OrderBy(s => s.TotalMarks).ThenBy(s => s.Name).ThenByDescending(s => s.StudentID);
            foreach (var student in result)
            {
                Console.WriteLine(student.TotalMarks+"\t"+student.Name+"\t"+student.StudentID);
            }
            Console.WriteLine();
            Console.WriteLine();

            IEnumerable<Student> students = result.Reverse();
            
            foreach (var student in students)
            {
                Console.WriteLine(student.TotalMarks + "\t" + student.Name + "\t" + student.StudentID);
            }
        }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }

        public static List<Student> GetAllStudetns()
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
                Name = "Pam",
                TotalMarks = 800
            },
            new Student
            {
                StudentID= 104,
                Name = "John",
                TotalMarks = 800
            },
            new Student
            {
                StudentID= 105,
                Name = "John",
                TotalMarks = 800
            },
        };

            return listStudents;
        }
    }

}

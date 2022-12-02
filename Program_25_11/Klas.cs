using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_25_11
{
    internal class Klas
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[3];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student("Fero");
            }  

            Console.WriteLine(students[0].gradeAverage());
            Console.WriteLine(students[1].gradeAverage());
            Console.WriteLine(students[2].gradeAverage());
            Console.ReadKey();
        }
    }
}

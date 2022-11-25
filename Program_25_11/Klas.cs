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
            Student student = new Student();
            student.name = "sheit";

            Console.WriteLine(student.gradeAverage());
            Console.ReadKey();
        }
    }
}

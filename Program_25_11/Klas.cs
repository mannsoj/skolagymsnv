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
            Student Fero = new Student("Fero",1,3);
            Student Marek = new Student("Marek",1,5);
            Student Jano = new Student("Jano");

            Console.WriteLine(Fero.gradeAverage());
            Console.WriteLine(Marek.gradeAverage());
            Console.WriteLine(Jano.gradeAverage());
            Console.ReadKey();
        }
    }
}

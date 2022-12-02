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

            students[1].Constructor("Jano",1,2,3);
            students[2].Constructor("Augustin",2,3,4);



            //dú1 ziak fero ma z predmetu fyz znamky x,y,z
            //alebo vytvorit tabulku?

            //dú2 vypiste kazdeho ziaka z kazdeho predmetu aj celkovo, celkovy priemer vsetkych zo vsetkych znamok 


            Console.WriteLine(students[0].gradeAverage());
            Console.WriteLine(students[1].gradeAverage());
            Console.WriteLine(students[2].gradeAverage());
            Console.ReadKey();
        }
    }
}

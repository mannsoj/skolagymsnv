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
            students[1].Constructor("Jano", 1, 2, 3, 1, 2, 3, 1, 2, 3);


            double classChemistryAverage()
            {
                double avrg = 0;
                foreach(Student student in students)
                {
                   avrg += student.ChemistryAverage();
                }
                return avrg;
            }
            double classPhysicsAverage()
            {
                double avrg = 0;
                foreach (Student student in students)
                {
                    avrg += student.PhysicsAverage();
                }
                return avrg;
            }
            double classMathAverage()
            {
                double avrg = 0;
                foreach (Student student in students)
                {
                    avrg += student.MathAverage();
                }
                return avrg;
            }
            double classAverage()
            {
                double avrg = 0;
                foreach (Student student in students)
                {
                    avrg += student.getAverage();
                }
                return avrg;
            }


            Console.WriteLine(students[1].ChemistryAverage());
            Console.WriteLine(students[1].PhysicsAverage());
            Console.WriteLine(students[1].MathAverage());
            Console.WriteLine(students[1].getAverage());
            Console.WriteLine(classAverage());
            Console.WriteLine(classMathAverage());
            Console.WriteLine(classPhysicsAverage());
            Console.WriteLine(classChemistryAverage());


            //dú1 ziak fero ma z predmetu fyz znamky x,y,z
            //alebo vytvorit tabulku?

            //dú2 vypiste kazdeho ziaka z kazdeho predmetu aj celkovo, celkovy priemer vsetkych zo vsetkych znamok 


            //daco co sven urobil 
            //CZiak[] ziaci2 = {new CZiak("xy"),new CZiak("xy"),new CZiak("xy")};


            Console.ReadKey();
        }
    }
}

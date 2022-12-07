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
                students[i] = new Student();
            }

            students[0].Constructor("Alica", 3, 4, 5, 3, 4, 5, 3, 4, 5);
            students[1].Constructor("Jano", 1, 2, 3, 1, 2, 3, 1, 2, 3);
            students[2].Constructor("Marek", 1, 2, 3, 3, 2, 5, 4, 3, 2);


            double classChemistryAverage()
            {
                double avrg = 0;
                foreach(Student student in students)
                {
                  avrg += student.ChemistryAverage();
                }
                return avrg / students.Length;
            }
            double classPhysicsAverage()
            {
                double avrg = 0;
                foreach (Student student in students)
                {
                    avrg += student.PhysicsAverage();
                }
                return avrg / students.Length;
            }
            double classMathAverage()
            {
                double avrg = 0;
                foreach (Student student in students)
                {
                    avrg += student.MathAverage();
                }
                return avrg / students.Length;
            }
            double classAverage()
            {
                double avrg = 0;
                foreach (Student student in students)
                {
                    avrg += student.getAverage();
                }
                return avrg / students.Length;
            }



            //dú1 ziak fero ma z predmetu fyz znamky x,y,z
            //alebo vytvorit tabulku?
            Console.WriteLine("{0,30}\n", "ZNÁMKY");
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}\n", "Meno" , "Chémia", "Fyzika", "Matematika");
            for (int ctr = 0; ctr < students.Length; ctr++)
                Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}", students[ctr].studentName, students[ctr].ChemGrades(), students[ctr].PhysGrades(), students[ctr].MathGrades());

            //dú2 vypiste kazdeho ziaka z kazdeho predmetu aj celkovo, celkovy priemer vsetkych zo vsetkych znamok 
            Console.WriteLine("\n\n{0,40}\n", "PRIEMERY ZNÁMOK");
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}\n", "Meno", "Chémia", "Fyzika", "Matematika");
            for (int ctr = 0; ctr < students.Length; ctr++)
                Console.WriteLine("{0,-20} {1,-20} {2,-20} {3,-20}", students[ctr].studentName, students[ctr].ChemistryAverage(), students[ctr].PhysicsAverage(), students[ctr].MathAverage());

            Console.WriteLine($"\nCelkový priemer z Chémie bol {classChemistryAverage()}, z Fyziky {classPhysicsAverage()}, z Matematiky {classMathAverage()} a celkový priemer celej triedy zo všetkých známok bol {classAverage()}");


            //daco co sven urobil 
            //CZiak[] ziaci2 = {new CZiak("xy"),new CZiak("xy"),new CZiak("xy")};


            Console.ReadKey();
        }
    }
}

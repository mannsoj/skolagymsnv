using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_25_11
{
    internal class Classroom
    {
        public Classroom()
        {   
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
            }

            students[0].Constructor("Alica", 3, 4, 5, 3, 4, 5, 3, 4, 5);
            students[1].Constructor("Jano", 1, 2, 3, 1, 2, 3, 1, 2, 3);
            students[2].Constructor("Marek", 1, 2, 3, 3, 2, 5, 4, 3, 2);
        }

        public int getNumberOfStudents()
        {
            return students.Length;
        }

        public double classChemistryAverage()
        {
            double avrg = 0;
            foreach (Student student in students)
            {
                avrg += student.ChemistryAverage();
            }
            return avrg / students.Length;
        }


        public double classPhysicsAverage()
        {
            double avrg = 0;
            foreach (Student student in students)
            {
                avrg += student.PhysicsAverage();
            }
            return avrg / students.Length;
        }


        public double classMathAverage()
        {
            double avrg = 0;
            foreach (Student student in students)
            {
                avrg += student.MathAverage();
            }
            return avrg / students.Length;
        }


        public double classAverage()
        {
            double avrg = 0;
            foreach (Student student in students)
            {
                avrg += student.getAverage();
            }
            return avrg / students.Length;
        }
        public Student getStudent(int l)
        {
            return students[l];
        }

        public Student[] students = new Student[3];



        public void writeGradesTable()
        {
            Console.WriteLine("{0,30}\n", "ZNÁMKY");
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}\n", "Meno", "Chémia", "Fyzika", "Matematika");
            for (int ctr = 0; ctr < getNumberOfStudents(); ctr++)
                Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}", students[ctr].studentName, students[ctr].ChemGrades(), students[ctr].PhysGrades(), students[ctr].MathGrades());
        }

        public void writeAverageTable()
        {
            Console.WriteLine("\n\n{0,40}\n", "PRIEMERY ZNÁMOK");
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}\n", "Meno", "Chémia", "Fyzika", "Matematika");
            for (int ctr = 0; ctr < getNumberOfStudents(); ctr++)
                Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}", getStudent(ctr).studentName, Math.Truncate(100 * students[ctr].ChemistryAverage()) / 100, Math.Truncate(100 * students[ctr].PhysicsAverage()) / 100, Math.Truncate(100 * students[ctr].MathAverage()) / 100);
        }

        public void writeSomething()
        {
            Console.WriteLine($"\nCelkový priemer z Chémie bol {classChemistryAverage()}, z Fyziky {classPhysicsAverage()}, z Matematiky {classMathAverage()} a celkový priemer celej triedy zo všetkých známok bol {classAverage()}");
        }

    }
}

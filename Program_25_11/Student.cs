using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_25_11
{
    internal class Student
    {
        public Student(string name,int gradeChe ,int gradePhy, int gradeMat)
        {
            for(int i = 0; i < 3; i++)
            {
                subjects[i] = new Subject();
            }
         studentName = name;
        }
        public Student(string name)
        {
            studentName = name;   
        }

        public Subject[] subjects = new Subject[3];
        
    //moznost vlozit hocijake moznstvo znamok => max 9 a kazde tri budu novy predmet
        public void Constructor(string name, params int[] grades)
        {
            for (int j = 0; j < subjects.Length; j++)
            {
            subjects[j] = new Subject();
            }
            int i = 0;
            int y = 0;
            foreach(int grade in grades)
            {
                //pole fyzika,chemia,matika => po troch sa zmeni na iny predmet
                if (i < 3)
                {
                    chemGrades[i] = grade;              
                }
                else if (i < 6)
                {
                    
                    y = i - 3;
                    physGrades[y] = grade;
                }
                else if (i < 9)
                {
                    y = i - 6;
                    mathGrades[y] = grade;
                }
                i++;
            }
            subjects[0].Constructor("Chemistry",chemGrades);
            subjects[1].Constructor("Physics",physGrades);
            subjects[2].Constructor("Math",mathGrades);

            studentName = name;
        }
        public double ChemistryAverage()
        {
            return subjects[0].getAverage();
        }
        public double PhysicsAverage()
        {
            return subjects[1].getAverage();
        }
        public void MathAverage()
        {
            Console.WriteLine(subjects[2].getAverage());
        }
        public double getAverage()
        {
            Console.WriteLine(subjects.Length);
            //( subjects[0].getAverage() + subjects[1].getAverage() + subjects[2].getAverage() ) / (double)subjects.Length
            return 2.0;
        }






        private int[] chemGrades = new int[3];
        private int[] physGrades = new int[3];
        private int[] mathGrades = new int[3];
        string studentName;
        
        

    }
}

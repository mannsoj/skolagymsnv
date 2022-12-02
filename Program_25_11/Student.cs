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
                subject[i] = new Subject();
            }
         studentName = name;
        }
        public Student(string name)
        {
            studentName = name;
    
        }

        //moznost vlozit hocijake moznstvo znamok => max 9 a kazde tri budu novy predmet
        public void Constructor(string name, int gradeChe, int gradePhy, int gradeMat)
        {
            for (int i = 0; i < 3; i++)
            {
                //pole fyzika,chemia,matika => po troch sa zmeni na iny predmet
                subject[i] = new Subject();
            }
            studentName = name;
        }

        public Subject[] subject = new Subject[3];
         string studentName;
         int gradeChem;
         int gradePhys;
        public double gradeAverage()
        {
            return (double)(gradeChem + gradePhys) / 2;
        }

    }
}

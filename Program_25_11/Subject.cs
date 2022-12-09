using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_25_11
{

    internal class Subject
    {
        public Subject(string name, int one, int two, int three)
        {
            subjectname = name;
            grades[0] = one;
            grades[1] = two;
            grades[3] = three;
        }
        public Subject()
        {

        }

        //zadaj
        public void Constructor(string name, int[] grds)
        {
            subjectname = name;
            int i = 0;   
            foreach(var g in grds)
            {
                grades[i] = g;
                i++;
            }
        }


        //vytvorit settery/gettery alebo public
        private int[] grades = new int[3];
        private string subjectname;



        public double getAverage()
        {
            int i = 0;
            double average = 0;
            foreach(int g in grades)
            {
                average += grades[i];
                i++;
            }
            return average/grades.Length;
        }
        public string getGrades()
        {
            string grds;
            grds = grades[0].ToString();
            for (int i = 1; i < grades.Length; i++)
            {
                grds += "," + grades[i].ToString();
            }
            return grds;
        }
    }
}

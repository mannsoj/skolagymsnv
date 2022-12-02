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
        public void Constructor(string name, int one, int two, int three)
        {
            subjectname = name;
            grades[0] = one;
            grades[1] = two;
            grades[3] = three;
        }


        //vytvorit settery/gettery alebo public
        private int[] grades = new int[3];
        private string subjectname = "";



        public double Average()
        {
            double average = 0;
            foreach(int i in grades)
            {
                average += grades[i];
            }
            return average/grades.Length;
        }
    }
}

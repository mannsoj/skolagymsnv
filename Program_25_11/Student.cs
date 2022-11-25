using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_25_11
{
    internal class Student
    {
        public Student(string name,int gradeChe ,int gradePhy )
        {
         studentName = name;
         gradeChem = gradeChe;
         gradePhys = gradePhy;
        }
        public Student(string name)
        {
            studentName = name;
            gradeChem = 1;
            gradePhys = 1;
        }
        public string studentName;
        public int gradeChem;
        public int gradePhys;
        public double gradeAverage()
        {
            return (double)(gradeChem + gradePhys) / 2;
        }
    }
}

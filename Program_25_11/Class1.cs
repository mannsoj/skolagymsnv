using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_25_11
{
    internal class Student
    {
        public string name = "";
        public int gradeChem = 1;
        public int gradePhy = 3;

        public double gradeAverage()
        {
            return (double)(gradeChem + gradePhy) / 2;
        }
    }
}

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
            Classroom classroom = new Classroom();


            classroom.writeAverageTable();
            classroom.writeGradesTable();
            classroom.writeSomething();


            //du1 celkovy priemer
            //du2 vytvorit triedu trieda a potom ine veci atd atd atd atd

            //daco co sven urobil 
            //CZiak[] ziaci2 = {new CZiak("xy"),new CZiak("xy"),new CZiak("xy")};


            Console.ReadKey();
        }
    }
}

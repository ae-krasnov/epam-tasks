using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student();
            Teacher teach = new Teacher();

            stud.Strat = new StudentStrat();
            teach.Strat = new TeacherStrat();

            stud.Session();
            teach.Session();
            Console.ReadLine();
        }
    }
}

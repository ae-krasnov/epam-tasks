using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IHuman man = Factory.PeopleFactory(24, "Andrey", true);
            Console.WriteLine(man.GetProfesion());
            Console.ReadLine();
        }
    }
}

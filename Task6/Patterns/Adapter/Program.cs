using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IHuman student = new Student("Peter",20);
            IHuman man = new AdapterWierdPerson("Jhon Smith", 25);
            
            Console.WriteLine(man.GetProfesion());
            Console.WriteLine(student.GetProfesion());
            Console.ReadLine();
        }
    }
}

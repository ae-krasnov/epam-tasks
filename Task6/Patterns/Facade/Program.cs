using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Group MyGroup = new Group();
            
            MyGroup.Add(new Student());
            MyGroup.Add(new WierdPerson());
            MyGroup.Add(new Teacher());

            MyGroup.TalkAboutProfesion();
            Console.ReadLine();
        }
    }
}

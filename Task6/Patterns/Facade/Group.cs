using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Group
    {
        private List<object> _group = new List<object>();

        public void Add(object o) 
        {
            if (o is Student)
            {
                _group.Add(o);
            }
            else if (o is Teacher)
            {
                _group.Add(o);
            }
            else if (o is WierdPerson)
            {
                _group.Add(o);
            }
        }

        public void TalkAboutProfesion()
        {
            foreach (var person in _group)
            {
                if (person is Student)
                {
                    Console.WriteLine("I'm a student.");
                }
                else if (person is Teacher)
                {
                    Console.WriteLine("I'm a teacher.");
                }
                else if (person is WierdPerson)
                {
                    Console.WriteLine("I don't know.");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class WierdPerson
    {
        private string _name;
        private int _age;
        private readonly string _profession="unknown";

        public WierdPerson(string name, int age) 
        {
            _name = name;
            _age = age;
        }

        public string ObtainName()
        {
            return _name;
        }

        public int ObtainAge()
        {
            return _age;
        }

        public string ObtainProfesion()
        {
            return _profession;
        }
    }
}

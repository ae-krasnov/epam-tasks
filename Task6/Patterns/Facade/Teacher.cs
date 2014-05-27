using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Teacher 
    {
        private string _name;
        private int _age;
        private string _profession;

        public Teacher(string name,int age) 
        {
            _name = name;
            _age = age;
            _profession = "Teacher";
        }

        public Teacher() 
        {
            _profession = "Teacher";
        }

        public string GetName()
        {
            return _name;
        }

        public int GetAge()
        {
            return _age;
        }

        public string GetProfesion()
        {
            return _profession;
        }
    }
}

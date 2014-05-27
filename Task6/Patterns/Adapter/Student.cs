using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Student : IHuman
    {
        private string _name;
        private int _age;
        private string _profession;

        public Student(string name,int age) 
        {
            _name = name;
            _age = age;
            _profession = "Student";
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

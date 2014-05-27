using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Student 
    {
        public Strategy Strat { get; set; }
        private string _name;
        private int _age;
        private string _profession;

        public Student(string name,int age) 
        {
            _name = name;
            _age = age;
            _profession = "Student";
        }

        public Student()
        {
            _profession = "Student";
        }

        public void Session()
        {
            Strat.PrepareToSession();
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

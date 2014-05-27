using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Factory
    {
        public static IHuman PeopleFactory(int age, string name, bool isAStudent) 
        {
            if (isAStudent)
            {
                return new Student(name, age);
            }
            else
            {
                return new Teacher(name, age);
            }
        }
    }
}

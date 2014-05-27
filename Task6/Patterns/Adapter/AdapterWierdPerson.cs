using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class AdapterWierdPerson : IHuman
    {
        private WierdPerson _person;

        public AdapterWierdPerson(string name, int age)
        {
            _person = new WierdPerson(name, age);
        }

        public string GetName()
        {
            return _person.ObtainName();
        }

        public int GetAge()
        {
            return _person.ObtainAge();
        }

        public string GetProfesion()
        {
            return _person.ObtainProfesion();
        }
    }
}

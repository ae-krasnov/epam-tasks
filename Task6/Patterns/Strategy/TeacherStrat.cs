using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class TeacherStrat : Strategy
    {
        public override void PrepareToSession()
        {
            Console.WriteLine("I don't care");
        }
    }
}

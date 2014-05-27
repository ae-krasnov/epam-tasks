using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class StudentStrat : Strategy
    {

        public override void PrepareToSession()
        {
            Console.WriteLine("Time to work");
        }
    }
}

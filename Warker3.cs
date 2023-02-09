using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary6
{
    public class Worker3 : Worker
    {
        public Worker3(int Hours)
        {
            hours = Hours;
        }
        public override int Calc()
        {
            pay = hours * 200;
            return pay;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary6
{
    public class Worker2 : Worker
    {
        public Worker2(int Tasks)
        {
            tasks = Tasks;
        }
        public override int Calc()
        {
            pay = tasks * 150;
            return pay;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_1
{
 
        public interface IPoint
        {
            double X { get; set; }
            double Y { get; set; }

            double CalculateDistance(IPoint point, IPoint point1);
           
            string Quadrans();

        }
    
}

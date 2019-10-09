using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domashna_rabota1
{
    class Calculator
    {
        public double AddNumber(double val1, double val2)
        {
            double sum = val1 + val2;
            return sum;
        }
       public  double SubNumber(double val1, double val2)
        {
            double sum = val1 - val2;
            return sum;
        }
        public double PNumber(double val1, double val2)
        {
           double  sum = val1 * val2;
            return sum;
        }
        public double DNumber(double val1, double val2)
        {
           double sum = val1 / val2;
            return sum;
        }

    }
}

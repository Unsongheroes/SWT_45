using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class SimpleCalculator1
    {
        public SimpleCalculator1()
        {
            
        }
        public double Add(double a, double b)
        {
            double result = a + b;
            return result;
        }

        public double Subtract(double a, double b)
        {
            double result = a - b;
            return result;
        }

        public double Multiply(double a, double b)
        {
            double result = a * b;
            return result;
        }

        public double Power(double x, double exp)
        {
            if (exp == 0)
                return 1.0;
           else
            return x * Power(x,exp-1);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Calculator
    {
        public static int Divide(int a, int b)
        {
            int retValue = 0;

            if (b < a)
                throw new InvalidDenominatorException("The value of b should be greater than a");

            retValue = a / b;


            return retValue;
        }
    }
}

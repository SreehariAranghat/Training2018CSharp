using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class InvalidDenominatorException : ApplicationException
    {
        public InvalidDenominatorException() : base()
        {

        }

        public InvalidDenominatorException(string message) : base(message) { }

        public InvalidDenominatorException(string message, Exception innerException) 
                                    : base(message, innerException) { }

        public InvalidDenominatorException(int denominator, string message) : base(message) { }
    }
}

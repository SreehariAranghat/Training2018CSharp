using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMathLibrary
{
    public class MathLibrary
    {
        public int Add(int a,int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a + b;
        }

        internal int SpecialSubstract(int a,int b, int c)
        {
            return a - b - c;
        }
    }
}

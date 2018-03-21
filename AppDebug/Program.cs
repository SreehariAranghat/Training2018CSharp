using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Operation :");
            string op = Console.ReadLine();

            if (op == "Subtract")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                int retValue = Subtract(a, b);
                Console.WriteLine($"Result :{retValue}");
            }
            else
            {
                float a = float.Parse(Console.ReadLine());
                float b = float.Parse(Console.ReadLine());

                float retValue = Divide(a, b);
                Console.WriteLine($"Result :{retValue}");
            }

            Console.ReadLine();
        }

        public static int  Subtract(int a,int b)
        {
            int retValue = 0;

            if (a > b)
                retValue = a - b;
            else
                retValue = b - a;

            return retValue;
        }

        public static float Divide(float a,float b)
        {
            float retValue = 0;

            if (b > 0)
                retValue = a / b;

            return retValue;
        }
    }
}

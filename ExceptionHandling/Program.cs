using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Process(10, 0);

            }catch(Exception excp)
            {
                Console.WriteLine(excp.Message);
            }
        }

        public static void Process(int a,int b)
        {
            try
            {
                Calculator.Divide(a, b);

            }
            catch (DivideByZeroException excp)
            {
                throw;
            }
            catch(InvalidDenominatorException excp)
            {
                throw;
            }
            catch (Exception excp)
            {
                throw;
            }
            catch
            {
               
            }
            
        }
    }
}

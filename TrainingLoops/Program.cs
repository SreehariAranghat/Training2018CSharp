using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region loops
            ////For loop
            //for (int i=0;i<10;i=i+2)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("-------------------------------------");
            ////While
            //int limit = 0;
            //while(limit < 10)
            //{
            //    Console.WriteLine(limit);
            //    limit++;
            //}

            ////Do While Loop
            //Console.WriteLine("-------------------------------------");
            //do
            //{
            //    Console.WriteLine(limit);
            //    limit++;
            //}
            //while (limit < 10);

            //Console.WriteLine("-------------------------------------");
            ////Foreach loop
            //string[] cities = new string[] { "Bangalore", "Mumbai", "Pune" };
            ////for (int i = 0; i < cities.Length; i++) 
            ////        Console.WriteLine(cities[i]);
            //foreach (string city in cities.Reverse())
            //    Console.WriteLine(city);

            //Console.WriteLine("-------------------------------------");
            //string[][] metros = new string [3][] {

            //                        new string[] { "Bangalore", "Mumbai", "Pune" },
            //                        new string[] { "Chennei", "Hydrebad", "Delhi" },
            //                        new string[] { "X", "Y", "Z" }
            //            };

            //for(int i=0;i<3;i++)
            //{
            //    foreach(string city in metros[i])
            //    {
            //        Console.WriteLine(city);
            //    }

            //    Console.WriteLine($"\t-----------END OF SET {i}");
            //}

            #endregion

            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.UtcNow);

            //Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy hh:mm"));

            //Console.WriteLine($"Day of today is : {DateTime.Now.Day}");
            //Console.WriteLine($"Day of year is : {DateTime.Now.Year}");
            //Console.WriteLine($"Weekday is : {DateTime.Now.DayOfWeek}");

            //DateTime dtFuture = DateTime.Now.AddDays(3);

            //Console.WriteLine($"Future data is {dtFuture}");

            DateTime dtDataOfBirth = new DateTime(1984, 5, 3);
            TimeSpan span          = DateTime.Now.Subtract(dtDataOfBirth);
            Console.WriteLine($"You are been around here for {span.TotalDays}");
            
        }
    }
}

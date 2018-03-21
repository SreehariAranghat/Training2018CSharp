using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> listOfNames = new List<string>();
            //listOfNames.Add("Sree");
            //listOfNames.Add("XYZ");
            //listOfNames.Add("ABC");

            //foreach(string s in listOfNames)
            //{
            //    Console.WriteLine(s);
            //}

            //listOfNames.Remove("XYZ");
            //listOfNames.RemoveAt(1);

            //listOfNames.Insert(2, "SDFD");
            //int location = listOfNames.IndexOf("Sree");


            ////SortedSet<string> listOfNAmes = new SortedSet<string>();
            ////listOfNAmes.Add("Sree");
            ////listOfNAmes.Add("Bill");
            ////listOfNAmes.Add("William");
            ////listOfNAmes.Add("Zack");

            ////foreach(string s in listOfNAmes)
            ////{
            ////    Console.WriteLine(s);
            ////}

            #region GenericCollections
            Dictionary<string, string> stateAndCapital = new Dictionary<string, string>();
            Dictionary<string, List<string>> stateAndCities = new Dictionary<string, List<string>>();

            stateAndCities.Add("Karnataka"
                                , new List<string>() { "Bangalore", "Mysore", "Mangalore" });

            stateAndCities.Add("Maharastra", new List<string>() { "Mumbai", "Pune" });

            stateAndCapital.Add("Karnataka", "Bangalore");
            stateAndCapital.Add("Maharastra", "Mumbai");
            stateAndCapital.Add("WestBengal", "Kolkata");

            var state = Console.ReadLine();
            //Console.WriteLine($"The capital of {state} is {stateAndCapital[state]} ");

            //List<string> cities = stateAndCities[state];
            var cities = stateAndCities[state];

            Console.WriteLine($"And citieis in {state} are");
            foreach (string s in cities)
            {
                Console.WriteLine(s);
            }

            foreach(string key in stateAndCities.Keys)
            {
                Console.WriteLine($"--------{key}");
                Console.WriteLine("CITIES");

                List<string> cityList = stateAndCities[key];
                foreach(string city in cityList)
                {
                    Console.WriteLine($"\t\t{city}");
                }
            }

            Dictionary<string, int> statePopulation = new Dictionary<string, int>();
            statePopulation.Add("Karnatala", 10);
            statePopulation.Add("Kerala", 20);

            int totalPopulation = statePopulation.Values.Sum();

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Karnataka : Bangalore");
            builder.AppendLine("Kerala : Trivandrum");

            Console.WriteLine(builder.ToString());

            #endregion

            Stack<string> stack = new Stack<string>();
            stack.Push("Sree");
            stack.Push("Bill");
            stack.Push("Steve");

            string lastData = stack.Pop();

            foreach(string s in stack)
            {
                Console.WriteLine(s);
            }

            Queue<string> queue = new Queue<string>();
        }
    }
}

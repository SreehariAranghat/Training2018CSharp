using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = ConfigurationManager.AppSettings["logFilePath"];

            StreamWriter streamWriter = new StreamWriter(filePath, true);
            Console.Write("Provide some input : ");
            string data = Console.ReadLine();

            streamWriter.WriteLine($"{DateTime.Now} : {data}");

            streamWriter.Close();

            StreamReader read = new StreamReader(filePath);
            string content = read.ReadToEnd();

            Console.WriteLine("-----------------------File Contents-----------------");
            Console.WriteLine(content);

            Console.ReadLine();
            
        }

        public static void ShowDirectories()
        {
            foreach(DirectoryInfo info in new DirectoryInfo(@"C:\").GetDirectories())
            {
                Console.WriteLine(info.Name);

                try
                {
                    if (info.GetDirectories().Count() > 0)
                    {
                        foreach (DirectoryInfo subdir in info.GetDirectories())
                        {
                            Console.WriteLine("--" + subdir.Name);
                        }
                    }
                }
                catch (Exception excp) { }
            }
        }
    }
}

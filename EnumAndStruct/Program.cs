using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAndStruct
{
    public enum Gender
    {
        Male = 1001
        ,Female
        ,Others
    }

    public struct Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public int TotalMarksScored { get; set; }
        public string RegisterNumber { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            #region enum
            //string name = "Sreehari";
            //Gender gender = Gender.Male;


            //Gender genderFromString = (Gender)Enum.Parse(typeof(Gender)
            //                                            , "Male");

            //string[] genderList = Enum.GetNames(typeof(Gender));

            //Console.WriteLine("Gender List :");
            //foreach(string s in genderList)
            //{
            //    Console.WriteLine("\t" + s);
            //}

            //Console.Write("Enter Your Gender :");
            //string strGender = Console.ReadLine();
            //Gender genEnum   = (Gender)Enum.Parse(typeof(Gender), strGender);

            //Console.WriteLine("Gender String : " + genEnum);
            //Console.WriteLine("Gender Integer:" + (int)genEnum);

            #endregion

            List<Student> students = new List<Student>();

            for (int i = 0; i < 3; i++)
            {
                Student student = new Student();
                Console.Write("Enter the Name : ");
                student.Name = Console.ReadLine();

                Console.Write("Enter the age : ");
                student.Age = int.Parse(Console.ReadLine());

                Console.Write("Enter Register Number :");
                student.RegisterNumber = Console.ReadLine();

                Console.Write("Enter Marks :");
                student.TotalMarksScored = int.Parse(Console.ReadLine());

                Console.Write("Enter Gender : ");
                string strGender = Console.ReadLine();
                student.Gender   = (Gender)Enum.Parse(typeof(Gender)
                                                    , strGender);
                if (!students.Any(d => d.RegisterNumber == student.RegisterNumber))
                    students.Add(student);
                else
                    Console.WriteLine("Student with the same register number exist");

                Console.WriteLine("------------------------------------");
            }

            Console.WriteLine($"Total Number of Students : {students.Count}");
            DisplayStudents(students);

            List<Student> femaleStudents = students
                                            .Where(d => d.Gender == Gender.Female)
                                            .ToList();

            Console.WriteLine("Female Students");
            DisplayStudents(femaleStudents);

            List<Student> maxMarks = students
                                    .Where(d => d.TotalMarksScored > 400)
                                    .ToList();

            Console.WriteLine("Students with more than 400 marks");
            DisplayStudents(maxMarks);

            int maxMarksScored          = students.Max(d => d.TotalMarksScored);
            Student studentWithMaxMark  = students
                                            .First(d => d.TotalMarksScored == maxMarksScored);

            Console.WriteLine("Student With Highest Marks");
            DisplayStudent(studentWithMaxMark);
        }

        public static void DisplayStudent(Student student)
        {
            Console.WriteLine($"Name : {student.Name}" +
                    $" Age : {student.Age}" +
                    $" Gender : {student.Gender}" +
                    $" Marks Scored : {student.TotalMarksScored}" +
                    $" Register Number : {student.RegisterNumber}");
        }

        public static void DisplayStudents(List<Student> students)
        {
            foreach(Student s in students)
            {
                DisplayStudent(s);
            }
        }
    }
}

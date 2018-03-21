using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Name : ");
            //string name = Console.ReadLine();

            //Console.Write("RegisterNumber :");
            //string regno = Console.ReadLine();

            //Student student = new Student();
            //student.Name = name;
            //student.RegisterNumber = regno;

            //StudentMarks mathsMarks = new StudentMarks { Marks = 80, SubjectName = "Maths" };
            //StudentMarks physicsMarks = new StudentMarks { Marks = 90, SubjectName = "Physics" };

            //student.StudentMarks.Add(mathsMarks);
            //student.StudentMarks.Add(physicsMarks);

            //student.Save();

            //if (student.Id > 0)
            //{
            //    Console.WriteLine($"Student successfully created with id : {student.Id}");
            //}
            //else
            //    Console.WriteLine("Failed to create the student");

            var students = Student.GetStudents();

            foreach(Student s in students)
            {
                Console.WriteLine($"Id : {s.Id} / Name:{s.Name} " +
                    $"/ RegisterNumber : {s.RegisterNumber}");
            }

            int toalStuents = Student.GetTotalStudentCount();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Total Students = {toalStuents}");


            Console.Write("Enter the student id to be deleted : ");
            int studentId = int.Parse(Console.ReadLine());
            int retValue  = Student.DeleteStudent(studentId);

            if(retValue > 0)
            {
                Console.WriteLine("Student deleted succesfully");
                var stuList = Student.GetStudents();

                foreach (Student s in stuList)
                {
                    Console.WriteLine($"Id : {s.Id} / Name:{s.Name} " +
                        $"/ RegisterNumber : {s.RegisterNumber}");
                }
            }
            else
            {
                Console.WriteLine("Could not delete teh student");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleMathLibrary;

namespace ClassesTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            JuniorSoftwareEngineer juniorSoftwareEngineer
                                = new JuniorSoftwareEngineer();

            ProjectManger projectManager = new ProjectManger();

            int totalJseSalary = juniorSoftwareEngineer.CalculateSalary();
            int totalPmSalary  = projectManager.CalculateSalary();

            int totalLeaves    = juniorSoftwareEngineer.TotalLeaves();
            int totalPmLeaves = projectManager.TotalLeaves();

            Console.WriteLine($"Jse Salary : {totalJseSalary}");
            Console.WriteLine($"Pm Salary : {totalPmSalary}"); ;

            Console.WriteLine($"Jse Leaves : {totalLeaves}");
            Console.WriteLine($"Pm Leaves : {totalPmLeaves}");

            bool isJseEligigle = LoanEligibilityCalculator
                                .IsEmployeeLoanEligible(juniorSoftwareEngineer);

            bool isPmEligigle = LoanEligibilityCalculator
                                    .IsEmployeeLoanEligible(projectManager);

          
            
        }
    }
}

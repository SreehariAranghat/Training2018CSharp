using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTraining
{
    public class ProjectManger : Employee
    {
        public ProjectManger()
        {
            base.EmployeeType = EmployeeType.ProjectManager;
            base.BaseSalary   = 30000;
        }

        public override int CalculateSalary()
        {
            int ta = 3000;
            int hra = 5000;
            int projectBonus = 10000;
            int managerConveyence = 3000;

            int totalSalary = BaseSalary 
                                    + ta 
                                    + hra 
                                    + projectBonus 
                                    + managerConveyence;

            return totalSalary;
        }

        public override int TotalLeaves()
        {
            return base.TotalLeaves() + 10;
        }
    }
}

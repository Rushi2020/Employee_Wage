using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{

        internal interface AddDetails
        {
            public void addEmployeeWage(string companyName, int wagePerHour, int totalWorkingDays, int maxHrsWorked);
            public void GetEmpWage();
        }
    
}


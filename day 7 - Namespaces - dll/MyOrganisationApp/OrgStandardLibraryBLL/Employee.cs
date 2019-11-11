using System;

namespace OrgStandardLibraryBLL
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public double SalaryPerDay { get; set; }
        public double HRA { get; set; }

        public double GetSalary(int NoOfLeavesTaken)
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int NoOfWorkingDays = DateTime.DaysInMonth(year, month);
            int NoOfDayspresent = NoOfWorkingDays - NoOfLeavesTaken;
            double BasicSalary = NoOfDayspresent * SalaryPerDay;
            double HRASal = BasicSalary * HRA / 100;
            double GrossSalary = BasicSalary + HRASal;
            return GrossSalary;
        }
    }
}

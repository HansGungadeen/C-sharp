using System;
using OrgStandardLibraryBLL;

namespace OrganisationConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee E = new Employee()
            {
                EmpId = 100,
                Name = "Peter",
                SalaryPerDay = 32.5,
                HRA = 12.3
            };

            double GS = E.GetSalary(3);
            Console.WriteLine("Gross Salary of {0} is {1}", E.Name, GS);
            Console.ReadLine();

        }
    }
}

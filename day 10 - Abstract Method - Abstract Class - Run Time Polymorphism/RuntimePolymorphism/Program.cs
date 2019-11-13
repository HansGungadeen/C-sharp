using System;


abstract class Employee
{
    public int EmpId { get; set; }
    public string Name { get; set; }
    public double salaryPerHour { get; set; }

    public virtual void Details()
    {
        Console.WriteLine("EmpId:" + EmpId);
        Console.WriteLine("Emp Name:" + Name);
        Console.WriteLine("Salary Per Hour:"+salaryPerHour);
    }

    public abstract void CalculateSalary(int NoOfWorkingHours);
    public abstract void calculateLeaves();

}

class SoftwareEng:Employee
{
    public string Technology { get; set; }
    public override void Details()
    {
        base.Details();
        Console.WriteLine("Technology:"+Technology);
    }

    public override void CalculateSalary(int NoOfWorkingHours)
    {
        //HRA 15%
        double BS = (salaryPerHour * NoOfWorkingHours);
        double HRA = BS * 15 / 100;
        double GS = BS + HRA;
        Console.WriteLine("Gross Salary is SE :" + GS);
    }

    public override void calculateLeaves()
    {
        Console.WriteLine("This is Calculating Leaves of SE:");
    }
}

class TeamLead : Employee
{
    public int Size { get; set; }
    public override void Details()
    {
        base.Details();
        Console.WriteLine("Size:" + Size);
    }

    public override void CalculateSalary(int NoOfWorkingHours)
    {
        //HRA 30.5%
        double BS = (salaryPerHour * NoOfWorkingHours);
        double HRA = BS * 30.5 / 100;
        double GS = BS + HRA;
        Console.WriteLine("Gross Salary of Team Lead is :" + GS);
    }

    public override void calculateLeaves()
    {
        Console.WriteLine("This is Calculating Leaves of TL:");
    }
}

namespace RuntimePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee E;
            Console.WriteLine("1.SE 2.TL 3.HR");
            int type = int.Parse(Console.ReadLine());
            switch(type)
            {
                case 1:
                    E = new SoftwareEng()
                    {
                        EmpId = 100,
                        Name = "Peter",
                        salaryPerHour = 45,
                        Technology = ".Net Core"
                    };
                    break;
                case 2:
                    E = new TeamLead()
                    {
                        EmpId = 200,
                        Name = "Jack",
                        salaryPerHour = 46,
                    };
                    break;
                default:
                    E = new SoftwareEng()
                    {
                        EmpId = 100,
                        Name = "Peter",
                        salaryPerHour = 45,
                        Technology = ".Net Core"
                    };
                    break;
            }

            E.Details();
            E.CalculateSalary(36);
            E.calculateLeaves();

            Console.ReadLine();
        }

    }
}

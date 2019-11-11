using System;
using MyOrg.HR;
using System.ComponentModel.DataAnnotations;


//namespace admin
//{
//    class employee
//    {
//        public void Add() { }
//        public void Update() { }
//    }

//}

namespace MyOrg
{
    namespace HR
    {
        class Employee
        {
            public void CalculateSalary() { }

        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        //admin.employee E1 = new admin.employee();
        //E1.Add();
        //E1.Update();

        //HR.Employee E2 = new HR.Employee();
        //E2.CalculateSalary();

        //MyOrg.HR.Employee E1 = new MyOrg.HR.Employee();
        //E1.CalculateSalary();

        Employee E1 = new Employee();
        E1.CalculateSalary();
        
        Console.ReadLine();

    }
}


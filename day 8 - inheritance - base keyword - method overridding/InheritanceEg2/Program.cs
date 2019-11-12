using System;

namespace InheritanceEg2
{
    class Customer
    {
        protected int CustomerId;
        string Name;

        public void Details()
        {
            Console.WriteLine("CustomerId" + CustomerId);
            Console.WriteLine("Name" + Name);
        }
    }

    class BankCustomer : Customer
    {
        int AccNo;

        public void BankCustomerDetails()
        {
            //CustomerId
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Customer C = new BankCustomer();
             

            Console.ReadLine();


        }
    }
}

using System;

namespace InheritanceEg
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public void Details()
        {
            Console.WriteLine("CustomerId:" + CustomerId);
        }
    }

    class BankCustomer : Customer
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }

        public void BankCustomerDetails()
        {
            Console.WriteLine("CustomerId:" + CustomerId);
            Console.WriteLine("BankBalance:" + Balance);
        }
    }

    class LoanCustomer : BankCustomer
    {
        public double LoanAmount { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer C = new Customer()
            {
                CustomerId = 123,
                Name = "Hans",
                Email = "hvvvns@gmail.com"
            };

            BankCustomer BC = new BankCustomer()
            {
                CustomerId = 124,
                Name = "Peter",
                Email = "peter@gmail.com",
                AccountNumber = 12345,
                Balance = 5000
            };

            BC.Details();
            BC.BankCustomerDetails();

            C.Details();

            LoanCustomer LC = new LoanCustomer();
            // LC. can access all fields
            

            Console.ReadLine();

            
        }
    }
}

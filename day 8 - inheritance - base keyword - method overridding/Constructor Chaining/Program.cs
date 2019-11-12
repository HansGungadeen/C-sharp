using System;

namespace Constructor_Chaining
{
    class Customer
    {
        protected int CustomerId;
        protected string Name;
        protected string Email;

        public Customer()
        {
            Console.WriteLine("This is customer constructor.");
        }

        public Customer(int CustomerId, string Name,string Email)
        {
            Console.WriteLine("this is customer constructor with para");

            this.CustomerId = CustomerId;
            this.Name = Name;
            this.Email = Email;
        }
        
    }

    class BankCustomer : Customer
    {
        protected int AccNo;
        protected double Balance;

        public BankCustomer()
        {
            Console.WriteLine("this is bank customer constructor");
        }
        
        public BankCustomer(int CustomerId, string Name, string Email, int AccNo, double Balance)
            :base(CustomerId,Name,Email)
        {
            Console.WriteLine("this is bank customer constructor with para");

            //this.CustomerId = CustomerId;
            //this.Name = Name;
            //this.Email = Email;
            this.AccNo = AccNo;
            this.Balance = Balance;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            BankCustomer BC = new BankCustomer(123,"Hans","wygfiwefgiwgf",874865,98756452);





            Console.ReadLine();


        }
    }
}

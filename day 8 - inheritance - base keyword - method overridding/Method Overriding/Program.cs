using System;

class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }

    public virtual void GetDetails()
    {
        Console.WriteLine("Customer Id:" + CustomerId);
        Console.WriteLine("Name:" + Name);
    }
}

class BankCustomer : Customer
{
    public double Balance { get; set; }
    
    public override void GetDetails()
    {
        base.GetDetails();
        //Console.WriteLine("Customer Id:" + CustomerId);
        //Console.WriteLine("Name:" + Name);
        Console.WriteLine("Balance:" + Balance);

    }

    public void Deposite(double amt)
    {
        Balance = Balance + amt;
        this.GetDetails();
    }

}

namespace Method_Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            BankCustomer BC = new BankCustomer()
            {
                CustomerId = 123,
                Name = "Hans",
                Balance = 486512
            };

            BC.GetDetails();

            Console.ReadLine(); 
        }
    }
}

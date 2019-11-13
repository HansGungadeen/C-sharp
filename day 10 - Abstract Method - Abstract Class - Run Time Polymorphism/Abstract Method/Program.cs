using System;

abstract class A
{
    public void show()
    {
        Console.WriteLine("This is show of A");
    }

    public abstract void Display();
}

class B : A
{
    public override void Display()
    {
        Console.WriteLine("This is the display of B");
    }
}




namespace Abstract_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            A a;
            a = new B();
            a.show();
            a.Display();

            Console.ReadLine(); 

        }
    }
}

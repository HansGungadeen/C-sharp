using System;

class A
{
    public A()
    {
        Console.WriteLine("Default Constructor Of A");
    }
    public A(int a)
    {
        Console.WriteLine("Default Constructor Of A w/ para");
    }


}

class B:A
{
    public B():base(34)
    {
        Console.WriteLine("Default Constructor Of B");
    }

    public B(int x)
    {
        Console.WriteLine("Default Constructor Of B w/ param");
    }
}

class C : B
{
    public C():base(67)
    {
        Console.WriteLine("default constructor of C");
    }
}
namespace base_keyword
{
    class Program
    {
        static void Main(string[] args)
        {

            C c = new C();

            Console.ReadLine();
        }
    }
}

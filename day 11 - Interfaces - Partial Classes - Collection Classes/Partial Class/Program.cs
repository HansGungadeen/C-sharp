using System;

namespace Partial_Class
{

    partial class A
    {
        public void Show()
        {
            Console.WriteLine("Show");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();

            a.Show();
            a.Display();

            Console.ReadLine();
        }
    }
}

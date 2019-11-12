using System;

namespace Sealed
{
    class A
    {
        public virtual void Show()
        {
            Console.WriteLine("Show");
        }
    }

    class B : A
    {
        public override void Show()
        {
            Console.WriteLine("show");

        }
    }

    sealed class C : B
    {
        //public override sealed void Show()
        //{
        //    {
        //        Console.WriteLine("Show of C");
        //    }
        //}
    }

    class D
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            //C c = new C();
            //c.Show();

            D d = new D();
            d.Show();

            Console.ReadLine();
        }
    }
}

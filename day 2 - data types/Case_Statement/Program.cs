using System;
using System.Collections.Generic;
using System.Text;

namespace data_types
{
    class Case_statement
    {
        static void Main(string[] args)

        {
            int a = 10;
            int b = 20;

            int opt;

        L: Console.WriteLine("1.Add 2.Mul 3.Sub 4.Exit");
            Console.WriteLine("Enter Choice");
            opt = int.Parse(Console.ReadLine());

            switch (opt)
            {
                case 2:
                    Console.WriteLine("Multiplication is " + a * b);
                    break;
                case 1:
                    Console.WriteLine("Addition is " + (a + b));
                    break;
                case 3:
                    Console.WriteLine("Substraction is " + (a - b));
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Invalid Option!");
                    goto L;

            }


            Console.ReadLine();

        }
    }

}

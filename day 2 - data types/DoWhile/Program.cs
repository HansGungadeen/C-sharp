using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            do
            {
                i = int.Parse(Console.ReadLine());
            }while (i!= 0);
        }
    }
}

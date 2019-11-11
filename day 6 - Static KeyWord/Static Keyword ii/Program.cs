using System;

namespace Static_Keyword_ii
{
    static class Calculation
    {
        public static void Add(int a,int b)
        {
            Console.WriteLine("Addition:" + (a + b));
        }
        public static void Multiply(int a, int b)
        {
            Console.WriteLine("Multiplication:" + (a * b));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculation.Add(23, 45);
            Calculation.Multiply(34, 67);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections;

namespace Collection_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //STACK

            //Stack S = new Stack(3);
            //S.Push(23);
            //S.Push(45);
            //S.Push(78);

            //while (S.Count != 0)
            //{
            //    Console.WriteLine(S.Pop().ToString());
            //}

            //int sum = 0;
            //while(S.Count != 0)
            //{
            //    sum = sum + int.Parse(S.Pop().ToString());
            //}
            //Console.WriteLine("Sum is " + sum);

            //QUEUE
            Queue Q = new Queue();
            Q.Enqueue("Ha");
            Q.Enqueue("Han");
            Q.Enqueue("Hans");

            //while (Q.Count ! = 0)
            //{
            //    Console.WriteLine(Q.Dequeue());
            //}

            string name = null;

            while(Q.Count !=0)
            {
                name = name + " " + Q.Dequeue();
            }
            Console.WriteLine(name);
            //Console.WriteLine(Q.Dequeue());

            Console.ReadLine();
        }
    }
}

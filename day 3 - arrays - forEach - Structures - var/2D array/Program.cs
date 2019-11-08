using System;

namespace _2D_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] my2dArray = new int[2,3];
            my2dArray[0, 0] = 78;

            for (int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    my2dArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.ReadLine();

        }
    }
}

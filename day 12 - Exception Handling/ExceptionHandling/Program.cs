using System;
using BLL;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] A = new int[2];
            //try
            //{

            //    A[0] = 0;
            //    Console.WriteLine(A[0]);

            //    A[1] = 45;
            //    Console.WriteLine(A[1]);

            //    var x = A[1] / A[0];

            //    A[2] = 7;
            //    Console.WriteLine(A[2]);
            //}



            //catch (FormatException FE)
            //{


            //    Console.WriteLine(FE.Message);

            //    A[1] = 0;
            //}

            //catch (DivideByZeroException DZ)
            //{


            //    Console.WriteLine(DZ.Message);
            //}

            //catch (IndexOutOfRangeException IE)
            //{


            //    Console.WriteLine(IE.Message);
            //}

            //catch (Exception E)
            //{


            //    Console.WriteLine(E.Message);

            //    A[1] = 0;
            //}


            //finally { }
            try
            {

                var result = Calculate.Divide(15, 0);
                Console.WriteLine("Result is " + result);
            }
            catch (Exception E)
            {

                Console.WriteLine(E.Message);
            }

            finally
            {
                //
            }
            Console.ReadLine();
        }
    }
}

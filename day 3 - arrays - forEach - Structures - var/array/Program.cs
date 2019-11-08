using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {

            //declare array
            int[] myArray = new int[5];

            //input value
            //myArray[0] = 56;
            //myArray[1] = myArray[2] = 78;
            //myArray[3] = myArray[0] + myArray[1];
            //myArray[4] = int.Parse(Console.ReadLine());

            //display array
            //Console.WriteLine(myArray[0]);
            //Console.WriteLine(myArray[1]);
            //Console.WriteLine(myArray[2]);
            //Console.WriteLine(myArray[3]);
            //Console.WriteLine(myArray[4]);

            //display array using for loop

            //Console.WriteLine("The Elements are:");
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}

            
            //input values of eements using loop
            Console.WriteLine("Enter all the 5 values ");
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }

            //display all elements using for foreach loops
            Console.WriteLine("The Elements are - for each");
            foreach (int k in myArray)
            {
                Console.WriteLine(k);
            }

            //sum of all elemnts
            //int sum = 0;
            //foreach(int item in myArray)
            //{
            //    sum = sum + item;
            //}

            //sort the element
            Array.Sort(myArray);

            //reverse order
            Array.Reverse(myArray);

            

            Console.WriteLine("The element are after sorting");
            foreach (int k in myArray)
            {
                Console.WriteLine(k);
            }

            //Console.WriteLine("Sum of Integers is " + sum);

            //find element of an array
            Console.WriteLine("index is " + Array.IndexOf(myArray, 100));
            Console.WriteLine("Location is " + Array.IndexOf(myArray, 100) + 1);



            Console.ReadLine();
        }
    }
}

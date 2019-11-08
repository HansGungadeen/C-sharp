using System;

namespace Assignment1
{
    class Program
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Enter Current Meter Reading: ");
            double cmr = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Previous Meter Reading: ");
            double pmr = double.Parse(Console.ReadLine());



            //Console.WriteLine("Unit/month: " + (cmr - pmr));
            //double unit = double.Parse(Console.ReadLine());

            double unit = cmr - pmr;


            Console.WriteLine("Enter connection type: ");
        T: Console.WriteLine("1.Domestic" + "\n" + "2.Commercial");
            int connect_type = int.Parse(Console.ReadLine());

            switch (connect_type)
            {
                case 1:
                    Domestic.Dome(unit);
                    break;
                case 2:
                    Commercial.Com(unit);
                    break;
                default:
                    Console.WriteLine("Invalid Option!");
                    goto T;
            }
        }
    }

    public class Domestic
    {
        public static void Dome(double i)
        {
            double amount;

            if (i > 0 && i <= 200)
            {
                amount = i * 5.00;
                Console.WriteLine("Bill: " + amount);
                //return amount;
            }
            if (i > 201 && i <= 300)
            {
                amount = i * 7.20;
                Console.WriteLine("Bill: " + amount);
                //return amount;
            }
            if (i > 301 && i <= 400)
            {
                amount = i * 8.50;
                Console.WriteLine("Bill: " + amount);
                //return amount;
            }
            if (i > 401 && i <= 800)
            {
                amount = i * 9.00;
                Console.WriteLine("Bill: " + amount);
                //return amount;
            }
            if (i > 800)
            {
                amount = i * 9.50;
                Console.WriteLine("Bill: " + amount);
                //return amount;
            }
        }
    }
    public class Commercial
    {
        public static void Com(double i)
        {
            double amount;

            if (i > 0 && i <= 100)
            {
                amount = i * 7.50;
                Console.WriteLine("Bill: " + amount);
                //return amount;
            }
            if (i > 101 && i <= 300)
            {
                amount = i * 8.90;
                Console.WriteLine("Bill: " + amount);
                //return amount;
            }
            if (i > 301 && i <= 500)
            {
                amount = i * 9.40;
                Console.WriteLine("Bill: " + amount);
                //return amount;
            }
            if (i > 500)
            {
                amount = i * 10.00;
                Console.WriteLine("Bill: " + amount);
                //return amount;

            }
        }
    }
}


using System;

namespace OOP
{
    class Student
    {
        public int sid;
        string Name;
        double M1, M2;

        public void CreateStudent(int id, string name)
        {
            sid = id;
            Name = name;
        }

        public void SetMarks(double m1, double m2)
        {
            M1 = m1;
            M2 = m2;
        }

        public void Result()
        {
            double avg = (M1 + M2) / 2;
            if (avg >= 35)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("fail");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s;
            s = new Student();

            Console.WriteLine("Enter Studnet Id and Name: ");
            int id = int.Parse(Console.ReadLine());
            String name = Console.ReadLine();

            s.CreateStudent(id, name);//initialise object explicitly

            Console.WriteLine("Enter Marks 1 and Marks 2");
            double m1 = double.Parse(Console.ReadLine());
            double m2 = double.Parse(Console.ReadLine());

            s.SetMarks(m1, m2);

            s.Result();

            //reinitialise object - issue 2
            s.CreateStudent(200, "hans");

            //Student S1 = new Student();
            //S1.CreateStudent(200, "hans");

            Console.ReadLine();

        }
    }
}

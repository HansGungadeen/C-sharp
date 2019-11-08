using System;

namespace Constructors
{
    class Student
    {
        public int sid;
        string Name;
        double M1, M2;

        public Student()
        {
            Console.WriteLine("This is default constructor");
        }

        public Student(int id, string name)
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
            Student s = new Student(100, "hans");

            s.SetMarks(23, 45);

            s.Result();
            
            Console.ReadLine();

        }
    }
}

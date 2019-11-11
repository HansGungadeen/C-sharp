using System;

namespace overloaded_constructors
{
    class Student
    {
        public int Sid;
        string Name;
        double M1, M2;
        string Contact;

        public Student()
        {
            Console.WriteLine("This is default constructor");
        }

        public Student(int Sid, string Name):this()
        {
            this.Sid = Sid;
            this.Name = Name;
        }

        public Student(int Sid, string Name,string Contact):this(Sid,Name)
        {
            
            //this.Sid = Sid;
            //this.Name = Name;
            this.Contact = Contact;
        }

        public void SetMarks(double M1, double M2)
        {
            this.M1 = M1;
            this.M2 = M2;
        }

        public void GetDetails()
        {
            Console.WriteLine("Student ID:{0} Name:{1} Contact:{2}", Sid, Name, Contact);
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
            var s = new Student(100, "hans","7856325655");
            s.GetDetails();
            s.SetMarks(67, 78);
            s.Result();

            

           
            Console.ReadLine();

        }
    }
}

using System;

namespace Static_Polymorphism
{
    class Student
    {
        public int Sid;
        string Name;
        //contact, email, address....etc.

        public Student(int Sid, string Name)
        {
            this.Sid = Sid;
            this.Name = Name;
        }

        //public void getDetails()
        //{
        //    /*Console.WriteLine("Sid: {0} Name{1}",Sid,Name);*/
        //}

        public int getSid()
        {
            return Sid;
        }

        public string getName()
        {
            return Name;
        }

        public void setName(string Name)
        {
            if (Name.Length < 10)
            {
                this.Name = Name;
            }

        }

        public void setId(int Sid)
        {
            this.Sid = Sid;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var S = new Student(100, "Peter");
            S.setName("Peterrrrrrrr");
            int Sid = S.getSid();
            string Name = S.getName();



            Console.BackgroundColor = ConsoleColor.Blue;

            Console.WriteLine("Sid: {0} Name:{1}", Sid, Name);

            Console.ReadLine();
        }
    }
}


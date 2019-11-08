using System;

namespace Structures
{
    struct Student
    {
        public int StudentId;
        public string StudentName;
        public double avg;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s;
            s.StudentId = 7895412;
            s.StudentName = "Hans";
            s.avg = 878652.852;

            Console.WriteLine("Student ID: " + s.StudentId);
            Console.WriteLine("Student ID: " + s.StudentName);
            Console.WriteLine("Student ID: " + s.avg);

            Student[] SA = new Student[5];
            Random R = new Random();

            for (int i = 0; i<SA.Length; i++)
            {
                SA[i].StudentId = i + 1;
                SA[i].StudentName = Console.ReadLine();

                SA[i].avg = R.NextDouble() * 100;

            }

            //using foreach
            foreach(Student st in SA)
            {
                Console.WriteLine(st.StudentId);
                Console.WriteLine(st.StudentName);
                Console.WriteLine(st.avg);
            }
            Console.WriteLine("");
            Console.WriteLine("First Division student:");
            foreach (Student st in SA)
            {
                if (st.avg >= 60)
                {
                    Console.WriteLine(st.StudentId);
                    Console.WriteLine(st.StudentName);
                    Console.WriteLine(st.avg);
                }
                
            }
             
            Console.ReadLine();

        }
    }
}

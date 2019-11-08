using System;

namespace define_a_class
{
    class Student
    {
        private int sid;
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
}

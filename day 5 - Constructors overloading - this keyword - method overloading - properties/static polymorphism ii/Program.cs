using System;
using System.ComponentModel.DataAnnotations;

namespace static_polymorphism_ii
{
    //class Student
    //{
    //    int _Sid;
    //    string _Name;

    //    public Student(int _Sid, String _Name)
    //    {
    //        this._Sid = _Sid;
    //        this._Name = _Name;
    //    }

    //    public int Sid
    //    {
    //        set { _Sid = value; }
    //        get { return _Sid; }
    //    }

    //    public string Name
    //    {
    //        set 
    //        {
    //            if(value.Length <50)
    //                _Name = value; 
    //        }
    //        get { return _Name; }
    //    }



    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var S = new Student(100, "Peter");

    //        Console.WriteLine("Student ID:{0} Name:{1}",S.Sid,S.Name);

    //        S.Name = "pete";

    //        Console.ReadLine();
    //    }
    //}

        //using auto property

    class Student
    {
        [Required]
        public int Sid { get; set; }

        [Required]
        [MaxLength(50,ErrorMessage = "Max Length Should Be 50")]
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student();
            s.Sid = 100;
            s.Name = "Peter";

            Console.WriteLine("Student Id:{0} Name:{1}",s.Sid,s.Name);

            var s1 = new Student() { Sid = 200, Name = "Hans" };

            Console.WriteLine("Student Id:{0} Name:{1}", s1.Sid, s1.Name);


            Console.ReadLine();
        }
    }
}
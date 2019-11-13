using System;

namespace Interfaces
{
    interface IOperations
    {
        void GetAll();
        void GetById();
        void Create();
        void Update();
        void Delete();
    }

    interface IBulkOperations
    {
        void DeleteAll();
    }

    class Employees : IOperations,IBulkOperations
    {
        public void Create()
        {
            Console.WriteLine("Create Employee");        
        }

        public void Delete()
        {
            Console.WriteLine("Delete Employee");        
        }

        public void GetAll()
        {
            //entity Framework to read employees
            //data reader to read employee
            //data set read employees
            //xml file
            //Json data
            Console.WriteLine("Get All Employee");        
        }

        public void GetById()
        {
            Console.WriteLine("Get Employee by Id");        
        }

        public void Update()
        {
            Console.WriteLine("Update Employee");        
        }

        void IBulkOperations.DeleteAll()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //bulk operation
            IBulkOperations bulkOperations = new Employees();
            bulkOperations.DeleteAll();

            //operation
            IOperations operations;
            operations = new Employees();

            operations.GetAll();


            Console.ReadLine();
        }
    }
}

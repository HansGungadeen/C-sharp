using System;

namespace Static_Keywords
{
    class Program
    {
        class HousingLoanCustomer
        {
            int CustomerId;
            string Name;
            double LoanAmount;
            static double _ROI;//rate of interest

            public static double ROI
            {
                get { return _ROI; }
                set { _ROI = value; }
            }

            static HousingLoanCustomer()
            {
               _ROI = 11.2;
            }

            public HousingLoanCustomer(int CustomerId,string Name,double LoanAmount)
            {
                this.CustomerId = CustomerId;
                this.Name = Name;
                this.LoanAmount = LoanAmount;          
            }

            public void CalculateInterest(int months)
            {
                double IntAmount = LoanAmount * _ROI / 100;
                double RepayAmount = LoanAmount + IntAmount;
                Console.WriteLine("Loan Amount:{0} IntAmount:{1} RepayAmount:{2} ROI:{3}",LoanAmount,IntAmount,RepayAmount,_ROI);
                Console.WriteLine("EMI:" + (RepayAmount/months));
            }
            public static void Enquiry(double EnloanAmount,int months)
            {
                Console.WriteLine("ROI:" + ROI);
                Console.WriteLine("Loan Amount:" + EnloanAmount);
                Console.WriteLine("IntAmount:" + EnloanAmount * ROI / 100);
                Console.WriteLine("RepayAmount:" + (EnloanAmount + (EnloanAmount * ROI / 100)));
                Console.WriteLine("EMI Months:" + months);
                Console.WriteLine("EMIs:" + (EnloanAmount + (EnloanAmount * ROI / 100)) / months);
            }
        }
        static void Main(string[] args)
        {
            var loanCustomer1 = new HousingLoanCustomer(1, "Hans", 75000);
            loanCustomer1.CalculateInterest(12);

            var loanCustomer2 = new HousingLoanCustomer(2, "aserh", 78956);
            loanCustomer2.CalculateInterest(24);

            HousingLoanCustomer.ROI = 11.5;
            loanCustomer1.CalculateInterest(12);
            loanCustomer2.CalculateInterest(24);

            HousingLoanCustomer.Enquiry(60000, 24);


            Console.ReadLine();
        }
    }
}

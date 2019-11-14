using System;

namespace BLL
{
    public class Calculate
    {
        public static double Divide(int a,int b)
        {
            try
            {
                return a / b;

            }

            catch(Exception E)
            {
                throw new Exception("Invalid Second Param or b value cannot be zero:");
            }

        }
    }
}

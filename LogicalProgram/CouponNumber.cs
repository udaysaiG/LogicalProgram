using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class CouponNumber
    {
        static int GenerateCouponNumber(int n)
        {
            return random.Next(1, n + 1);
        }

  
        static int GetTotalRandomNumbersNeeded(int n)
        {
            bool[] coupons = new bool[n];  
            int count = 0;  
            int distinctCount = 0;  

            while (distinctCount < n)
            {
                int couponNumber = GenerateCouponNumber(n); 

                if (!coupons[couponNumber - 1])
                {
                    coupons[couponNumber - 1] = true;  
                    distinctCount++;  
                }

                count++;  
            }

            return count;
        }

        // This is the main function which takes the input and calls the GetTotalRandomNumbersNeeded function
        public static void Main()
        {
            Console.Write("Enter the number of distinct coupon numbers: ");
            int n = int.Parse(Console.ReadLine());

            int totalRandomNumbersNeeded = GetTotalRandomNumbersNeeded(n);

            Console.WriteLine("Total random numbers needed to have all distinct coupon numbers: " + totalRandomNumbersNeeded);


        }
}
    }




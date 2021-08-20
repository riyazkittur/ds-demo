using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the number below ");
            //int number =Convert.ToInt32( Console.ReadLine());
            //long result = fast_exp(number, 10);
            //Console.WriteLine($"Result is {result}");

            EuclidGCD gcd = new EuclidGCD();
          // int result= gcd.Find_GCD(170,25);
           int recur_result= gcd.Find_GCD_recursive(3,5);

            int[] arr = new int[] { 2, 3,4, 6, 8 };
            int result = arr[0];
            for(int i = 0; i<arr.Length; i++)
            {
                result = gcd.Find_GCD_recursive(result, arr[i]);
                if (result == 1)
                {
                    break;
                }
            }
            Console.WriteLine($"Result is {result}");
            Console.ReadKey();

        }
        static long  fast_exp(int base_num, int exp)
        {
            if (exp == 1)
            {
                return base_num;
            }
            else
            {
                if (exp % 2 == 0)
                {
                    long base1 = Convert.ToInt64(Math.Pow(fast_exp(base_num, exp / 2), 2));
                    if (base1 >= 1000000007)
                        return base1 % 1000000007;
                    else
                        return base1;

                }
                else
                {
                    long base1 = Convert.ToInt64(base_num * Math.Pow(fast_exp(base_num, (exp - 1) / 2), 2));
                    if (base1 >= 1000000007)
                        return base1 % 1000000007;
                    else
                        return base1;
                }
            }
         
        }
    }
}

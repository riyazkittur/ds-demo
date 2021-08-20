using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations
{
    public class EuclidGCD
    {
       public int Find_GCD(int a, int b)
        {
            while (b != 0)
            {
                int remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }
        public int Find_GCD_recursive(int a, int b)
        {
            return b==0?a: Find_GCD_recursive(b,a%b);
        }
    }
}

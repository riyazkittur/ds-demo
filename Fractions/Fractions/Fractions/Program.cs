using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 6;

            // Numerator Array 
            int[] num = { 1,2,3,4,0};

            // Denominator Array 
            int[] den = { 2,3,6,8,4};
            Solution sol = new Solution();
            int count = sol.solution(num, den);


        }
    }
}

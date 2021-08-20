using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    public  class Solution
    {
       
        public int gcd(int a, int b)
        {
            if (b == 0)
                return a;

            return gcd(b, a % b);
        }
        public  int solution(int[] X,
                                int[] Y)
        {
            int count = 0;
            int N = X.Length;
            // Hash-map to store the fractions 
            // in its lowest form 
            Dictionary<Fraction, int> mp = new Dictionary<Fraction, int>();

            // Loop to iterate over the  
            // fractions and store is lowest 
            // form in the hash-map 
            for (int i = 0; i < N; i++)
            {

                // To find the Lowest form 
                int numer = X[i] / gcd(X[i], Y[i]);
                int denom = Y[i] / gcd(X[i], Y[i]);
                Fraction tmp = new Fraction(numer, denom);
                if(mp.Keys.Where(f=>f.Numerator==numer && f.Denominator==denom).FirstOrDefault()!=null)
                {
                    if (count == 0)
                    {
                        count += 2;
                    }
                    else
                    {
                        count += 1;
                    }
                   
                }
                mp.Add(tmp, 1);
            }
            return count==0?1: count;
        }
    }

    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        public Fraction(int num, int den)
        {
            this.Numerator = num;
            this.Denominator = den;
        }
    }
}

using System;
using System.Linq;

namespace ArraysCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string arrayString = Console.ReadLine();
            if (String.IsNullOrEmpty(arrayString))
            {
                Console.WriteLine(N);
            }
            else
            {
                string[] arr = arrayString.Split(' ');
                int[] intArray = (from e in arr
                                  select Convert.ToInt32(e)).ToArray();
                Console.WriteLine(FindMissingOdd(intArray));
            }
            
        }


        static int findBracketSequences(string input)
        {
            int left_bracket = 0;
            int right_bracket = 0;
            foreach( char c in input)
            {
                if (c == '(')
                {
                    left_bracket += 1;
                }
                else
                {
                    right_bracket += 1;
                }
            
                if(left_bracket!=0 && right_bracket!=0)
            return Math.Min(left_bracket, right_bracket);
        }

        static ulong FindMissingOdd(int[] array)
        {
                ulong missingNum = 1;
                ulong count = Convert.ToUInt64(array.Length);
                ulong actualSum = 0;
                if (count == 0)
                {
                    return missingNum;
                }
                ulong sum = (count + 1) * (count + 1);
                for (int i = 0; i < array.Length; i++)
                {
                    actualSum += Convert.ToUInt64(array[i]);
                }

                return sum - actualSum;
            }

        static int MostFrequentNumber(int[] array)
        {
            if (array.Length == 1)
            {
                return array[0];
            }
            else
            {
                var countData = (from num in array
                             group num by num into g
                             select new
                             {
                                 key = g.Key,
                                 count = g.Count()
                             }).ToList();
                int max = countData.Select(x => x.count).Max();
                return countData.Where(c => c.count == max).Select(x => x.key).Min();
              

            }
        }
    }
}

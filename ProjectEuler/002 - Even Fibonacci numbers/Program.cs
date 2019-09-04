using System;
using System.Numerics;
class Solution
{

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            long n = Convert.ToInt64(Console.ReadLine());

            long prev = 1, current = 1;

            BigInteger totalSum = 0;

            for (long fibSum = 1; fibSum < n;)
            {
                if (fibSum % 2 == 0)
                {
                    totalSum += fibSum;
                }

                fibSum = prev + current;
                prev = current;
                current = fibSum;
            }

            Console.WriteLine(totalSum);
        }
    }
}
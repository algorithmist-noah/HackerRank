using System;
using System.Numerics;
class Solution
{
    static void Main(String[] args)
    {
        BigInteger totalSum = 0;

        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int modifiedN = n - 1;

            BigInteger factor3 = modifiedN / 3;
            BigInteger factor5 = modifiedN / 5;
            BigInteger factor15 = modifiedN / 15;


            totalSum += 3 * (factor3 * (factor3 + 1) / 2);

            totalSum += 5 * (factor5 * (factor5 + 1) / 2);

            totalSum -= 15 * (factor15 * (factor15 + 1) / 2);

            Console.WriteLine(totalSum);

            totalSum = 0;
        }
    }
}
using System;
using System.Numerics;
class Solution
{

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            BigInteger totalSum = 0;

            BigInteger factor3 = (n - 1) / 3;
            BigInteger factor5 = (n - 1) / 5;
            BigInteger factor15 = (n - 1) / 15;


            totalSum += 3 * (factor3 * (factor3 + 1) / 2);

            totalSum += 5 * (factor5 * (factor5 + 1) / 2);

            totalSum -= 15 * (factor15 * (factor15 + 1) / 2);

            Console.WriteLine(totalSum);
        }
    }
}
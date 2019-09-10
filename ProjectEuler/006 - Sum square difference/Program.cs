using System;
class Solution
{
    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            long partialProduct = n * (n + 1) / 2;

            long squareDifference = (long)Math.Pow(partialProduct, 2) - partialProduct * (2 * n + 1) / 3;

            Console.WriteLine(squareDifference);
        }
    }
}
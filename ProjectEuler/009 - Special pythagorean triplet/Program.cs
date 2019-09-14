using System;
class Solution
{
    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int a0 = 0; a0 < t; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(FindLargestProduct(n));
        }
    }

    static long FindLargestProduct(int n)
    {
        long largestProduct = -1;

        int limit = n / 3;

        for (int a = 1; a <= limit; a++)
        {
            int b = (2 * n * a - (n * n)) / (2 * (a - n));
            int c = n - b - a;

            if ((a * a) + (b * b) == c * c)
            {
                long tempProduct = a * b * c;

                if (tempProduct > largestProduct)
                {
                    largestProduct = tempProduct;
                }
            }
        }

        return largestProduct;
    }
}
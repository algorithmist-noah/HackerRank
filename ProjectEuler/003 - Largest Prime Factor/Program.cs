using System;
class Solution
{
    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            long n = Convert.ToInt64(Console.ReadLine());

            var limit = Math.Sqrt(n) + 1;

            if (n % 2 == 0)
            {
                while (n % 2 == 0)
                {
                    n /= 2;
                }
            }

            for (long i = 3; i < limit; i += 2)
            {
                while (n % i == 0 && i != n)
                {
                    n /= i;
                }
            }

            Console.WriteLine(n);
        }
    }
}
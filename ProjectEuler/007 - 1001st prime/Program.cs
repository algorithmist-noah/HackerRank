using System;
using System.Collections.Generic;
class Solution
{
    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        List<int> primes = new List<int>() { 2, 3 };

        for (int a0 = 0; a0 < t; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (var i = primes[primes.Count - 1] + 2; primes.Count < n; i += 2)
            {
                bool isPrime = true;

                var j = 1;
                var sqrti = Math.Sqrt(i);

                for (; j < primes.Count && isPrime && primes[j] <= sqrti;)
                {
                    if (i % primes[j] == 0)
                    {
                        isPrime = false;
                    }
                    else
                    {
                        j++;
                    }
                }

                if (isPrime)
                {
                    primes.Add(i);
                }
            }

            Console.WriteLine(primes[n - 1]);
        }
    }
}
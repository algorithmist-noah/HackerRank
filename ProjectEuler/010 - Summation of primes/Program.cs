using System;
using System.Collections.Generic;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        List<int> primes = new List<int>() { 2, 3 };

        for (int a0 = 0; a0 < t; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            long sum = 0;

            var isDone = false;

            if (n < 2)
            {
                isDone = true;
            }
            else if (n == 2)
            {
                sum = 2;
                isDone = true;
            }
            else if (n == 3)
            {
                sum = 5;
                isDone = true;
            }
            else
            {
                foreach (var prime in primes)
                {
                    if (prime <= n)
                    {
                        sum += prime;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (var i = primes[primes.Count - 1] + 2; !isDone; i += 2)
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
                    if (i <= n)
                    {
                        primes.Add(i);
                        sum += i;
                    }
                    else
                    {
                        isDone = true;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
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

            BigInteger smallestMultiple = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    var k = smallestMultiple * j;

                    if (k % i == 0)
                    {
                        smallestMultiple = k;
                        break;
                    }

                    if (j == i - 1)
                    {
                        smallestMultiple = i * smallestMultiple;
                    }
                }
            }

            Console.WriteLine(smallestMultiple);
        }
    }
}
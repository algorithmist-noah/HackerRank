using System;
using System.Numerics;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                long n = Convert.ToInt64(Console.ReadLine());

                //1,2,3,5,8,13,21,34,55,89,144,233,377,610
                //2,8,34,144,610
                //2,5,8,11,14

                BigInteger fibSum = 1, prev = 1, current = 1;

                for (long i = 1; i < n; i++)
                {
                    fibSum = prev + current;
                    prev = current;
                    current = fibSum;
                }
            }
        }
    }
}
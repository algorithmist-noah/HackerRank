using System;

namespace TestProject
{
    class Program
    {
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int smallestMultiple = n;

                for (int i = n - 1; i >= 1;)
                {
                    if (smallestMultiple % i != 0)
                    {
                        smallestMultiple += n;
                        i = n - 1;
                    }
                    else
                    {
                        i--;
                    }
                }

                Console.WriteLine(smallestMultiple);
            }
        }
    }
}
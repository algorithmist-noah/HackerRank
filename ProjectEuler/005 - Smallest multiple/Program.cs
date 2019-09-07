using System;
class Solution
{

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int smallestMultiple = n;

            int limitStartingPoint = n - 1;

            for (int i = limitStartingPoint; i > 1;)
            {
                if (smallestMultiple % i != 0)
                {
                    smallestMultiple += n;
                    i = limitStartingPoint;
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
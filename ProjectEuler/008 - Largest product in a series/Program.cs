using System;
using System.Collections.Generic;
class Solution
{
    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int a0 = 0; a0 < t; a0++)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string num = Console.ReadLine();

            long largestProduct = 0;

            List<byte> numList = new List<byte>();

            for (int i = 0; i < n; i++)
            {
                numList.Add((byte)char.GetNumericValue(num[i]));

                if (numList.Count == k)
                {
                    long tempProduct = 1;
                    numList.ForEach(subNum => tempProduct *= subNum);

                    if (tempProduct > largestProduct)
                    {
                        largestProduct = tempProduct;
                    }

                    numList.RemoveAt(0);
                }
            }

            Console.WriteLine(largestProduct);

            numList.Clear();
        }
    }
}
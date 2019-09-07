using System;
class Solution
{
    static bool CheckIfPalindome(string str)
    {
        var isPalindrome = true;

        for (int i = 0, j = str.Length - 1; i < j; i++, j--)
        {
            if (str[i] != str[j])
            {
                return false;
            }
        }

        return isPalindrome;
    }

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            var largestPalindrome = 101101;

            for (int i = 100; i < 999; i++)
            {
                for (int j = 100; j < 999; j++)
                {
                    var multiple = i * j;

                    if (multiple > largestPalindrome && multiple < n && CheckIfPalindome(multiple.ToString()))
                    {
                        largestPalindrome = multiple;
                    }
                }
            }

            Console.WriteLine(largestPalindrome);
        }
    }
}
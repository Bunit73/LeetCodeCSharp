// https://leetcode.com/problems/palindrome-number/

Console.WriteLine(Solution.IsPalindrome(1091));

public class Solution
{
    public static bool IsPalindrome(int x)
    {
        var numStr = x.ToString();

        if (x < 0)
        {
            return false;
        }

        if (numStr.Length == 1)
        {
            return true;
        }

        var endVal = numStr.Length -1;
        for (var i = 0; i < numStr.Length; i++)
        {
            if (numStr[i] != numStr[endVal])
            {
                return false;
            }

            endVal--;
        }

        return true;

    }
}
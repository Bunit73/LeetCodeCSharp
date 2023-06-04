// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

// https://leetcode.com/problems/palindrome-number/

Console.WriteLine(Solution.StrStr("sadbutsad","sad").ToString());

public class Solution
{
    public static int StrStr(string haystack, string needle)
    {
        return haystack.IndexOf(needle);

    }
}
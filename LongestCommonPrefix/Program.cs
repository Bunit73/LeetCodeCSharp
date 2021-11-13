// See https://aka.ms/new-console-template for more information

using System.Text;

var strs = new[] {"dog","racecar","car"};

Console.WriteLine(Solution.LongestCommonPrefix(strs));

public class Solution {
    public static string LongestCommonPrefix(string[] strs)
    {

        if (strs.Length == 0)
        {
            return "";
        }

        if (strs.Length == 1)
        {
            return strs[0];
        }

        var retval = strs[0];
        
        foreach (var str in strs)
        {
            if (str.Length < retval.Length)
            {
                retval = retval.Substring(0, str.Length);   
            }
            for (var s = 0; s < retval.Length; s++)
            {
                if (retval[s] != str[s])
                {
                    retval = retval.Substring(0, s);
                    if (retval.Length == 0)
                    {
                        return "";
                    }
                    break;
                }
            }
        }

        return retval;
    }
}
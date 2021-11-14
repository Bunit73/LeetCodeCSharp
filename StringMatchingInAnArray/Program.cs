// https://leetcode.com/problems/string-matching-in-an-array/

var arr = new[] {"leetcoder", "leetcode", "od", "hamlet", "am"};


foreach (var s in Solution.StringMatching(arr))
{
    Console.WriteLine(s);
}


public class Solution {
    public static IList<string> StringMatching(string[] words)
    {
        var retval = new List<string>();
        if (words.Length == 0)
        {
            return retval;
        }
        
        Array.Sort(words, (x1, x2) => x1.Length.CompareTo(x2.Length));


        for (var i = 0; i < words.Length; i++)
        {
            for (var j = i + 1; j < words.Length; j++)
            {
                if (words[j].Contains(words[i]))
                {
                    if (!retval.Contains(words[i]))
                    {
                        retval.Add(words[i]);    
                    }
                    
                }
            }
        }

        return retval;
    }
}
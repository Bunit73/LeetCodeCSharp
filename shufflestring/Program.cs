// See https://aka.ms/new-console-template for more information

using System.Text;

int[] arr = {4,5,6,7,0,2,1,3};
string str = "codeleet";

Console.WriteLine(Solution.RestoreString(str, arr));

public class Solution {
    public static string RestoreString(string s, int[] indices)
    {
        StringBuilder retval = new StringBuilder(s);
        var cntr = 0;
        foreach (var i in indices)
        {
            retval[i] = s[cntr];
            cntr++;
        }

        return retval.ToString();
    }
}
// See https://aka.ms/new-console-template for more information

int[] arr = {1,2,3,4};

Array.ForEach(Solution.RunningSum(arr), Console.WriteLine);

public class Solution
{
    public static int[] RunningSum(int[] nums)
    {
        int[] retval = new int[nums.Length];
        var runsum = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            runsum += nums[i];
            retval[i] = runsum;
        }

        return retval;
    }
}
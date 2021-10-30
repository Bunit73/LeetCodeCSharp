// See https://aka.ms/new-console-template for more information

using System;

int[] arr = {3,2,4};
int target = 6;


Array.ForEach(Solution.TwoSum(arr, target), Console.WriteLine);

public class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var len = nums.Length;
        int[] retval = {0,1};
        
        if (len == 2)
        {
            return retval;
        }

        for (var i = 0; i < len - 1; i++)
        {
            for (var j = i + 1; j < len; j++)
            {
                if (nums[i] + nums[j] != target) continue;
                retval[0] = i;
                retval[1] = j;

            }
        }

        return retval;
    }
}


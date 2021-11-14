// https://leetcode.com/problems/number-of-students-doing-homework-at-a-given-time/


var start = new[] {1,2,3};
var end = new[] {3,2,7};
var hr = 4;

Console.WriteLine(Solution.BusyStudent(start,end, hr));

public class Solution {
    public static int BusyStudent(int[] startTime, int[] endTime, int queryTime)
    {
        var retval = 0;

        for (var i = 0; i < startTime.Length; i++)
        {
            if ((startTime[i] <= queryTime) && (endTime[i] >= queryTime))
            {
                retval++;
            }
        }

        return retval;
    }
}
// https://leetcode.com/problems/daily-temperatures/

int[] arr = {73,74,75,71,69,72,76,73};


Array.ForEach(Solution.DailyTemperatures(arr), Console.WriteLine);

public class Solution
{
    public static int[] DailyTemperatures(int[] temperatures)
    {
        int[] retavl = new int[temperatures.Length];
        var daysUntilGreaterTemp = 0;
        var currentTemp = 0;

        for (var i = 0; i < temperatures.Length; i++)
        {
            retavl[i] = 0;
            daysUntilGreaterTemp = 0;
            currentTemp = temperatures[i];
            for (var j = i + 1; j < temperatures.Length; j++)
            {
                daysUntilGreaterTemp++;
                if (temperatures[j] > currentTemp)
                {
                    retavl[i] = daysUntilGreaterTemp;
                    break;
                }   
            }
        }

        return retavl;
    }
}
// See https://aka.ms/new-console-template for more information

public class Solution {
    public static int MaximumWealth(int[][] accounts)
    {
        var maxWealth = 0;
        var currentWealth = 0;

        foreach (var account in accounts)
        {
            currentWealth = 0;
            foreach (var val in account)
            {
                currentWealth += val;
            }

            if (currentWealth > maxWealth)
            {
                maxWealth = currentWealth;
            }
        }

        return maxWealth;
    }
}
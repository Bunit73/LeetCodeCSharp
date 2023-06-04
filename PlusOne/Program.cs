// https://leetcode.com/problems/plus-one/

int[] arr = {8,9,9};

//https://leetcode.com/problems/plus-one/submissions/958509033/
Console.WriteLine(string.Join(", ", Solution.PlusOne(arr)));

public class Solution
{
    public static int[] PlusOne(int[] digits)
    {
        
        for (var i = digits.Length - 1; i >= 0; i--)
        {
            var tempval = digits[i] + 1;
        
            // easy case
            if (tempval < 10)
            {
                digits[i] = tempval;
                return digits;
            }

            // if we're at the start of the array push a new value on
            if (i == 0)
            {
                // resize array
                Array.Resize(ref digits, digits.Length + 1);
                i += 1;
                digits[i] = 0;
                digits[i - 1] = 1;
                // break out
                return digits;
            }
            else
            {
                // tempval = digits[i - 1] + 1;
                // digits[i - 1] = tempval;
                // set value to 0
                digits[i] = 0;
            }
        }

        return digits;
    }
}
public class Solution {
    public int[] SingleNumber(int[] nums)
    {
        var len = nums.Length;
        IDictionary<int, int> numberCountDictionary = new Dictionary<int, int>();
        int[] retval = {0,0};
        
        // Short circuit result
        if (len == 2)
        {
            return nums;
        }

        // creat dict of num counts
        foreach (var num in nums)
        {
            if (numberCountDictionary.ContainsKey(num))
            {
                numberCountDictionary[num] += 1;
            }
            else
            {
                numberCountDictionary.Add(num,1);   
            }
        }
        
        // get bottom two vals
        var firstValfound = false;
        foreach (var kv in numberCountDictionary)
        {
            if (kv.Value == 1)
            {
                if (firstValfound)
                {
                    retval[1] = kv.Key;
                }
                else
                {
                    retval[0] = kv.Key;
                    firstValfound = true;
                }
            }
        }

        return retval;
    }
}
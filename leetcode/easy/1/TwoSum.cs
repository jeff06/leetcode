using System.Collections;

namespace leetcode.easy._1;

public static class TwoSum
{
    public static int[] Run(int[] nums, int target)
    {
        Dictionary<int, int> numIndexMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if (numIndexMap.TryGetValue(diff, out var value))
            {
                return [value, i];
            }
            numIndexMap[nums[i]] = i;
        }
        return [];
    }
}
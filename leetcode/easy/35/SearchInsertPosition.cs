using System.Diagnostics;

namespace leetcode.easy._35;

public class SearchInsertPosition
{
    public int Run(int[] nums, int target)
    {
        if (nums.Length == 0) return 0;
        int left = 0;
        int right = nums.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            if (nums[mid] < target)
            {
                // in the right section
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        
        return left;
    }

    public void Test()
    {
        List<TestCase> lst =
        [
            new TestCase([1,3], 4, 2),
            new TestCase([1,3], 2, 1),
            new TestCase([1,3,5], 4, 2),
            new TestCase([1,3,4], 2, 1),
            new TestCase([], 3, 0),
            new TestCase([1], 3, 1),
            new TestCase([1], 0, 0),
            new TestCase([1, 3, 5, 6], 3, 1),
            new TestCase([1, 3, 5, 6], 0, 0),
            new TestCase([1, 3, 5, 6], 2, 1),
            new TestCase([1, 3, 5, 6], 7, 4)
        ];

        for (int i = 0; i < lst.Count; i++)
        {
            int output = Run(lst[i].Nums, lst[i].Target);
            Console.WriteLine($"{i} - {output} - {lst[i].ExpectedValue}");
            Debug.Assert(output == lst[i].ExpectedValue);
        }
    }

    public class TestCase(int[] nums, int target, int expectedValue)
    {
        public int[] Nums { get; set; } = nums;
        public int Target { get; set; } = target;
        public int ExpectedValue { get; set; } = expectedValue;
    }
}
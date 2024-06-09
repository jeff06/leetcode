using System.Diagnostics;

namespace leetcode.medium._81;

public class SearchInRotatedSortedArrayII
{
    public bool Run(int[] nums, int target)
    {
        //#1 find pivot
        //#2 
        return true;
    }

    public void Test()
    {
        List<TestClass> lst =
        [
            new TestClass([2, 5, 6, 0, 0, 1, 2], 0, true),
            new TestClass([2, 5, 6, 0, 0, 1, 2], 3, false),
        ];

        for (int i = 0; i < lst.Count; i++)
        {
            bool output = Run(lst[i].Nums, lst[i].Target);
            Console.WriteLine(i);
            Debug.Assert(output == lst[i].Output);
        }
    }

    public class TestClass(int[] nums, int target, bool output)
    {
        public int[] Nums { get; set; } = nums;
        public int Target { get; set; } = target;
        public bool Output { get; set; } = output;
    }
}
using System.Diagnostics;

namespace leetcode.medium._3;

public class LongestSubstringWithoutRepeatingCharacters : BaseTemplate<int, string>
{
    public override void Test()
    {
        Dictionary<string, int> lstTest = new Dictionary<string, int>();
        lstTest.Add("bbtablud", 4);
        lstTest.Add("qwe", 3);
        lstTest.Add("abcabcbb", 3);
        lstTest.Add("bbbbb", 1);
        lstTest.Add("pwwkew", 3);
        lstTest.Add("", 0);
        lstTest.Add("1", 1);
        lstTest.Add("dvdf", 3);
        lstTest.Add("dv", 2);
        lstTest.Add("vv", 1);
        foreach (var v in lstTest)
        {
            int res = Run(v.Key);
            Debug.Assert(res == v.Value);
            Console.WriteLine(v.Key);
        }
    }

    public override int Run(string val)
    {
        //"pwwkew"
        Dictionary<char, int> dict = new Dictionary<char, int>();
        int count = 0;
        int max = 0;
        for (int i = 0; i < val.Length; i++)
        {
            bool shouldAdd = true;
            if (dict.TryGetValue(val[i], out var value))
            {
                //Remove the first char in dict i
                if (value == 0)
                {
                    count = dict.Count;
                    dict.Remove(val[i]);
                }
                else
                {
                    dict = new Dictionary<char, int>();
                    dict[val[i]] = i;
                    shouldAdd = false;
                    if (count > max)
                    {
                        max = count;
                        count = 1;
                    }
                }
            }
            else
            {
                //add count
                count++;
            }

            if (shouldAdd) dict[val[i]] = i;
        }

        if (count > max)
        {
            max = count;
        }

        return max;
    }
}
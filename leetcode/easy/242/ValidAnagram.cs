using System.Diagnostics;

namespace leetcode.easy._242;

public class ValidAnagram
{
    public bool Run(string s, string t)
    {
        if (s.Length != t.Length) return false;
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach (var v in s)
        {
            //la lettre existe
            if (dict.TryGetValue(v, out int count))
            {
                dict[v] = count + 1;
            }
            else
            {
                dict[v] = 1;
            }
        }

        foreach (var v in t)
        {
            //la lettre existe
            if (dict.TryGetValue(v, out int count))
            {
                int newCount = count - 1;
                if (newCount < 0) return false;

                dict[v] = count - 1;
            }
            else
            {
                return false;
            }
        }

        return true;
    }

    public void Test()
    {
        List<TestingClass> lstTest =
        [
            new TestingClass("anagram", "nagaram", true),
            new TestingClass("patate", "jambon", false),
        ];
        foreach (var v in lstTest)
        {
            bool res = Run(v.s, v.t);
            Debug.Assert(res == v.expected);
            Console.WriteLine(v.s);
        }
    }

    private class TestingClass(string s, string t, bool expected)
    {
        public string s { get; set; } = s;
        public string t { get; set; } = t;
        public bool expected { get; set; } = expected;
    }
}
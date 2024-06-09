namespace leetcode.easy._344;

public class ReverseString
{
    public void Run(char[] s)
    {
        int l = s.Length;
        double asd = l / 2;
        int halfLenght = Convert.ToInt32(Math.Floor(asd));
        for (int i = 0; i < halfLenght; i++)
        {
            (s[i], s[l - 1 - i]) = (s[l - 1 - i], s[i]);
        }
    }
}
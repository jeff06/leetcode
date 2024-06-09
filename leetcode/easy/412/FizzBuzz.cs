namespace leetcode.easy._412;

//FizzBuzz.Run(15).ForEach(Console.WriteLine);
public class FizzBuzz
{
    public static List<string> Run(int n)
    {
        List<string> lst = [];
        for (int i = 1; i <= n; i++)
        {
            if (i % 15 == 0) lst.Add("FizzBuzz");
            else if (i % 5 == 0) lst.Add("Buzz");
            else if (i % 3 == 0) lst.Add("Fizz");
            else lst.Add(i.ToString());
        }

        return lst;
    }
}
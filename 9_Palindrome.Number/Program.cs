var x = -121;
var solution = new Solution();
Console.WriteLine(solution.IsPalindrome(x));

public class Solution
{
    public bool IsPalindrome(int x)
    {
        var stringX = x.ToString();

        for (int i = 0; i < stringX.Length; i++)
        {
            if (stringX[i] != stringX[^(i+1)])
            {
                return false;
            }
        }

        return true;
    }

    public bool IsPalindromeNoString(int x)
    {
        if (x < 0) return false;

        var list = new List<int>();

        while (x > 0)
        {
            list.Add(x % 10);
            x = x / 10;
        }

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] != list[^(i + 1)])
            {
                return false;
            }
        }

        return true;
    }
}
var test = "babad";
var solution = new Solution();
Console.WriteLine(solution.LongestPalindrome(test));

public class Solution
{
    public string LongestPalindrome(string s)
    {
        var length = s.Length;
        if (length == 0) return string.Empty;

        var isPalindromeMatrix = new bool[length, length];
        var maxLength = 1;
        var start = 0;

        for (int i = 0; i < length; i++)
        {
            isPalindromeMatrix[i, i] = true;
        }

        for (int i = 0; i < length - 1; i++)
        {
            if (s[i] == s[i + 1])
            {
                isPalindromeMatrix[i, i + 1] = true;
                start = i;
                maxLength = 2;
            }
        }

        for (int centre = 3; centre <= length; centre++)
        {
            for (int left = 0; left < length - centre + 1; left++)
            {
                int right = left + centre - 1;

                if (isPalindromeMatrix[left + 1, right - 1] && s[left] == s[right])
                {
                    isPalindromeMatrix[left, right] = true;

                    if (centre > maxLength)
                    {
                        start = left;
                        maxLength = centre;
                    }
                }
            }
        }

        return s.Substring(start, maxLength);
    }
}
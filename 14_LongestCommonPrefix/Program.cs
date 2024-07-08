var solution = new Solution();
var strings = new string[] {"ab", "a" };
Console.WriteLine($"Answer: {solution.LongestCommonPrefix(strings)}");

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0) return string.Empty;
        if (strs.Length == 1) return strs[0];

        var longestPrefix = strs[0];

        for (int i = 1; i < strs.Length; i++) {
            var word = strs[i];

            for (int j = 0; j < longestPrefix.Length; j++)
            {
                if (j >= word.Length)
                {
                    longestPrefix = word;
                    break;
                }

                if (longestPrefix[j] != word[j])
                {
                    longestPrefix = longestPrefix.Substring(0,j);
                }
            }
        }

        return longestPrefix;
    }
}
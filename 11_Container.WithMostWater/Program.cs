int[] test1 = [1, 8, 6, 2, 5, 4, 8, 3, 7];
var solution = new Solution();

Console.WriteLine(solution.MaxArea(test1));

public class Solution
{
    public int MaxArea(int[] height)
    {
        var maxArea = 0;
        var left = 0;
        var right = height.Length - 1;

        while (left < right)
        {
            var area = Math.Min(height[left], height[right]) * (right - left);
            maxArea = Math.Max(maxArea, area);

            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }
}
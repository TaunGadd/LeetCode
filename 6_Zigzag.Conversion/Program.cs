
var input1 = "PAYPALISHIRING";
var input2 = 3;

var solution = new Solution();
Console.WriteLine(solution.Convert(input1, input2));


public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1) return s;

        var lists =  new string[numRows];
        int counter = 0;
        bool increasing = true;

        foreach (var letter in s)
        {
            if (counter <= 0)
            {
                increasing = true;
            }
            else if (counter >= numRows - 1)
            {
                increasing = false;
            }

            lists[counter] = lists[counter] + letter;

            if (increasing)
            {
                counter++;
            }
            else
            {
                counter--;
            }
        }

        return string.Join(string.Empty, lists);
    }
}
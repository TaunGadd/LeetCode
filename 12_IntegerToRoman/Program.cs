using System.Text;

var solution = new Solution();
Console.WriteLine(solution.IntToRoman(5));

public class Solution
{
    private StringBuilder roman;

    public string IntToRoman(int num)
    {
        roman = new StringBuilder();

        // M
        var _1000s = num / 1000;
        num = num - (_1000s * 1000);

        // D
        var _500s = num - 500 >= 0 ? 1 : 0;
        num = num - (_500s * 500);

        // C
        var _100s = num / 100;
        num = num - (_100s * 100);

        // L
        var _50s = num - 50 >= 0 ? 1 : 0;
        num = num - (_50s * 50);

        // X
        var _10s = num / 10;
        num = num - (_10s * 10);

        // V
        var _5s = num - 5 >= 0 ? 1 : 0;
        num = num - (_5s * 5);

        // I
        var _1s = num;

        // Assemble
        AppendTimes("M", _1000s);

        if (_500s == 1 && _100s == 4)
        {
            AppendTimes("CM", 1);
        } 
        else if (_500s == 0 && _100s == 4)
        {
            AppendTimes("CD", 1);
        }
        else
        {
            AppendTimes("D", _500s);
            AppendTimes("C", _100s);
        }

        if (_50s == 1 && _10s == 4)
        {
            AppendTimes("XC", 1);
        }
        else if (_50s == 0 && _10s == 4)
        {
            AppendTimes("XL", 1);
        }
        else
        {
            AppendTimes("L", _50s);
            AppendTimes("X", _10s);
        }

        if (_5s == 1 && _1s == 4)
        {
            AppendTimes("IX", 1);
        }
        else if (_5s == 0 && _1s == 4)
        {
            AppendTimes("IV", 1);
        }
        else
        {
            AppendTimes("V", _5s);
            AppendTimes("I", _1s);
        }

        return roman.ToString();
    }

    private void AppendTimes(string val, int times)
    {
        for (int i = 0; i < times; i++)
        {
            roman.Append(val);
        }
    }
}
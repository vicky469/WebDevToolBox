namespace LeetCode.Array_and_String.HashTable;

public class RomanToInteger_13
{
    int RomanToInt(string s)
    {
        var res = 0;
        var map = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        
        var prev = map[s[0]];
        res += prev;
        for (var i = 1; i < s.Length; i++)
        {
            var curr = map[s[i]];
            if (curr > prev)
            {
                res+= curr - prev - prev;
            }
            else
            {
                res+= curr;
            }

            prev = curr;
        }

        return res;
    }
    
    [Theory]
    [InlineData("III", 3)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    private void Test_OK(string s,  int expectedResult)
    {
        var res = RomanToInt(s);
        Assert.Equal(expectedResult, res);
    }
}
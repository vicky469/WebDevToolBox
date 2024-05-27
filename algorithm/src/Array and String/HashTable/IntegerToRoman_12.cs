using System.Text;

namespace LeetCode.Array_and_String.HashTable;

public class IntegerToRoman_12: TestBase
{
    string IntToRoman(int num) {
        var values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        var symbols = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        var res = new StringBuilder();
        for(int i = 0; i< values.Length; i++){
            while(num >= values[i]){
                num-= values[i];
                res.Append(symbols[i]);
            }
        }
        return res.ToString();
    }
    
    
    string IntToRoman_Log(int num) {
        // collect symbols and values including the special cases
        // need to be in descending order to make sure the largest value is used first
        var values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        var symbols = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        var roman = new StringBuilder();
        
        for (var i = 0; i < values.Length && num > 0; i++)
        {
            TestOutputHelper.WriteLine($"======     i = {i}, values[i] = {values[i]}, symbols[i] = {symbols[i]}      ======");
            // does num need more of this value?
            while (num >= values[i])
            {
                num -= values[i];
                TestOutputHelper.WriteLine($"num: {num.ToString()}");
                roman.Append(symbols[i]);
                TestOutputHelper.WriteLine($"roman: {roman}");
                TestOutputHelper.WriteLine("-----------------");
            }
        }

        return roman.ToString();
    }

    [Theory]
    [InlineData(3, "III")]
    [InlineData(58, "LVIII")]
    [InlineData(1994, "MCMXCIV")]
    [InlineData(2023, "MMXXIII")]
    [InlineData(3999, "MMMCMXCIX")]
    private void Test_OK(int num,  string expectedResult)
    {
        var res = IntToRoman(num);
        Assert.Equal(expectedResult, res);
    }

    public IntegerToRoman_12(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }
}
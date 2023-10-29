using System.Text;

namespace LeetCode;

public class GreatestCommonDivisorOfStrings_1071
{
    // we assume str2 is always shorter than str1
    // otherwise this program will not work correctly because gcd(int a, int b)
    private static string GcdOfStrings(string str1, string str2)
    {
        // O(n)
        var gcdLength = gcd(str1.Length, str2.Length);
        var gcdStr = str1.Substring(0, gcdLength);

        if (IsDivisibleStr(str1, gcdStr) && IsDivisibleStr(str2, gcdStr))
            return gcdStr;
        else
            return "";
    }

    static int gcd(int a, int b)
    {
        while (b != 0)
        {
            var tmp = a % b;
            a = b;
            b = tmp;
        }
        return a;
    }

    static bool IsDivisibleStr(string str, string pattern)
    {
        if (str.Length % pattern.Length != 0) return false;

        var repeats = str.Length / pattern.Length;
        var sb = new StringBuilder(str.Length);

        for (int i = 0; i < repeats; i++)
            sb.Append(pattern);

        return sb.ToString() == str;
    }
    
    
    [Theory]
    [InlineData("ABABAB", "ABAB", "ABAB")]
    public void Test_Debug(string str1, string str2, string expectedResult)
    {
        var result = GcdOfStrings(str1, str2);
        Assert.Equal(expectedResult, result);
    }
    
    [Theory]
    [InlineData("ABCABC", "ABC", "ABC")]
    [InlineData("ABABAB", "ABAB", "ABAB")]
    public void Test_OK(string str1, string str2, string expectedResult)
    {
        var result = GcdOfStrings(str1, str2);
        Assert.Equal(expectedResult, result);
    }
    
    [Theory]
    [InlineData("ABA", "ABABAB", "")]
    [InlineData("ABCABC", "ABCA", "")]
    public void Test_Fail(string str1, string str2, string expectedResult)
    {
        var result = GcdOfStrings(str1, str2);
        Assert.Equal(expectedResult, result);
    }
    
    [Theory]
    [InlineData("ABAB", "ABABAB", "AB")]
    public void Test_Experiment_Fail(string str1, string str2, string expectedResult)
    {
        var result = GcdOfStrings(str1, str2);
        Assert.Equal(expectedResult, result);
    }
}
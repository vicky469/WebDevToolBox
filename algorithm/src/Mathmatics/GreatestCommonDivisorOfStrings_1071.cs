using System.Text;

namespace LeetCode.Mathmatics;

/**
 * https://leetcode.com/problems/greatest-common-divisor-of-strings/
 * the input order doesn't mather, see: Test_Experiment_OK
 */
public class GreatestCommonDivisorOfStrings_1071
{
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
    
    // recursion
    static int GcdRecursion(int a, int b)
    {
        if (b == 0)
            return a;
        return GcdRecursion(b, a % b);
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
    [InlineData("ABCABC", "ABC", "ABC")]
    [InlineData("ABABAB", "ABAB", "AB")]
    [InlineData("ABAB", "ABABABAB", "ABAB")]
    private void Test_OK(string str1, string str2, string expectedResult)
    {
        var result = GcdOfStrings(str1, str2);
        Assert.Equal(expectedResult, result);
    }
    
    [Theory]
    [InlineData("ABA", "ABABAB", "")]
    [InlineData("ABCABC", "ABCA", "")]
    private void Test_Fail(string str1, string str2, string expectedResult)
    {
        var result = GcdOfStrings(str1, str2);
        Assert.Equal(expectedResult, result);
    }
}
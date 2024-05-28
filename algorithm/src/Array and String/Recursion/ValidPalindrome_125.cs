namespace LeetCode.Array_and_String.Recursion;

public class ValidPalindrome_125:TestBase
{
    static bool IsPalindromeRecursion(string s)
    {
        s = s.ToLower();
        s= new string(s.Where(char.IsLetterOrDigit).ToArray());
        return IsPalindromeHelper(s);
    }

    private static bool IsPalindromeHelper(string s)
    {
        if (s.Length == 0 || s.Length == 1)
        {
            return true;
        }
        var head = s[0];
        var tail = s[s.Length - 1];
        
        if (head != tail) return false;
        // keep shrinking, delete head and tail
        return IsPalindromeHelper(s.Substring(1, s.Length - 2));
    }

    [Theory]
    [InlineData(" ", true)]
    [InlineData("a", true)]
    [InlineData("a.", true)]
    [InlineData("ab", false)]
    [InlineData("abb", false)]
    [InlineData("0P", false)]
    [InlineData("aA", true)]
    [InlineData("level",true)]
    [InlineData("race a car",false)]
    [InlineData("race car",true)]
    [InlineData("A man, a plan, a canal: Panama",true)]
    private void Test_OK(string s, bool expectedResult)
    {
        var res = IsPalindromeRecursion(s);
        Assert.Equal(expectedResult, res);
    }

    public ValidPalindrome_125(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }
}
namespace LeetCode.Recursion;

public class IsPalindrome_125:TestBase
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

        // keep shrinking, delete head and tail
        char head = s[0];
        string middle = s.Substring(1, s.Length - 2);
        char tail = s[s.Length - 1];

        return head == tail && IsPalindromeHelper(middle);
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

    public IsPalindrome_125(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }
}
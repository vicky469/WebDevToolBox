namespace LeetCode.Two_Pointer;

public class ValidPalindrome_125 : TestBase
{
    public ValidPalindrome_125(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }

    private static bool IsPalindrome(string s)
    {
        if (s == null) return false;
        if (s == string.Empty) return true;
        s = s.ToLower();
        var j = s.Length - 1;
        // squeeze towards to the middle
        for (var i = 0; i <= j; i++)
            if (s[i] != s[j])
                return false;
        return true;
    }


    [Theory]
    [InlineData(" ", true)]
    [InlineData("ab", false)]
    [InlineData("abb", false)]
    private void Test_OK(string s, bool expectedResult)
    {
        var res = IsPalindrome(s);
        Assert.Equal(expectedResult, res);
    }
}
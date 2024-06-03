namespace LeetCode.Array_and_String.Two_Pointer;

public class IsSubsequence_392 : TestBase
{
    public IsSubsequence_392(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }

    //asking whether all the characters in s can be found in the same order in t
    private bool IsSubsequence(string s, string t)
    {
        if (string.IsNullOrEmpty(s)) return true;
        if (s.Length == 1 && t.Length == 1 && s[0] != t[0]) return false;

        var i = 0;
        var j = 0;
        while (i < s.Length && j < t.Length)
            if (s[i] == t[j])
            {
                i++;
                j++;
            }
            else if (s[i] != t[j])
            {
                j++;
            }

        return i == s.Length;
    }

    [Theory]
    [InlineData("abc", "ahbgdc", true)]
    [InlineData("axc", "ahbgdc", false)]
    [InlineData("", "ahbgdc", true)]
    [InlineData("b", "c", false)]
    [InlineData("acb", "ahbgdc", false)]
    public void Test(string s, string t, bool expected)
    {
        var result = IsSubsequence(s, t);
        Assert.Equal(expected, result);
    }
}
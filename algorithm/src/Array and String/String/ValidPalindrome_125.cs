namespace LeetCode.Array_and_String.String;

public class ValidPalindrome_125: TestBase
{
    bool IsPalindrome(string s) {
        if(s ==" ") return true;
        s = s.ToLower();
        var start = 0;
        var end = s.Length-1;
        while(start <= end){
            if (!char.IsLetterOrDigit(s[start]))
            {
                start++;
                continue;
            }

            if (!char.IsLetterOrDigit(s[end]))
            {
                end--;
                continue;
            }

            if(s[start] != s[end]) return false;
            start++;
            end--;
        }
        return true;
    }
    
    [Theory]
    [InlineData("A man, a plan, a canal: Panama", true)]
    [InlineData(" ", true)]
    private void Test_OK(string s, bool expectedResult)
    {
        var result = IsPalindrome(s);
        Assert.Equal(expectedResult, result);
    }

    public ValidPalindrome_125(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }
}
namespace LeetCode.Recursion.Array_and_String;

public class ReverseAString:TestBase
{
    static string ReverseString(string str)
    {
        if (string.IsNullOrEmpty(str) || str.Length == 1) return str;
        
        var head = str.Substring(0,1);
        var tail =  str.Substring(1,str.Length-1);
        var res =  ReverseString(tail)+head;
        return res;
    }
    
    [Theory]
    [InlineData("cat", "tac")]
    [InlineData("cartier", "reitrac")]
    private void Test_OK(string input, string expectedResult)
    {
        var res = ReverseString(input);
        Assert.Equal(expectedResult, res);
    }

    public ReverseAString(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }
}
namespace LeetCode.Util;

public class Templdate : TestBase
{
    bool Solution(string input)
    {
        TestOutputHelper.WriteLine("Hello World");
        return true;
    }


    [Theory]
    [InlineData(" ", true)]
    private void Test_OK(string input, bool expectedResult)
    {
        var res = Solution(input);
        Assert.Equal(expectedResult, res);
    }

    public Templdate(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }
}
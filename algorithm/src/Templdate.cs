using System;

namespace LeetCode;

public class Templdate : TestBase
{
    static bool Solution(string input)
    {
        throw new NotImplementedException();
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
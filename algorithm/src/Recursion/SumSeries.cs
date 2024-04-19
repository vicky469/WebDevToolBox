namespace LeetCode.Recursion;

public class SumSeries:TestBase
{
    static int Solution(int n)
    {
        if (n < 2) return n;
        return n += Solution(n - 1);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2,3)]
    [InlineData(200,20100)]
    
    private void Test_OK(int n, int expectedResult)
    {
        var res = Solution(n);
        Assert.Equal(expectedResult, res);
    }

    public SumSeries(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }
}
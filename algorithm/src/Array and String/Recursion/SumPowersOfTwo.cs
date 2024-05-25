namespace LeetCode.Recursion.Array_and_String;

public class SumPowersOfTwo
{
    static int Solution(int n)
    {
        return n switch
        {
            0 => 1,  // base case
            1 => 2,  // base case
            _ => (int)Math.Pow(2, n) + Solution(n - 1)  // recursive case
        };
    }
    
    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 2)]
    [InlineData(2,6)]
    [InlineData(3,14)]
    private void Test_OK(int n, int expectedResult)
    {
        var res = Solution(n);
        Assert.Equal(expectedResult, res);
    }
}
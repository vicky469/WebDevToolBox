namespace LeetCode.Array_and_String.Recursion;

public class ClimbingStairs_70 : TestBase
{
    static int ClimbStairs(int n) {
        var mem = new int[46];
        if (n <= 2) {
            return n;
        }
        if(mem[n] !=0 ) return mem[n];
        return ClimbStairs(n - 1) + ClimbStairs(n - 2);
    }


    [Theory]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    private void Test_OK(int input, int expectedResult)
    {
        var res = ClimbStairs(input);
        Assert.Equal(expectedResult, res);
    }
    
    public ClimbingStairs_70(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }
}
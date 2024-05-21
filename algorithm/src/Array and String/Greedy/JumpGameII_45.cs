namespace LeetCode.Array_and_String.Greedy;

public class JumpGameII_45: TestBase
{
    int Jump(int[] nums)
    {
        if (nums.Length < 2) return 0;

        int jumps = 0, currentEnd = 0, farthest = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            farthest = Math.Max(farthest, i + nums[i]);
            if (i == currentEnd)
            {
                jumps++;
                currentEnd = farthest;
            }
        }
        return jumps;
    }
    
    [Theory]
    [InlineData(new[] { 2,3,1,1,4 },  2)]
    //[InlineData(new[] { 3,2,0,1,4},  2)]
    private void Test_OK(int[] nums, int expectedResult)
    {
        var res = Jump(nums);
        Assert.Equal(expectedResult, res);
    }

    public JumpGameII_45(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }
}
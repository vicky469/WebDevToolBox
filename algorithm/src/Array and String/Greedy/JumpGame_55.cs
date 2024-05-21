namespace LeetCode.Array_and_String.DP;

public class JumpGame_55
{
    // key idea is to update maxJumpIndex at each step without actually jumping to maxJumpIndex.
    // so we can consider all possible jumps at each step, not just the maximum one.
    // if i (current index) > maxReachableIndex,
    // meaning we can't reach the current index based on maxJumpIndex calculated from previous jumps.
    bool CanJump(int[] nums)
    {
        var maxReachableIndex = 0;
        for (var i = 0; i < nums.Length; i++) {
            if (i > maxReachableIndex)  return false;
            maxReachableIndex = Math.Max(maxReachableIndex, i + nums[i]);
        }
        return true;
    }
    
    [Theory]
    [InlineData(new[] { 2,3,1,1,4 },  true)]
    [InlineData(new[] { 3,2,1,0,4},  false)]
    private void Test_OK(int[] nums, bool expectedResult)
    {
        var res = CanJump(nums);
        Assert.Equal(expectedResult, res);
    }
}
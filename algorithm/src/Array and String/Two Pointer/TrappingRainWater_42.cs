namespace LeetCode.Array_and_String.Two_Pointer;

public class TrappingRainWater_42
{
    int Trap(int[] height) {
        throw new NotImplementedException();
    }
    
    [Theory]
    [InlineData(new[] { 0,1,0,2,1,0,1,3,2,1,2,1 }, 6)]
    private void Test_OK(int[] nums,  int expectedResult)
    {
        var res = Trap(nums);
        Assert.Equal(expectedResult, res);
    }
}
namespace LeetCode.Array_and_String.Two_Pointer;

public class MoveZeroes_283
{
    // in-place
    // don't change the order
    private void MoveZeroes(int[] nums)
    {
        if (nums.Length < 2) return;
        var s = 0;
        for (var f = 0; f < nums.Length; f++)
            if (nums[f] != 0)
                nums[s++] = nums[f];

        for (var i = s; i < nums.Length; i++) // fill the rest with 0
            nums[i] = 0;
    }

    private void MoveZeroes2(int[] nums)
    {
        if (nums.Length < 2) return;
        var s = 0;
        for (var f = 0; f < nums.Length; f++)
            if (nums[f] != 0)
            {
                var temp = nums[s];
                nums[s] = nums[f];
                nums[f] = temp;
                s++;
            }
    }


    [Theory]
    [InlineData(new[] { 0, 1, 0, 3, 12 }, new[] { 1, 3, 12, 0, 0 })]
    [InlineData(new[] { 0 }, new[] { 0 })]
    private void Test_OK(int[] nums, int[] expectedResult)
    {
        MoveZeroes(nums);
        Assert.Equal(expectedResult, nums);
    }

    [Theory]
    [InlineData(new[] { 0, 1, 0, 3, 12 }, new[] { 1, 3, 12, 0, 0 })]
    [InlineData(new[] { 0 }, new[] { 0 })]
    private void Test_OK2(int[] nums, int[] expectedResult)
    {
        MoveZeroes2(nums);
        Assert.Equal(expectedResult, nums);
    }
}
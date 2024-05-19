namespace LeetCode.array_and_string.Two_Pointer;

public class RemoveDuplicatesFromSortedArrayII_80
{
    int RemoveDuplicates(int[] nums)
    {
        if(nums.Length < 2) return nums.Length;
        var s = 2; // where the next element should be placed
        for (var f = 2; f < nums.Length; f++)
            if (nums[f] != nums[s - 2])
                nums[s++] = nums[f];
        return s;
    }

    [Theory]
    [InlineData(new[] { 0, 1, 1 }, 3, new[] { 0, 1, 1 })]
    [InlineData(new[] { 1, 1, 1, 2, 2, 3 }, 5, new[] { 1, 1, 2, 2, 3 })]
    [InlineData(new[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 }, 7, new[] { 0, 0, 1, 1, 2, 3, 3 })]
    private void Test_OK(int[] nums, int expectedResult, int[] expectedNums)
    {
        var res = RemoveDuplicates(nums);
        Assert.Equal(expectedResult, res);
        Assert.Equal(expectedNums, nums.Take(res));
    }
}
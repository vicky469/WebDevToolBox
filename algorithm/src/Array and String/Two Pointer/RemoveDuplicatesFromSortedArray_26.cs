namespace LeetCode.array_and_string.Two_Pointer;

// array is sorted
// should keep the same order
public class RemoveDuplicatesFromSortedArray_26
{
    int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;

        var s = 0; // Index to place the next unique element

        for (var f = 1; f < nums.Length; f++)
            if (nums[s] != nums[f])
                nums[++s] = nums[f];

        return s + 1;
    }

    [Theory]
    [InlineData(new[] { 1, 1, 2 }, 2)]
    [InlineData(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
    private void Test_OK(int[] nums, int expectedResult)
    {
        var res = RemoveDuplicates(nums);
        Assert.Equal(expectedResult, res);
    }
}
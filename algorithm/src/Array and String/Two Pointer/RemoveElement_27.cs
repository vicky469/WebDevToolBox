namespace LeetCode.array_and_string.Two_Pointer;

public class RemoveElement_27
{
    public int RemoveElement(int[] nums, int val)
    {
        var slow = 0;
        // fast pointer to iterate the array
        for (var fast = 0; fast < nums.Length; fast++)
            if (nums[fast] != val)
                // slow pointer move forward and replace the value
                nums[slow++] = nums[fast];
        return slow;
    }

    [Theory]
    [InlineData(new[] { 3, 2, 2, 3 }, 3, 2)]
    [InlineData(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
    private void Test_OK(int[] nums, int val, int expectedResult)
    {
        var res = RemoveElement(nums, val);
        Assert.Equal(expectedResult, res);
    }
}
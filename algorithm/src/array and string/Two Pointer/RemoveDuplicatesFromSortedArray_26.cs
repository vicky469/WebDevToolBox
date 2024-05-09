namespace LeetCode.array_and_string.Two_Pointer;

public class RemoveDuplicatesFromSortedArray_26
{
    // array is sorted
    // should keep the same order
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length == 0) return 0;
        var s = 0;  // where the next element should be placed
        var f = 1;  // the next unique element
        while(f < nums.Length)
        {
            var slow = nums[s];
            var fast = nums[f];
            if (slow == fast) f++;
            else
            {
                nums[++s] = nums[f++];
            }
        }

        return s+1;
    }
    [Theory]
    [InlineData( new int []{1,1,2}, 2)]
    [InlineData( new int []{0,0,1,1,1,2,2,3,3,4}, 5)]
    private void Test_OK(int[] nums, int expectedResult)
    {
        var res = RemoveDuplicates(nums);
        Assert.Equal(expectedResult, res);
    }
}
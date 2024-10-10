namespace LeetCode.Array_and_String.Sorting;

public class SortEvenAndOddIndicesIndependently_2164
{
    int[] SortEvenOdd(int[] nums) { 
        Array.Sort(nums);
        var j = 1;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                // find next odd to swap
                while(j<nums.Length && nums[j] % 2 == 0)
                {
                    j++;
                }
                if (j < nums.Length)
                {
                    var temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }

                j = i + 1;
            }
        }

        return nums;
    }
    
    [Theory]
    [InlineData(new[]{4,2,5,7}, new[]{2,7,4,5})]
    [InlineData(new[]{2,3,4,5,6,7}, new[]{2,7,4,5,6,3})]
    public void Test(int[] nums, int[] expected)
    {
        Assert.Equal(expected, SortEvenOdd(nums));
    }
    
}
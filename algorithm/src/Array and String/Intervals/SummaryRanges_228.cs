namespace LeetCode.Array_and_String.Intervals;

public class SummaryRanges_228
{
    IList<string> SummaryRanges(int[] nums)
    {
        var res = new List<string>();
        if (nums.Length == 0) return res;
        
        var start = nums[0]; // first index
        var end = nums[0];
        for (var i = 0; i < nums.Length; i++)
        {
            // if this is in between [2nd index ... before last index)
            if (i != 0 && nums[i-1] + 1 != nums[i])
            {
                end = nums[i - 1];
                if(start == end) res.Add($"{start}");
                else res.Add($"{start}->{end}");
                start = nums[i];
            }

            // last index
            if (i == nums.Length - 1)
            {
                end = nums[i];
                if(start == end) res.Add($"{start}");
                else res.Add($"{start}->{end}");
            }
        }

        return res;
    }
    [Theory]
    [InlineData(new int[]{0,1,2,4,5,7}, new string[]{"0->2","4->5","7"})]
    [InlineData(new int[]{0,2,3,4,6,8,9}, new string[]{"0","2->4","6","8->9"})]
    [InlineData(new int[]{}, new string[]{})]
    public void Test_Given_Array_Return_Summary_Ranges(int[] nums, string[] expected)
    {
        var actual = SummaryRanges(nums);
        Assert.Equal(expected, actual);
    }
}
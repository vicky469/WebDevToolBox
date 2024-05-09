namespace LeetCode.array_and_string.Frequency_Counter_Pattern;

public class MajorityElement_169
{
    static int MajorityElement(int[] nums)
    {
        var count = 0;
        var candidate = 0;
        foreach (var num in nums)
        {
            if (count == 0 )
            {
                candidate = num;
                count++;
            }else
            {
                if( candidate != num) count--;
                if(candidate == num) count++;
            }
        }

        count = 0;
        foreach (var num in nums)
        {
            if (num == candidate)
            {
                count++;
            }
        }

        
        return count >= nums.Length/2 ? candidate:-1;
    }
    
    [Theory]
    [InlineData( new int[]{ 1, 1, 2, 2, 2, 3}, 2)]
    [InlineData( new int[]{ 2, 2}, 2)]
    [InlineData( new int[]{ 2,2,1,1,3}, -1)]
    private void Test_OK(int[] arr, int expectedResult)
    {
        var result = MajorityElement(arr);
        Assert.Equal(expectedResult,result);
    }
}
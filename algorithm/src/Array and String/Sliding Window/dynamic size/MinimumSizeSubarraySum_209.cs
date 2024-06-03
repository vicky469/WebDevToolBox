namespace LeetCode.Array_and_String.Sliding_Window_Pattern;

public class MinimumSizeSubarraySum_209
{
    int MinSubArrayLen(int target, int[] nums) {
        var minWindowSize = int.MaxValue;
        var start = 0;
        var end = 0;
        var currentSum = nums[start];
        while (start <= end)
        {
            var windowSize = end - start + 1;
            
            while (currentSum < target && end < nums.Length - 1)
            {
                end++;
                windowSize++;
                currentSum += nums[end];
            }
            
            if(start == 0 && currentSum < target) return 0;

            if (currentSum >= target)
            {
                minWindowSize = Math.Min(minWindowSize, windowSize);
                currentSum -= nums[start];
            }
            start++;    
        }
        return minWindowSize == int.MaxValue ? 0 : minWindowSize;
    }
    
    // Time complexity: O(n)
    int MinSubArrayLen_Slow(int target, int[] nums) {
        var windowSize = 0;
        var start = 0;
        var end=0;
        while(windowSize < nums.Length){
            for(var i = 0; i < nums.Length - windowSize; i++){
                start = i;
                end = i + windowSize;
                var sum = 0;
                for(var j = start; j <= end; j++){
                    sum += nums[j];
                }
                if(end <= nums.Length -1 && sum>= target) return windowSize+1;
            }
            windowSize++;
        }
        return 0;
    }
    [Theory]
    [InlineData(7, new[] {2,3,1,2,4,3}, 2)]
    [InlineData(4, new[] {1,4,4}, 1)]
    [InlineData(11, new[] {1,1,1,1,1,1,1,1}, 0)]
    public void Test_1(int target, int[] nums, int expected){
        var res = MinSubArrayLen(target, nums);
        Assert.Equal(expected, res);
    }
    [Theory]
    [InlineData(7, new[] {2,3,1,2,4,3}, 2)]
    [InlineData(4, new[] {1,4,4}, 1)]
    [InlineData(11, new[] {1,1,1,1,1,1,1,1}, 0)]
    public void Test_2(int target, int[] nums, int expected){
        var res = MinSubArrayLen_Slow(target, nums);
        Assert.Equal(expected, res);
    }
}
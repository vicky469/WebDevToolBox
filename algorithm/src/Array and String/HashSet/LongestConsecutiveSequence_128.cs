namespace LeetCode.Array_and_String.HashSet;

public class LongestConsecutiveSequence_128
{
    int LongestConsecutive(int[] nums)
    {
        var set = new HashSet<int>(nums);
        var longestStreak = 0;
        foreach (var num in set)
        {
            // no left number means it is the start of the sequence
            if (!set.Contains(num - 1))
            {
                var currentNum = num;
                var currentStreak = 1;
                while (set.Contains(currentNum + 1))
                {
                    currentNum += 1;
                    currentStreak += 1;
                }
                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }
        return longestStreak;
    }
    [Theory]
    [InlineData(new int[]{100,4,200,1,3,2},4)]
    [InlineData(new int[]{0,3,7,2,5,8,4,6,0,1},9)]
    public void TestMethod(int[] nums, int result){
        Assert.Equal(result,LongestConsecutive(nums));
    }
}
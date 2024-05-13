namespace LeetCode;

public class MinimumNumberGame_2974
{
    private static int[] NumberGame(int[] nums)
    {
        var output = new int[nums.Length];
        if (nums.Length == 0) return null;
        Array.Sort(nums);
        var list = nums.ToList();
        var round = 0;
        while (list.Count > 0)
        {
            round += 1;
            var i = 0;
            var j = 1;
            var smallestNum = list[i];
            var secondSmallestNum = list[j];
            output[round * 2 - 2] = secondSmallestNum;
            output[round * 2 - 1] = smallestNum;
            list.RemoveAt(i);
            list.RemoveAt(i);
        }

        return output;
    }

    [Theory]
    [InlineData(new[] { 5, 4, 2, 3 }, new[] { 3, 2, 5, 4 })]
    private void Test_OK(int[] input, int[] expectedResult)
    {
        var result = NumberGame(input);
        Assert.Equal(expectedResult, result);
    }
}
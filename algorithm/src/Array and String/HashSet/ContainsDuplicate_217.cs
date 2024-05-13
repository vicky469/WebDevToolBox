namespace LeetCode;

public class ContainsDuplicate_217 : TestBase
{
    public ContainsDuplicate_217(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }

    private static bool ContainsDuplicate(int[] nums)
    {
        var hashSet = new HashSet<int>();
        for (var i = 0; i < nums.Length; i++)
        {
            var added = hashSet.Add(nums[i]);
            if (!added) return true;
        }

        return false;

        #region or

        return new HashSet<int>(nums).Count < nums.Length;

        #endregion
    }


    [Theory]
    [InlineData(new[] { 1, 2, 3, 1 }, true)]
    [InlineData(new[] { 1, 2, 3, 4 }, false)]
    [InlineData(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
    private void Test_OK(int[] nums, bool expectedResult)
    {
        var res = ContainsDuplicate(nums);
        Assert.Equal(expectedResult, res);
    }
}
namespace LeetCode.Array_and_String.HashSet;

public class MaximumSizeOfASetAfterRemovals_10037
{
    private static int MaximumSetSize(int[] nums1, int[] nums2)
    {
        var s1TargetLen = nums1.Length / 2;
        var s2TargetLen = nums2.Length / 2;
        var s1 = new HashSet<int>(nums1);
        var s2 = new HashSet<int>(nums2);

        if (s1.Count > s1TargetLen)
            // need to cut s1 and figure out which ones best to be cut
            s1 = ReduceSetElements(s1, s2, s1TargetLen);
        else if (s2.Count > s2TargetLen) s2 = ReduceSetElements(s2, s1, s2TargetLen);

        var result = s1.Concat(s2).ToHashSet().Count;

        return result > s1TargetLen + s2TargetLen ? s1TargetLen + s2TargetLen : result;
    }

    private static HashSet<int> ReduceSetElements(HashSet<int> s1, HashSet<int> s2, int s1TargetLen)
    {
        if (s1.Count >= s2.Count)
        {
            // need to know which ones to cut in s1
            var cnt = 0;
            foreach (var num in s2)
            {
                var removed = s1.Remove(num);
                if (removed)
                {
                    cnt++;
                    if (cnt == s1TargetLen) break;
                }
            }

            if (cnt < s1TargetLen)
            {
                var skipLast = s1.Count - s1TargetLen;
                s1 = s1.SkipLast(skipLast).ToHashSet();
            }
        }

        return s1;
    }

    [Theory]
    [InlineData(new[] { 1, 2, 1, 2 }, new[] { 1, 1, 1, 1 }, 2)]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 2, 3, 2, 3, 2, 3 }, 5)]
    [InlineData(new[] { 1, 1, 2, 2, 3, 3 }, new[] { 4, 4, 5, 5, 6, 6 }, 6)]
    [InlineData(new[] { 1, 1, 1, 1 }, new[] { 12, 23, 41, 9 }, 3)]
    [InlineData(new[] { 8, 9 }, new[] { 4, 3 }, 2)]
    [InlineData(new[] { 2, 4, 1, 4 }, new[] { 10, 2, 4, 10 }, 4)]
    private void Test_OK(int[] nums1, int[] nums2, int expectedResult)
    {
        var res = MaximumSetSize(nums1, nums2);
        Assert.Equal(expectedResult, res);
    }
}
namespace LeetCode.array_and_string.HashSet;

public class IntersectionOfTwoArrays_349
{
    private static int[] Intersection(int[] nums1, int[] nums2)
    {
        //var res = nums1.MyIntersect(nums2).ToArray();
        var res = nums1.Intersect(nums2).ToArray();
        return res;
    }

    [Theory]
    [InlineData(new[] { 1, 2, 2, 1 }, new[] { 2, 2 }, new[] { 2 })]
    [InlineData(new[] { 4, 9, 5 }, new[] { 9, 4, 9, 8, 4 }, new[] { 4, 9 })]
    private void Test_OK(int[] nums1, int[] nums2, int[] expectedResult)
    {
        var res = Intersection(nums1, nums2);
        Assert.Equal(expectedResult, res);
    }
}
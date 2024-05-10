using System.Linq;

namespace LeetCode.array_and_string.HashSet;

public class IntersectionOfTwoArrays_349
{
    static int[] Intersection(int[] nums1, int[] nums2)
    {
        //var res = nums1.MyIntersect(nums2).ToArray();
        var res = nums1.Intersect(nums2).ToArray();
        return res;
    }

    [Theory]
    [InlineData(new int[]{1,2,2,1}, new int[]{2,2}, new int[]{2})]
    [InlineData(new int[]{4,9,5}, new int[]{9,4,9,8,4}, new int[]{4,9})]
    private void Test_OK(int[] nums1, int[] nums2, int[] expectedResult)
    {
        var res = Intersection(nums1,nums2);
        Assert.Equal(expectedResult, res);
    }
}
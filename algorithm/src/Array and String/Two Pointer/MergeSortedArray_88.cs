namespace LeetCode.Array_and_String.Two_Pointer;

public class MergeSortedArray_88
{
    void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        // starting backwards, add the largest element and
        // the next largest element and so on at the end of nums1
        var p1 = m - 1; // last element in nums1
        var p2 = n - 1; // last element in nums2
        var p = m + n - 1; // last element in the output array

        // While there are still elements to compare
        while (p1 >= 0 && p2 >= 0)
            // Compare two elements from nums1 and nums2 
            // and add the largest one in nums1 
            nums1[p--] = nums1[p1] < nums2[p2] ? nums2[p2--] : nums1[p1--];

        // Add remaining elements from nums2 into nums1
        Array.Copy(nums2, 0, nums1, 0, p2 + 1);
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3, 0, 0, 0 }, 3, new[] { 2, 5, 6 }, 3, new[] { 1, 2, 2, 3, 5, 6 })]
    [InlineData(new[] { 1 }, 1, new int[] { }, 0, new[] { 1 })]
    [InlineData(new[] { 0 }, 0, new[] { 1 }, 1, new[] { 1 })]
    [InlineData(new[] { 2, 0 }, 1, new[] { 1 }, 1, new[] { 1, 2 })]
    [InlineData(new[] { 4, 5, 6, 0, 0, 0 }, 3, new[] { 1, 2, 3 }, 3, new[] { 1, 2, 3, 4, 5, 6 })]
    private void Test_OK(int[] nums1, int m, int[] nums2, int n, int[] expectedResult)
    {
        Merge(nums1, m, nums2, n);
        Assert.Equal(expectedResult, nums1);
    }
}
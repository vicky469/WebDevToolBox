namespace LeetCode.array_and_string;

public class MergeSortedArray_88
{
    static void Merge2(int[] nums1, int m, int[] nums2, int n)
    {
        var p1 = m - 1;
        var p2 = n - 1;
        var p = m + n - 1;

        // While there are still elements to compare
        while ((p1 >= 0) && (p2 >= 0)) {
            // Compare two elements from nums1 and nums2 
            // and add the largest one in nums1 
            nums1[p--] = (nums1[p1] < nums2[p2]) ? nums2[p2--] : nums1[p1--];
        }

        // Add remaining elements from nums2 into nums1
        Array.Copy(nums2, 0, nums1, 0, p2 + 1);
    }
    
    static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        // deep copy array so changing in one will not affect the other 
        var nums1Copy = new int[nums1.Length];
        System.Array.Copy(nums1, nums1Copy, nums1.Length);
        var j = 0;
        for(var i = 0; i < nums1.Length; i++)
        {
            // first we take m numbers from nums1
            if (i < m)
            {
                nums1[i] = nums1Copy[i];
            }
            else // then take n numbers from nums2
            {
                nums1[i] = nums2[j++];
            }
        }

        System.Array.Sort(nums1);
    }
    
    [Theory]
    //                            
    [InlineData( new int []{1,2,3,0,0,0}, 3,new int []{2,5,6},3, new int []{1,2,2,3,5,6})]
    [InlineData( new int []{1}, 1,new int []{},0, new int []{1})]
    [InlineData( new int []{0}, 0,new int []{1},1, new int []{1})]
    [InlineData( new int []{2,0}, 1,new int []{1},1, new int []{1,2})]
    private void Test_OK(int[] nums1, int m, int[] nums2, int n, int[] expectedResult)
    {
        Merge(nums1,m,nums2,n);
        Assert.Equal(expectedResult, nums1);
    }
    
    [Theory]
    // [InlineData( new int []{1,2,3,0,0,0}, 3,new int []{2,5,6},3, new int []{1,2,2,3,5,6})]
    // [InlineData( new int []{1}, 1,new int []{},0, new int []{1})]
    // [InlineData( new int []{0}, 0,new int []{1},1, new int []{1})]
    //[InlineData( new int []{0}, 0,new int []{1},1, new int []{1})]
    [InlineData( new int []{4,5,6,0,0,0}, 3,new int []{1,2,3},3, new int []{1,2,3,4,5,6})]
    private void Test_OK2(int[] nums1, int m, int[] nums2, int n, int[] expectedResult)
    {
        Merge2(nums1,m,nums2,n);
        Assert.Equal(expectedResult, nums1);
    }
}
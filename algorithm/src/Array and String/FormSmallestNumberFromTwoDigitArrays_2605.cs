namespace LeetCode.Array_and_String;

public class FormSmallestNumberFromTwoDigitArrays_2605
{
    private static readonly int DefaultMin = 11;

    private static int MinNumber(int[] nums1, int[] nums2)
    {
        var arr = new int[10];
        var minNum1 = nums1.Min();
        var minNum2 = nums2.Min();
        var min = DefaultMin;

        foreach (var num in nums1) arr[num]++;

        foreach (var num in nums2)
        {
            arr[num]--;
            var oldVal = arr[num];
            if (oldVal == 0) min = Math.Min(num, min);
        }

        if (min != DefaultMin) return min;
        min = Math.Min(minNum1, minNum2);
        if (min == minNum1) return int.Parse(minNum1 + minNum2.ToString());
        return int.Parse(minNum2 + minNum1.ToString());
    }

    [Theory]
    [InlineData(new[] { 4, 1, 3 }, new[] { 5, 7 }, 15)]
    [InlineData(new[] { 3, 5, 2, 6 }, new[] { 3, 1, 7 }, 3)]
    [InlineData(new[] { 6, 4, 3, 7, 2, 1, 8, 5 }, new[] { 6, 8, 5, 3, 1, 7, 4, 2 }, 1)]
    private void Test_OK(int[] nums1, int[] nums2, int expectedResult)
    {
        var result = MinNumber(nums1, nums2);
        Assert.Equal(expectedResult, result);
    }
}
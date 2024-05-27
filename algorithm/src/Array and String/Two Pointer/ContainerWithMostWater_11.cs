namespace LeetCode.Array_and_String.Two_Pointer;

public class ContainerWithMostWater_11
{
    public int MaxArea(int[] height)
    {
        var left = 0;
        var right = height.Length - 1;
        var maxArea = 0;
        while (left < right)
        {
            // calculate the area and get the maxArea
            var min = Math.Min(height[left], height[right]);
            maxArea = Math.Max(min * (right - left), maxArea);
            // how to decide which pointer to move?
            // move the pointer with the smaller height
            if (height[left] < height[right])
                left++;
            else
                right--;
        }

        return maxArea;
    }

    [Theory]
    [InlineData(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
    [InlineData(new[] { 1, 1 }, 1)]
    private void Test_OK(int[] height, int expectedResult)
    {
        var res = MaxArea(height);
        Assert.Equal(expectedResult, res);
    }
}
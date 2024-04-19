namespace LeetCode;

public class SameSquared
{
    // 1. arr2 is the squared value of arr1
    // 2. frequency must be the same
    static bool Same(int[] arr1, int[] arr2)
    {
        if (arr1 == null || arr2 == null) return false;

        if (arr1.Length != arr2.Length) return false;

        var dict = new Dictionary<int, int>();// {squaredValue: cnt}

        foreach (int value in arr1)
        {
            int squaredValue = value * value;
            
            dict[squaredValue] = dict.GetValueOrDefault(squaredValue, 0) + 1;
        }

        foreach (int secondValue in arr2)
        {
            // we want one-one matching. if it is 0, it will turn negative which doesn't match,
            // so checking that to return false
            if (!dict.ContainsKey(secondValue) || dict[secondValue] == 0) return false;
            dict[secondValue] -= 1;
        }

        return true;
    }
    
    [Theory]
    [InlineData( new int[]{ 2, 3, 1 }, new int[]{ 4, 1, 9 }, true)]
    [InlineData( new int[]{ 1, 2, 1 }, new int[]{ 4, 4, 1 }, false)]
    [InlineData( new int[]{ 1, 2, 1 }, new int[]{ 4, 1, 1 }, true)]
    private void Test_OK(int[] arr1,int[] arr2, bool expectedResult)
    {
        var result = Same(arr1, arr2);
        Assert.Equal(expectedResult, result);
    }
}
namespace LeetCode.Array_and_String.Sliding_Window_Pattern;

public class MinimumSwapsToGroupAll1s_1151
{
    static int MinSwaps(int[] data) {
        // get window size
        int windowSize = data.Count(d => d == 1);
    
        // get 1st onesInWindow size
        int onesInWindow = data.Take(windowSize).Count(d => d == 1);
    
        // get minSwaps(number of zeros) in 1st window
        var minSwaps = CalculateMinSwaps(windowSize, onesInWindow);
    
        // Iterate through the remaining windows
        for (var i = windowSize; i < data.Length; i++) {
            // maintain the window and update the onesInWindow
            onesInWindow += data[i];
            onesInWindow -= data[i - windowSize];
        
            // Update the minimum swaps needed
            minSwaps = System.Math.Min(minSwaps, CalculateMinSwaps(windowSize, onesInWindow));
        }
        return minSwaps;
    }

    private static int CalculateMinSwaps(int windowSize, int onesInWindow)
    {
        int minSwaps = windowSize - onesInWindow;
        return minSwaps;
    }

    [Theory]
    [InlineData( new int[]{1,0,1,0,1}, 1)]
    [InlineData( new int[]{1,0,1}, 1)]
    [InlineData( new int[]{1,0,1,0,1,0,0,1,1,0,1}, 3)]
    [InlineData( new int[]{0,0,0,1,0}, 0)]
    [InlineData( new int[]{0,0,0,1,0,1}, 1)]
    private void Test_OK(int[] data, int expectedResult)
    {
        var result = MinSwaps(data);
        Assert.Equal(expectedResult, result);
    }
}
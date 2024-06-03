namespace LeetCode.Array_and_String.Two_Pointer;

public class RotateArray_189 : TestBase
{
    public RotateArray_189(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }

    // 1. brute force
    private void Rotate_BruteForce(int[] nums, int k)
    {
        k %= nums.Length; // to handle cases where k is
        // larger than the length of the array
        int prev;
        for (var i = 0; i < k; i++)
        {
            prev = nums[nums.Length - 1];
            for (var j = 0; j < nums.Length; j++) (nums[j], prev) = (prev, nums[j]);
        }
    }

    // 2. Reverse Three Times
    private void Rotate_Revert_ThreeTimes(int[] nums, int k)
    {
        k %= nums.Length;
        Reverse(nums, 0, nums.Length - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, nums.Length - 1);
    }

    private void Reverse(int[] nums, int start, int end)
    {
        while (start < end)
        {
            (nums[start], nums[end]) = (nums[end], nums[start]);
            start++;
            end--;
        }
    }

    // 3. Using Cyclic Replacements
    // Time complexity : O(n)
    // The time complexity of this algorithm is O(n) because each element in the array is visited exactly once.
    private void Rotate(int[] nums, int k)
    {
        k %= nums.Length;
        var count = 0;
        // The total number of elements in the array is n.
        // We must move n elements.
        for (var i = 0; count < nums.Length; i++)
        {
            var currentIndex = i;
            var currentValue = nums[i];
            // In the do while loop, we keep moving elements to their correct position until we finish one cycle.
            // One cycle means we have returned to the original index.
            do
            {
                var nextIndex = (currentIndex + k) % nums.Length;
                (nums[nextIndex], currentValue) = (currentValue, nums[nextIndex]);
                currentIndex = nextIndex;
                count++;
            } while (i != currentIndex);
        }
    }

    private void Rotate_PRINT(int[] nums, int k)
    {
        k %= nums.Length;
        var count = 0;
        for (var i = 0; count < nums.Length; i++)
        {
            var currentIndex = i;
            var currentValue = nums[i];
            TestOutputHelper.WriteLine(
                $"====== {i + 1} cycle:  currentIndex: {currentIndex}, currentValue: {currentValue}   ======");
            do
            {
                var nextIndex = (currentIndex + k) % nums.Length;
                TestOutputHelper.WriteLine($"nextIndex: {nextIndex}, nums[nextIndex]: {nums[nextIndex]}");
                (nums[nextIndex], currentValue) = (currentValue, nums[nextIndex]);
                TestOutputHelper.WriteLine($"SWAP nums[nextIndex]: {nums[nextIndex]}, currentValue: {currentValue}");
                currentIndex = nextIndex;
                TestOutputHelper.WriteLine($"currentIndex: {currentIndex}");
                count++;
                TestOutputHelper.WriteLine($"count: {count}");
            } while (i != currentIndex);
        }
    }


    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new[] { 5, 6, 7, 1, 2, 3, 4 })]
    private void Test_OK(int[] nums, int k, int[] expectedResult)
    {
        Rotate_BruteForce(nums, k);
        Assert.Equal(expectedResult, nums);
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new[] { 5, 6, 7, 1, 2, 3, 4 })]
    private void Test_OK2(int[] nums, int k, int[] expectedResult)
    {
        Rotate_Revert_ThreeTimes(nums, k);
        Assert.Equal(expectedResult, nums);
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6 }, 2, new[] { 5, 6, 1, 2, 3, 4 })]
    [InlineData(new[] { 1, 2, 3 }, 2, new[] { 2, 3, 1 })]
    private void Test_OK3(int[] nums, int k, int[] expectedResult)
    {
        //Rotate(nums,k);
        Rotate_PRINT(nums, k);
        Assert.Equal(expectedResult, nums);
    }
}
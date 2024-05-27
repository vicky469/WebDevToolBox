namespace LeetCode.Array_and_String.Recursion;

public class SummingNumbersInAnArray: TestBase
{
    static int Sum(int[] arr)
    {
        if (arr.Length == 0)
        {
            return 0;
        }
        var head = arr[0];
        var tail = arr.Skip(1).ToArray();
        var res =  head + Sum(tail);
        return res;
    }
    
    [Theory]
    [InlineData(new int[]{5,2,4,8}, 19)]
    private void Test_OK(int[] arr, int expectedResult)
    {
        var res = Sum(arr);
        Assert.Equal(expectedResult, res);
    }

    public SummingNumbersInAnArray(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }
}
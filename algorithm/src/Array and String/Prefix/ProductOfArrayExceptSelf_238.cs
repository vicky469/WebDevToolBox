namespace LeetCode.Array_and_String.Prefix;

public class ProductOfArrayExceptSelf_238: TestBase
{
    // can use division, get the product of all elements, then divide by the element for each position 
    int[] ProductExceptSelf(int[] nums) {
        var prefix = new int[nums.Length];
        var suffix = new int[nums.Length];
        var res = new int[nums.Length];
        prefix[0] = 1;
        suffix[nums.Length-1] = 1;
        for(var i = 1; i < nums.Length; i++)
        {
            prefix[i] = prefix[i-1] * nums[i-1];
        }
        for(var i = nums.Length-2; i >= 0; i--)
        {
            suffix[i] = suffix[i+1] * nums[i+1];
        }
        for(var i = 0; i < nums.Length; i++)
        {
            res[i] = prefix[i] * suffix[i];
        }
        return res;
    }
    
    int[] ProductExceptSelf_Print(int[] nums) {
        var prefix = new int[nums.Length];
        var suffix = new int[nums.Length];
        var res = new int[nums.Length];
        prefix[0] = 1;
        suffix[nums.Length-1] = 1;
        for(var i = 1; i < nums.Length; i++)
        {
            prefix[i] = prefix[i-1] * nums[i-1];
        }
        for(var i = nums.Length-2; i >= 0; i--)
        {
            suffix[i] = suffix[i+1] * nums[i+1];
        }
        for(var i = 0; i < nums.Length; i++)
        {
            res[i] = prefix[i] * suffix[i];
        }
        TestOutputHelper.WriteLine(string.Join(",", prefix));
        TestOutputHelper.WriteLine(string.Join(",", suffix));


        return res;
    }
    [Theory]
    [InlineData(new[] { 1,2,3,4}, new[] {24,12,8,6})]
    private void Test_OK(int[] nums, int[] expectedResult)
    {
        var res = ProductExceptSelf(nums);
        Assert.Equal(expectedResult, res);
    }

    public ProductOfArrayExceptSelf_238(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }
}
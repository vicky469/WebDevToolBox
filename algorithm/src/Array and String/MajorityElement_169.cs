namespace LeetCode.Array_and_String;

public class MajorityElement_169
{
    // Boyer-Moore Voting Algorithm
    int MajorityElement(int[] nums)
    {
        var count = 0;
        var candidate = 0;
        foreach (var num in nums)
        {
            if (count == 0) candidate = num;
            count = candidate == num ? count + 1 : count - 1;
        }
        return candidate;
    }

    int MajorityElementHashTable(int[] nums)
    {
        var map = new Dictionary<int,int>();
        for(var i = 0; i < nums.Length; i++){
            if(!map.ContainsKey(nums[i])){
                map.Add(nums[i], 1);
            }else{
                var val = map[nums[i]];
                map[nums[i]] = val+1;
            }
        }
        var max = map.Values.Max();
        var key = map.FirstOrDefault(x => x.Value == max).Key;
        return key;
    }

    [Theory]
    [InlineData(new[] { 3,3,4}, 3)]
    // [InlineData(new[] { 6,5,5}, 5)]
    // [InlineData(new[] { 2,2,1,1,1,2,2 }, 2)]
    private void Test_OK(int[] arr, int expectedResult)
    {
        var result = MajorityElement(arr);
        Assert.Equal(expectedResult, result);
    }
    
    [Theory]
    [InlineData(new[] { 6,5,5}, 5)]
    [InlineData(new[] { 2,2,1,1,1,2,2 }, 2)]
    private void Test_OK2(int[] arr, int expectedResult)
    {
        var result = MajorityElementHashTable(arr);
        Assert.Equal(expectedResult, result);
    }
}
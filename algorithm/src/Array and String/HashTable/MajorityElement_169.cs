namespace LeetCode.Array_and_String.HashTable;

public class MajorityElement_169
{
    private static int MajorityElement(int[] nums)
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
        // get the max value 
        var max = map.Values.Max();
        // use the value to get the key
        var key = map.FirstOrDefault(x => x.Value == max).Key;
        return key;
    }

    [Theory]
    [InlineData(new[] { 6,5,5}, 5)]
    [InlineData(new[] { 2,2,1,1,1,2,2 }, 2)]
    private void Test_OK(int[] arr, int expectedResult)
    {
        var result = MajorityElement(arr);
        Assert.Equal(expectedResult, result);
    }
}
namespace LeetCode.Array_and_String.HashTable;

public class TwoSum_1
{
    int[] TwoSum(int[] nums, int target) {
        // num : index
        var map = new Dictionary<int,int>();
        var res = new int[2];
        for(var i = 0; i < nums.Length; i++){
            var currentNum = nums[i];
            var anotherNum = target-nums[i];
            if(!map.ContainsKey(currentNum)){ //7:0
                map.TryAdd(anotherNum,i);   // remember to use TryAdd in case of duplicate key
            }else{
                res[0] = map[currentNum];
                res[1] = i;
                return res;
            }
        }
        return res;
    }
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    public void TestMethod(int[] nums, int target, int[] expected)
    {
        var result = TwoSum(nums, target);
        Assert.Equal(expected.Length, result.Length);
        for (int i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expected[i], result[i]);
        }
    }
}
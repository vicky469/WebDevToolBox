namespace LeetCode.Array_and_String.HashTable;

public class ContainsDuplicateII_219
{
    bool ContainsNearbyDuplicate(int[] nums, int k) {
        var map = new Dictionary<int,List<int>>();
        for(var i = 0; i < nums.Length; i++){
            if(!map.ContainsKey(nums[i])) {
                var list = new List<int>{i};
                map.Add(nums[i],list);
            }
            else{
                var lastIndex = map[nums[i]].Last();
                map[nums[i]].Add(i);
                if(Math.Abs(i-lastIndex) <= k) return true;
            }
        }
        return false;
    }
    
    [Theory]
    // [InlineData(new int[]{1,2,3,1},3,true)]
    // [InlineData(new int[]{1,0,1,1},1,true)]
    [InlineData(new int[]{1,2,3,1,2,3},2,false)]
    
    public void TestMethod(int[] nums, int k, bool result){
        Assert.Equal(result,ContainsNearbyDuplicate(nums,k));
    }
}
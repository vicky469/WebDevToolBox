namespace LeetCode.Array_and_String.HashTable;

public class TwoSumIIInputArrayIsSorted_167
{
    int[] TwoSum(int[] numbers, int target) {
        // key: substitute  value: current number
        var dic = new Dictionary<int,int>();
        for(int i = 0; i < numbers.Length; i++){
            var currentNum = numbers[i];// 2, 7
            var substitute = target -currentNum; // 7, 2
            if(dic.ContainsKey(currentNum)){
                return new int[2]{dic[currentNum]+1,i+1};
            }
            dic.TryAdd(substitute, i); //{7:0}
        }
        return new int[2]{-1,-1};
    }
    [Theory]
    [InlineData(new int[]{12,13,23,28,43,44,59,60,61,68,70,86,88,92,124,125,136,168,173,173,180,199,212,221,227,230,277,282,306,314,316,321,325,328,336,337,363,365,368,370,370,371,375,384,387,394,400,404,414,422,422,427,430,435,457,493,506,527,531,538,541,546,568,583,585,587,650,652,677,691,730,737,740,751,755,764,778,783,785,789,794,803,809,815,847,858,863,863,874,887,896,916,920,926,927,930,933,957,981,997}, 542, new int[]{24, 32})]
    public void Test_OK(int[] numbers, int target, int[] expectedResult)
    {
        var res = TwoSum(numbers, target);
        Assert.Equal(expectedResult, res);
    }
}
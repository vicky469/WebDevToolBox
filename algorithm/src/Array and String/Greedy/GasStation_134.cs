namespace LeetCode.Array_and_String.Greedy;

public class GasStation_134
{
    int CanCompleteCircuit(int[] gas, int[] cost)
    {
        var sumOfGas = gas.Sum();
        var sumOfCost = cost.Sum();
        if(sumOfGas < sumOfCost)return -1;
        
        var diff = new int[gas.Length];
        var start = 0;
        var total = 0;
        for(var i  = 0; i < gas.Length; i++)
        {
            diff[i] = gas[i] - cost[i];
            total += diff[i];
            if(total < 0)
            {
                start = i+1;
                total = 0;
                continue;
            }
            
        }

        return total >= 0? start:-1;

    }
    
    [Theory]
    [InlineData(new[] { 1,2,3,4,5}, new[] { 3,4,5,1,2},3)]
    [InlineData(new[] { 2, 3, 4}, new[] { 3,4,3},-1)]
    [InlineData(new[] { 3, 1, 1}, new[] { 1, 2, 2},0)]
    private void Test_OK(int[] gas, int[] cost, int expectedResult)
    {
        var res = CanCompleteCircuit(gas,cost);
        Assert.Equal(expectedResult, res);
    }

}


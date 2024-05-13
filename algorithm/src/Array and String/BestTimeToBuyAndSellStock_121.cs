namespace LeetCode;

public class BestTimeToBuyAndSellStock_121
{
    private static int MaxProfit(int[] prices)
    {
        var maxProfit = 0;
        for (var i = 0; i < prices.Length; i++)
        {
            var buy = prices[i];
            for (var j = i + 1; j < prices.Length; j++)
            {
                var sell = prices[j];
                var profit = sell - buy;
                maxProfit = Math.Max(maxProfit, profit);
            }
        }

        return maxProfit <= 0 ? 0 : maxProfit;
    }

    [Theory]
    [InlineData(new[] { 7, 1, 5, 3, 6, 4 }, 5)]
    [InlineData(new[] { 7, 6, 4, 3, 1 }, 0)]
    private void Test_OK(int[] input, int expectedResult)
    {
        var result = MaxProfit(input);
        Assert.Equal(expectedResult, result);
    }
}
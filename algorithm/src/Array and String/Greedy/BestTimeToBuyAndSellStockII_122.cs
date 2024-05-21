namespace LeetCode.Array_and_String.Greedy
{
    public class BestTimeToBuyAndSellStockII_122
    {
        int MaxProfit(int[] prices) {
            var maxProfit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                // if the price is higher than the previous one, we consider it as a profit.
                if (prices[i] > prices[i - 1])
                {
                    maxProfit += prices[i] - prices[i - 1];
                }
            }
            return maxProfit;
        }
        
        [Theory]
        [InlineData(new[] { 7,1,5,3,6,4 },  7)]
        private void Test_OK(int[] nums, int expectedResult)
        {
            var res = MaxProfit(nums);
            Assert.Equal(expectedResult, res);
        }
    }
}
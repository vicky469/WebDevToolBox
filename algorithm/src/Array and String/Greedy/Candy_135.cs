namespace LeetCode.Array_and_String.Greedy;

public class Candy_135
{
    int Candy(int[] ratings) {
        var n = ratings.Length;
        var candies = new int[n];
        for (var i = 0; i < n; i++) {
            candies[i] = 1;
        }
        for (var i = 1; i < n; i++) {
            if (ratings[i] > ratings[i - 1]) {
                candies[i] = candies[i - 1] + 1;
            }
        }
        for (var i = n - 2; i >= 0; i--) {
            if (ratings[i] > ratings[i + 1]) {
                candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
            }
        }
        return candies.Sum();
    }
    int Candy_WrongAns(int[] ratings) {
        int[] candies = new int[ratings.Length];
        var curr = 1;
        var prev = 0;
        candies[prev] = 1;
        while(curr < ratings.Length) {
            candies[curr] = 1;
            if (ratings[curr] > ratings[prev]) {
                candies[curr] = candies[prev]+1;
            }
            if (ratings[curr] < ratings[prev] && candies[prev] <= candies[curr]) {
                candies[prev] += 1;
            }
            prev = curr;
            curr++;
        }

        return candies.Sum();
    }

    [Theory]
    [InlineData(new[] { 1, 0, 2 }, 5)]
    [InlineData(new[] { 1,3,2,2,1}, 7)]
    [InlineData(new[] { 1,2,87,87,87,2,1}, 13)]
    private void Test_200(int[] ratings, int expectedResult)
    {
        var res = Candy(ratings);
        Assert.Equal(expectedResult, res);
    }
    
    [Theory]
    [InlineData(new[] { 1, 0, 2 }, 5)]
    [InlineData(new[] { 1,3,2,2,1}, 7)]
    [InlineData(new[] { 1,2,87,87,87,2,1}, 13)]
    private void Test_WrongAns_500(int[] ratings, int expectedResult)
    {
        var res = Candy_WrongAns(ratings);
        Assert.Equal(expectedResult, res);
    }
}   
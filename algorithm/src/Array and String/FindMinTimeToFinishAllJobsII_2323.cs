namespace LeetCode;

public class FindMinTimeToFinishAllJobsII_2323
{
    private static int MinimumTime(int[] jobs, int[] workers)
    {
        Array.Sort(jobs);
        Array.Sort(workers);
        var minDays = 0;
        for (var i = 0; i < workers.Length; i++)
        {
            var days = jobs[i] / workers[i];
            if (jobs[i] % workers[i] != 0) days += 1;
            minDays = Math.Max(minDays, days);
        }

        return minDays;
    }

    [Theory]
    [InlineData(new[] { 1 }, new[] { 2 }, 1)]
    [InlineData(new[] { 4, 2, 4, 1, 1 }, new[] { 3, 5, 1, 5, 2 }, 1)]
    [InlineData(new[] { 5 }, new[] { 2 }, 3)]
    private void Test_OK(int[] jobs, int[] workers, int expectedResult)
    {
        var result = MinimumTime(jobs, workers);
        Assert.Equal(expectedResult, result);
    }
}
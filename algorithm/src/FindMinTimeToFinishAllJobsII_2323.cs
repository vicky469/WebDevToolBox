namespace LeetCode;

public class FindMinTimeToFinishAllJobsII_2323 {
    static int MinimumTime(int[] jobs, int[] workers) {
        Array.Sort(jobs);
        Array.Sort(workers);
        int minDays = 0;
        for(int i = 0; i < workers.Length; i++){
            int days = jobs[i]/workers[i];
            if (jobs[i] % workers[i] != 0)
            {
                days += 1;
            }     
            minDays = Math.Max(minDays, days);
        }
        return minDays;
    }
    [Theory]
    [InlineData(new int[]{1}, new int[]{2}, 1)]
    [InlineData(new int[]{4,2,4,1,1}, new int[]{3,5,1,5,2}, 1)]
    [InlineData(new int[]{5}, new int[]{2}, 3)]
    private void Test_OK(int[] jobs, int[] workers, int expectedResult)
    {
        var result = MinimumTime(jobs, workers);
        Assert.Equal(expectedResult, result);
    }
}
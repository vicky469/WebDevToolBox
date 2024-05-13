namespace LeetCode.array_and_string.Frequency_Counter_Pattern;

public class FrequencyTracker
{
    private readonly int[] cnt = new int[100001]; // index: number, value: frequency
    private readonly int[] freq = new int[100001]; // index: frequency, value:cnt 

    public void Add(int number)
    {
        var oldFreq = cnt[number];
        cnt[number]++;
        if (oldFreq != 0) freq[oldFreq]--;
        freq[oldFreq + 1]++;
    }

    public void DeleteOne(int number)
    {
        var oldFreq = cnt[number];
        if (oldFreq > 0)
        {
            cnt[number]--;
            freq[oldFreq]--;
            freq[oldFreq - 1]++;
        }
    }

    public bool HasFrequency(int frequency)
    {
        return freq[frequency] > 0 ? true : false;
    }

    [Theory]
    [InlineData(2, true)]
    private void Test_OK(int frequency, bool expectedResult)
    {
        var tracker = new FrequencyTracker();
        tracker.Add(3);
        tracker.Add(3);
        tracker.Add(2);
        var result = tracker.HasFrequency(frequency);
        Assert.Equal(expectedResult, result);
    }
}
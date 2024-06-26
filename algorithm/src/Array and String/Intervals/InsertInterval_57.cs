namespace LeetCode.Array_and_String.Intervals;

public class InsertInterval_57: TestBase
{
    int[][] Insert(int[][] intervals, int[] newInterval)
    {
        var res = new List<int[]>();
        var i = 0;
        // 1. find where to insert
        while(i < intervals.Length && intervals[i][1] < newInterval[0]){
            res.Add(intervals[i]);
            i++;
        }

        // 2. merge intervals with the new interval, and add the merged interval to res
        while(i < intervals.Length && intervals[i][0] <= newInterval[1]){ // ‼️ <=
            newInterval[0] = Math.Min(intervals[i][0],newInterval[0]);
            newInterval[1] = Math.Max(intervals[i][1],newInterval[1]);
            i++;
        }
        res.Add(newInterval);

        while(i < intervals.Length){
            res.Add(intervals[i]);
            i++;
        }

        return res.ToArray();
    }

    [Theory]
    [MemberData(nameof(TestInsertIntervalData))]
    public void Test_Given_Intervals_And_NewInterval_Return_Merged_Intervals(int[][] intervals, int[] newInterval,
        int[][] expected)
    {
        var actual = Insert(intervals, newInterval);
        Assert.Equal(expected, actual);
    }

    public static IEnumerable<object[]> TestInsertIntervalData
    {
        get
        {
            yield return new object[]
            {
                new int[][] { new int[] { 1, 3 }, new int[] { 6, 9 } },
                new int[] { 2, 5 },
                new int[][] { new int[] { 1, 5 }, new int[] { 6, 9 } }
            };
            yield return new object[]
            {
                new int[][] { new int[] { 1, 2 }, new int[] { 3, 5 }, new int[] { 6, 7 }, new int[] { 8, 10 }, new int [] { 12, 16 } },
                new int[] { 4, 8 },
                new int[][] { new int[] { 1, 2 }, new int[] { 3, 10 }, new int[] { 12,16 } },
            };
        }
    }

    public InsertInterval_57(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }
}
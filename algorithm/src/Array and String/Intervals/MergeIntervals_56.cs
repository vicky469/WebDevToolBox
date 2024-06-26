namespace LeetCode.Array_and_String.Sorting;

public class MergeIntervals_56
{
    int[][] Merge(int[][] intervals) {
        if (intervals.Length == 0) return intervals;
        var res = new List<int[]>();
        Array.Sort(intervals, (a,b) => a[0] - b[0]);
        for(var i = 0; i < intervals.Length; i++)
        {
            // if merged intervals is empty or no overlap
            if (res.Count == 0 || intervals[i][0]  > res[res.Count - 1][1])
            {
                res.Add(intervals[i]);
            }
            else
            {
                res[res.Count - 1][1] = Math.Max(res[res.Count - 1][1], intervals[i][1]);
            }
        }
        return res.ToArray();
    }
    
    [Theory]
    [MemberData(nameof(MergeIntervalsTestData))]
    public void Test_Given_Intervals_Return_Merged_Intervals(int[][] intervals, int[][] expected)
    {
        var actual = Merge(intervals);
        Assert.Equal(expected, actual);
    }
    
    public static IEnumerable<object[]> MergeIntervalsTestData =>
        new List<object[]>
        {
            new object[]
            {
                new int[][]{new int[]{1,3}, new int[]{4,8}, new int[]{5,9}, new int[]{15,18}},
                new int[][]{new int[]{1,3},new int[]{4,9}, new int[]{15,18}}
            },
            new object[]
            {
                new int[][]{new int[]{1,3}, new int[]{2,6}, new int[]{8,10}, new int[]{15,18}},
                new int[][]{new int[]{1,6}, new int[]{8,10}, new int[]{15,18}}
            },
            new object[]
            {
                new int[][]{new int[]{1,4}, new int[]{4,5}},
                new int[][]{new int[]{1,5}}
            },
            new object[]
            {
                new int[][]{new int[]{2,3}, new int[]{4,5}, new int[]{6,7}, new int[]{8,9} ,new int[]{1,10}},
                new int[][]{new int[]{1,10}}
            },
        };
}
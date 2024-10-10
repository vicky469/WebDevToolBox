namespace LeetCode.Array_and_String.Intervals;

public class MeetingRooms_252
{
    bool CanAttendMeetings(int[][] intervals) {
        // find overlapping
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        for (var i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] < intervals[i - 1][1])
            {
                return false;
            }
        }
        return true;
    }
    
    [Theory]
    [MemberData(nameof(CanAttendMeetingsTestData))]
    public void TestForCanAttendMeetings(int[][] intervals, bool expected)
    {
        var result = CanAttendMeetings(intervals);
        Assert.Equal(expected, result);
    }
    public static IEnumerable<object[]> CanAttendMeetingsTestData
    {
        get => new[]
        {
            new object[]
            {
                new int[][]
                {
                    new int[] { 0, 30 },
                    new int[] { 5, 10 },
                    new int[] { 15, 20 }
                },
                false
            },
            new object[]
            {
                new int[][]
                {
                    new int[] { 7, 10 },
                    new int[] { 2, 4 }
                },
                true
            }
        };
    }
}
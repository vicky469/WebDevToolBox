namespace LeetCode.Array_and_String.Sweep_Line;

public class MeetingRoomsII_253
{
    int MinMeetingRooms2(int[][] intervals)
    {
        if (intervals.Length == 0) return 0;
        var start = new int[intervals.Length];
        var end = new int[intervals.Length];
        
        for (var i = 0; i < intervals.Length; i++)
        {
            start[i] = intervals[i][0];
            end[i] = intervals[i][1];
        }
        
        Array.Sort(start);
        Array.Sort(end);
        
        var startPointer = 0;
        var endPointer = 0;
        var usedRooms = 0;
        
        while (startPointer < intervals.Length)
        {
            if (start[startPointer] < end[endPointer])
            {
                usedRooms++;
                startPointer++;
            }
            else
            {
                usedRooms--;
                endPointer++;
            }
        }
        
        return usedRooms;
    }
    
    [Theory]
    [MemberData(nameof(MeetingRoomsTestData))]
    public void Test(int[][] intervals, int expected)
    {
        Assert.Equal(expected, MinMeetingRooms2(intervals));
    }
    public static IEnumerable<object[]> MeetingRoomsTestData()
    {
        yield return new object[] { new[]{new[]{0,30}, new[]{5,10}, new[]{15,20}}, 2 };
        yield return new object[] { new[]{new[]{7,10}, new[]{2,4}}, 1 };
        yield return new object[] { new[]{new[]{13,15}, new[]{1,13}}, 1 };
        yield return new object[] { new[]{new[]{9,10}, new[]{4,9}, new[]{4,17}} ,2 };
    }
}
namespace LeetCode.Array_and_String.Intervals;

public class MeetingRoomsII_253
{
    // minHeap
    int MinMeetingRooms(int[][] intervals)
    {
        if (intervals.Length == 0) return 0;
        Array.Sort(intervals, (a,b)=>a[0]-b[0]);
        
        // Initialize a priority queue to keep track the currently used rooms
        // The SortedSet is a data structure that automatically sorts its elements
        var minHeap = new SortedSet<(int, int)>(Comparer<(int, int)>.Create(CompareTuples));
        
        minHeap.Add((intervals[0][1], intervals[0][0]));

        for (var i = 1; i < intervals.Length; i++)
        {
            // If the current meeting starts after the meeting that ends the earliest, they can use the same room
            // Remove the meeting that ended the earliest from the heap 
            if (intervals[i][0] >= minHeap.Min.Item1)
            {
                minHeap.Remove(minHeap.Min);
            }

            // Add the current meeting
            minHeap.Add((intervals[i][1], intervals[i][0]));
        }

        // The size of the heap is the minimum number of rooms required
        return minHeap.Count;
    }
    
    private static int CompareTuples((int, int) a, (int, int) b)
    {
        if (a.Item1 != b.Item1)
        {
            // Sort by end time asc
            return a.Item1.CompareTo(b.Item1);
        }
        else
        {
            // If the end time is the same, sort by start time asc
            return a.Item2.CompareTo(b.Item2);
        }
    }
    
    [Theory]
    [MemberData(nameof(MeetingRoomsTestData))]
    public void Test(int[][] intervals, int expected)
    {
        Assert.Equal(expected, MinMeetingRooms(intervals));
    }
    public static IEnumerable<object[]> MeetingRoomsTestData()
    {
        yield return new object[] { new[]{new[]{0,30}, new[]{5,10}, new[]{15,20}}, 2 };
        yield return new object[] { new[]{new[]{7,10}, new[]{2,4}}, 1 };
        yield return new object[] { new[]{new[]{13,15}, new[]{1,13}}, 1 };
        yield return new object[] { new[]{new[]{9,10}, new[]{4,9}}, new[]{4,17} ,2 };
    }
}
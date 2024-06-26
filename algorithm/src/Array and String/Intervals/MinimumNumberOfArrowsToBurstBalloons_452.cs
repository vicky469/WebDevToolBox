namespace LeetCode.Array_and_String.Intervals;

public class MinimumNumberOfArrowsToBurstBalloons_452
{
    int FindMinArrowShots(int[][] points)
    {
        if (points.Length == 0) return 0;
        // Sort by end point
        Array.Sort(points, (a, b) => a[1] - b[1]);
        var arrows = 1;
        var arrowPos = points[0][1]; // end of the first interval

        for (var i = 1; i < points.Length; i++)
        {
            // If the current balloon can be burst by the current arrow shot
            if (points[i][0] <= arrowPos)
            {
                continue;
            }

            // Else, we need another arrow
            arrows++;
            arrowPos = points[i][1];
        }

        return arrows;
    }

    [Theory]
    [MemberData(nameof(FindMinArrowShotsTestData))]
    public void TestForMinimumNumberOfArrowsToBurstBalloons(int[][] points, int expected)
    {
        var result = FindMinArrowShots(points);
        Assert.Equal(expected, result);
    }

    public static IEnumerable<object[]> FindMinArrowShotsTestData
    {
        get
        {
            yield return new object[]
            {
                new int[][] { new int[] { 10, 16 }, new int[] { 2, 8 }, new int[] { 1, 6 }, new int[] { 7, 12 } },
                2
            };
            yield return new object[]
            {
                new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 } },
                4
            };
            yield return new object[]
            {
                new int[][] { new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 3, 4 }, new int[] { 4, 5 } },
                2
            };
        }
    }
}
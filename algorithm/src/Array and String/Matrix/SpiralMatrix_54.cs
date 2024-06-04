namespace LeetCode.Array_and_String.Matrix;

public class SpiralMatrix_54: TestBase
{
    IList<int> SpiralOrder(int[][] matrix)
    {
        IList<int> result = new List<int>();
        if (matrix.Length == 0) return result;

        var top = 0;
        var bottom = matrix.Length - 1;
        var left = 0;
        var right = matrix[0].Length - 1;

        while (top <= bottom && left <= right)
        {
            //➡️
            for (var i = left; i <= right; i++)
            {
                result.Add(matrix[top][i]);
            }
            top++;

            //⬇️
            for (var i = top; i <= bottom; i++)
            {
                result.Add(matrix[i][right]);
            }
            right--;

            // because we have top++ and right-- so we need to check again
            if (top <= bottom)
            {
                //⬅️
                for (var i = right; i >= left; i--)
                {
                    result.Add(matrix[bottom][i]);
                }
                bottom--;
            }

            if (left <= right)
            {
                //⬆️
                for (var i = bottom; i >= top; i--)
                {
                    result.Add(matrix[i][left]);
                }
                left++;
            }
        }

        return result;

    }
    [Theory]
    [MemberData(nameof(TestSpiralOrderData))]
    public void Test_Given_Matrix_Return_Spiral_Order(int[][] matrix, int[] expected)
    {
        var res = SpiralOrder(matrix);
        Assert.Equal(expected, res);
    }

    public static IEnumerable<object[]> TestSpiralOrderData() =>
        new List<object[]>
        {
            new object[]
            {
                new int[][] { new int[] { 1}},
                new int[] { 1 }
            },
            // new object[]
            // {
            //     new int[][] { new int[] { 1 }, new int[] { 2} },
            //     new int[] { 1, 2}
            // },
            // new object[]
            // {
            //     new int[][] { new int[] { 1, 2, 3, 4 }, new int[] { 5, 6, 7, 8 }, new int[] { 9, 10, 11, 12 } },
            //     new int[] { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 }
            // }
        };

    public SpiralMatrix_54(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }
}
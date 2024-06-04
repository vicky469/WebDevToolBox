namespace LeetCode.Array_and_String.Matrix;

public class RotateImage_48
{
    void Rotate(int[][] matrix) {
        var n = matrix.Length;
        for (var i = 0; i < n / 2; i++)
        {
            for (var j = i; j < n - i - 1; j++)
            {
                var temp = matrix[i][j];
                matrix[i][j] = matrix[n - j - 1][i];
                matrix[n - j - 1][i] = matrix[n - i - 1][n - j - 1];
                matrix[n - i - 1][n - j - 1] = matrix[j][n - i - 1];
                matrix[j][n - i - 1] = temp;
            }
        }
    }
    [Theory]
    [MemberData(nameof(TestRotateData))]
    public void Test_Rotate(int[][] input, int[][] expected)
    {
        Rotate(input);
        Assert.Equal(expected, input);
    }
    
    public static IEnumerable<object[]> TestRotateData() =>
        new List<object[]>
        {
            new object[]
            {
                new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } },
                new int[][] { new int[] { 7, 4, 1 }, new int[] { 8, 5, 2 }, new int[] { 9, 6, 3 }} 
            }
        };
    
}
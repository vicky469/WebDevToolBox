namespace LeetCode.Array_and_String.Matrix;

public class RotateImage_48: TestBase
{
    void Rotate(int[][] matrix) {
        var n = matrix.Length;

        // Transpose the matrix
        for (var i = 0; i < n; i++) {
            for (var j = i; j < n; j++) { // j=i to only swap elements across the main diagonal once
                (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
            }
        }

        // Reverse each row
        for (var i = 0; i < n; i++) {
            for (var j = 0; j < n / 2; j++) {
                (matrix[i][j], matrix[i][n - j - 1]) = (matrix[i][n - j - 1], matrix[i][j]);
            }
        }
    }
    
    public void Rotate_WrongAns(int[][] matrix) {
        var n = matrix.Length;
        for(var i = 0; i < n/2; i++){
            for(var j = i; j < n/2; j++){
                var tmp = matrix[i][j];
                matrix[i][j] = matrix[n-i-1][j];
                matrix[n-i-1][j] = matrix[n-i-1][n-j-1]; 
                matrix[n-i-1][n-j-1] = matrix[i][n-j-1];
                matrix[i][n-j-1] = tmp;
            }
        }
    }
    void Rotate_Comment(int[][] matrix) {
        var n = matrix.Length;
        // n/2 is the number of layers
        for (var i = 0; i < n / 2; i++)
        {
            for (var j = i; j < n - i - 1; j++)
            {
                var temp = matrix[i][j];
                TestOutputHelper.WriteLine($"i: {i}, j: {j}, temp: {temp}");
                matrix[i][j] = matrix[n - j - 1][i]; // top left = bottom left
                TestOutputHelper.WriteLine($"matrix[{i}][{j}] = matrix[{n - j - 1}][{i}]");
                matrix[n - j - 1][i] = matrix[n - i - 1][n - j - 1]; // bottom left = bottom right
                TestOutputHelper.WriteLine($"matrix[{n - j - 1}][{i}] = matrix[{n - i - 1}][{n - j - 1}]");
                matrix[n - i - 1][n - j - 1] = matrix[j][n - i - 1]; // bottom right = top right
                TestOutputHelper.WriteLine($"matrix[{n - i - 1}][{n - j - 1}] = matrix[{j}][{n - i - 1}]");
                matrix[j][n - i - 1] = temp; // top right = top left
                TestOutputHelper.WriteLine($"matrix[{j}][{n - i - 1}] = {temp}");
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

    public RotateImage_48(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }
}
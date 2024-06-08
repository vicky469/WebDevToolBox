namespace LeetCode.Array_and_String.Matrix;

public class RotateImage_48: TestBase
{
    void Rotate_Practice(int[][] matrix) {
        TestOutputHelper.WriteLine("Input");
        Print2DArray(matrix);
        //transpose
        for(var i = 0; i < matrix.Length; i++){
            for(var j = i; j < matrix[0]. Length; j++){
                (matrix[i][j],matrix[j][i])=(matrix[j][i], matrix[i][j]);
            }
        }
        TestOutputHelper.WriteLine("After transpose");
        Print2DArray(matrix);
        TestOutputHelper.WriteLine("After revert row by row");
        Print2DArray(matrix);
        
        // revert row by row
        for(var i = 0; i < matrix.Length; i++){
            for(var j = 0; j < matrix[0].Length/2; j++){
                var tmp = matrix[i][j];
                matrix[i][j] = matrix[i][matrix[0].Length-1-j];
                matrix[i][matrix[0].Length-1-j] = tmp;
            }
        }
    }
    
    
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
                (matrix[i][j], matrix[i][n - j - 1]) = (matrix[i][n - j - 1], matrix[i][j]); // remember to -j
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
    
    
    [Theory]
    [MemberData(nameof(TestRotateData))]
    public void Test_Rotate(int[][] input, int[][] expected)
    {
        //Rotate(input);
        Rotate_Practice(input);
        Assert.Equal(expected, input);
    }
    
    public static IEnumerable<object[]> TestRotateData() =>
        new List<object[]>
        {
            new object[]
            {
                new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } }, // input
                new int[][] { new int[] { 7, 4, 1 }, new int[] { 8, 5, 2 }, new int[] { 9, 6, 3 }}  // expected
            },
            new object[]
            {
                new int[][] { new int[] { 5, 1, 9, 11 }, new int[] { 2, 4, 8, 10 }, new int[] { 13, 3, 6, 7 }, new int[] { 15, 14, 12, 16 } },
                new int[][] { new int[] { 15, 13, 2, 5 }, new int[] { 14, 3, 4, 1 }, new int[] { 12, 6, 8, 9 }, new int[] { 16, 7, 10, 11 }}
            }
        };

    public RotateImage_48(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }
    
    void Print2DArray(int[][] matrix) {
        for (int i = 0; i < matrix.Length; i++) {
            var sb = new StringBuilder();
            for (int j = 0; j < matrix[i].Length; j++) {
                sb.Append(matrix[i][j] + ", ");
            }
            TestOutputHelper.WriteLine(sb.ToString());
        }
    }
}
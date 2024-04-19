namespace LeetCode;

public class AreaOfMaxDiagonal_100170
{
    static int AreaOfMaxDiagonal(int[][] dimensions) {
        if (dimensions.Length == 0) {
            return 0;
        }

        var longestDiagonal = 0.0;
        var possibleRes = new List<(double, int)>(); // diag: res

        for (int i = 0; i < dimensions.Length; i++) {
            var num1 = dimensions[i][0];
            var num2 = dimensions[i][1];
            var diag = (double)num1 * num1 + num2 * num2;

            var sqrtRes = Math.Sqrt(diag);
            if (sqrtRes > longestDiagonal) {
                longestDiagonal = sqrtRes;
                var res = dimensions[i][0] * dimensions[i][1];
                possibleRes.Clear(); // Clear the list since we found a longer diagonal
                possibleRes.Add((diag, res));
            } else if (Math.Abs(sqrtRes - longestDiagonal) < double.Epsilon) {
                // Handle the case when diagonals are equal
                var res = dimensions[i][0] * dimensions[i][1];
                possibleRes.Add((diag, res));
            }
        }

        var output = possibleRes.MaxBy(tuple => tuple.Item2);
        return output.Item2;
    }
    
    [Theory]
    [InlineData(48,new []{ 9, 3 }, new [] { 8, 6 })]
    [InlineData(12, new[] {3, 4 },new [] { 4, 3 } )]
    [InlineData(2028,  new [] {4, 7}, new [] {8, 9}, new [] {5, 3}, new [] {6, 10}, new [] {2, 9},
        new [] {3, 10}, new [] {2, 2}, new [] {5, 8}, new [] {5, 10}, new [] {5, 6},
        new [] {8, 9}, new [] {10, 7}, new [] {8, 9}, new [] {3, 7}, new [] {2, 6},
        new [] {5, 1}, new [] {7, 4}, new [] {1, 10}, new [] {1, 7}, new [] {6, 9},
        new [] {3, 3}, new [] {4, 6}, new [] {8, 2}, new [] {10, 6}, new [] {7, 9},
        new [] {9, 2}, new [] {1, 2}, new [] {3, 8}, new [] {10, 2}, new [] {4, 1},
        new [] {9, 7}, new [] {10, 3}, new [] {6, 9}, new [] {9, 8}, new [] {7, 7},
        new [] {5, 7}, new [] {5, 4}, new [] {6, 5}, new [] {1, 8}, new [] {2, 3},
        new [] {7, 10}, new [] {3, 9}, new [] {5, 7}, new [] {2, 4}, new [] {5, 6},
        new [] {9, 5}, new [] {8, 8}, new [] {8, 10}, new [] {6, 8}, new [] {5, 1},
        new [] {10, 8}, new [] {7, 4}, new [] {2, 1}, new [] {2, 7}, new [] {10, 3},
        new [] {2, 5}, new [] {7, 6}, new [] {10, 5}, new [] {10, 9}, new [] {5, 7},
        new [] {10, 6}, new [] {4, 3}, new [] {10, 4}, new [] {1, 5}, new [] {8, 9},
        new [] {3, 1}, new [] {2, 5}, new [] {9, 10}, new [] {6, 6}, new [] {5, 10},
        new [] {10, 2}, new [] {6, 10}, new [] {1, 1}, new [] {8, 6}, new [] {1, 7},
        new [] {6, 3}, new [] {9, 3}, new [] {1, 4}, new [] {1, 1}, new [] {10, 4},
        new [] {7, 9}, new [] {4, 5}, new [] {2, 8}, new [] {7, 9}, new [] {7, 3},
        new [] {4, 9}, new [] {2, 8}, new [] {4, 6}, new [] {9, 1}, new [] {8, 4},
        new [] {2, 4}, new [] {7, 8}, new [] {3, 5}, new [] {7, 6}, new [] {8, 6},
        new [] {4, 7}, new [] {25, 60}, new [] {39, 52}, new [] {16, 63}, new [] {33, 56 }
        )]
    private void Test_OK( int expectedResult,params int[][] input)
    {
        var result = AreaOfMaxDiagonal(input);
        Assert.Equal(expectedResult, result);
    }
    
    
}
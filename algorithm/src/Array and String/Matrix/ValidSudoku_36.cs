namespace LeetCode.Array_and_String.Matrix;

public class ValidSudoku_36: TestBase
{
    bool IsValidSudoku(char[][] board)
    {
        var rows = new HashSet<char>[9];
        var cols = new HashSet<char>[9];
        var boxes = new HashSet<char>[9];
        // Initialize the hashset for each row, col, and box
        for (int i = 0; i < 9; i++)
        {
            rows[i] = new HashSet<char>(); // [ {}, {}, {}, {}, {}, {}, {}, {}, {} ]
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }
        // check rows
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                var c = board[i][j];
                if (c == '.') continue;
                if (rows[i].Contains(c)) return false;
                rows[i].Add(c);
            }
        }
        // check cols
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                var c = board[j][i];
                if (c == '.') continue;
                if (cols[i].Contains(c)) return false;
                cols[i].Add(c);
            }
        }
        
        // check boxes
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                var c = board[i][j];
                if (c == '.') continue;
                var boxIndex = (i / 3) * 3 + j / 3;
                if (boxes[boxIndex].Contains(c)) return false;
                boxes[boxIndex].Add(c);
            }
        }
        
        return true;
    }
    [Theory]
    [InlineData(new char[]{
        '5','3','.','.','7','.','.','.','.',
        '6','.','.','1','9','5','.','.','.',
        '.','9','8','.','.','.','.','6','.',
        '8','.','.','.','6','.','.','.','3',
        '4','.','.','8','.','3','.','.','1',
        '7','.','.','.','2','.','.','.','6',
        '.','6','.','.','.','.','2','8','.',
        '.','.','.','4','1','9','.','.','5',
        '.','.','.','.','8','.','.','7','9'
    }, true)]
    [InlineData(new char[]{
        '8','3','.','.','7','.','.','.','.',
        '6','.','.','1','9','5','.','.','.',
        '.','9','8','.','.','.','.','6','.',
        '8','.','.','.','6','.','.','.','3',
        '4','.','.','8','.','3','.','.','1',
        '7','.','.','.','2','.','.','.','6',
        '.','6','.','.','.','.','2','8','.',
        '.','.','.','4','1','9','.','.','5',
        '.','.','.','.','8','.','.','7','9'
    }, false)]
    public void Test_OK(char[] flatBoard, bool expected)
    {
        // Reshape the flatBoard into a 2D array
        char[][] board = new char[9][];
        for (int i = 0; i < 9; i++)
        {
            board[i] = new char[9];
            Array.Copy(flatBoard, i * 9, board[i], 0, 9);
        }

        var res = IsValidSudoku(board);
        Assert.Equal(expected, res);
    }

    public ValidSudoku_36(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }
}
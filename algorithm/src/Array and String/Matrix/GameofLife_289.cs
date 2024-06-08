namespace LeetCode.Array_and_String.Matrix;

public class GameofLife_289
{
    void GameOfLife(int[][] board) {
        for(var i = 0; i < board.Length; i++){
            for(var j = 0; j < board[0].Length; j++){
                var liveNeighbors = CountLiveNeighbors(board,i,j);
                if(board[i][j] ==1){
                    //if(liveNeighbors <2 || liveNeighbors>3) board[i][j] = 1;
                    if(liveNeighbors ==2 || liveNeighbors==3) board[i][j] = 3;
                }
                else if(board[i][j] ==0){
                    if(liveNeighbors==3) board[i][j] = 2;
                }
            }
        }
        // Convert the states back to 0 and 1
        for (int i = 0; i < board.Length; i++) {
            for (int j = 0; j < board[0].Length; j++) {
                if(board[i][j] == 1) board[i][j] = 0;
                if(board[i][j] == 2 || board[i][j] == 3) board[i][j] = 1;
            }
        }
    }
    
    // O(m*n) time complexity
    // O(m*n) space complexity
    void GameOfLife_O_N_Space(int[][] board) {
        // use copyBoard to do lookup and calculation
        // use board to update the result
        int[][] copyBoard = board.Select(a => (int[])a.Clone()).ToArray();

        for(var i = 0; i < board.Length; i++){
            for(var j = 0; j < board[0].Length; j++)
            {
                var liveNeighbors = CountLiveNeighbors(copyBoard,i,j);
                switch (copyBoard[i][j])
                {
                    case 1:
                    {
                        if(liveNeighbors <2 || liveNeighbors>3) board[i][j] = 0;
                        if(liveNeighbors==2 || liveNeighbors==3) board[i][j] = 1;
                        break;
                    }
                    case 0:
                    {
                        if(liveNeighbors==3) board[i][j] = 1;
                        break;
                    }
                }
            }
        }
    }

    int CountLiveNeighbors(int[][] board, int i, int j)
    {
        var cnt = 0;
        for (var x = i - 1; x <= i + 1; x++)
        {
            for (var y = j - 1; y <= j + 1; y++)
            {
                if (x == i && y == j) continue;
                if (x >= 0 && x < board.Length
                           && y >= 0 && y < board[0].Length
                           && (board[x][y] == 1 || board[x][y] == 3)) // state 1 and 3 both indicate original state is 1
                    cnt++;
            }
        }

        return cnt;
    }

    [Theory]
    [MemberData(nameof(TestGameOfLifeData))]
    public void Test1(int[][] board, int[][] expected)
    {
        GameOfLife(board);
        Assert.Equal(expected, board);
    }
    
    public static IEnumerable<object[]> TestGameOfLifeData
    {
        get
        {
            yield return new object[]
            {
                new int[][]{new int[]{0,1,0}, new int[]{0,0,1}, new int[]{1,1,1}, new int[]{0,0,0}},
                new int[][]{new int[]{0,0,0}, new int[]{1,0,1}, new int[]{0,1,1}, new int[]{0,1,0}}
            };
        }
    }
}
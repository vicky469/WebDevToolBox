namespace LeetCode.Array_and_String.Matrix;

public class SetMatrixZeroes_73
{
    void SetZeroes(int[][] matrix)
    {
        var rows = new bool[matrix.Length];
        var cols = new bool[matrix[0].Length];
        
        // find and mark the rows and cols that have 0
        for(var i = 0; i < matrix.Length; i++){
            for(var j = 0; j < matrix[0].Length; j++){
                if(matrix[i][j]== 0){
                    rows[i]=true;
                    cols[j]=true; 
                }
            }
        }
        
        // set the rows to 0
        for(var i = 0; i < rows.Length; i++){
            if(rows[i]){
                for(var j = 0; j < matrix[0].Length; j++){
                    matrix[i][j] = 0;
                }
            }
            
        }
        
        // set the cols to 0
        for(var j = 0; j < cols.Length; j++){
            if(cols[j]){
                for(var i = 0; i < rows.Length; i++){
                    matrix[i][j] = 0;
                }
            } 
        }
    }
}
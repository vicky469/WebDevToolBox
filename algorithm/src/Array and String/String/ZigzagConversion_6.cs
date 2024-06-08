namespace LeetCode.Array_and_String.String;
// #string_manipulation
// go up and down
public class ZigzagConversion_6
{
    string Convert(string s, int numRows) {
        if (numRows == 1) return s;
        var rows = new List<StringBuilder>();
        
        for (var i = 0; i < Math.Min(numRows, s.Length); i++)
            //              ^^ Important! In case if string is shorter than numRows
            rows.Add(new StringBuilder());
        
        var isDown = true;
        var row = 0;
 
        for (var i = 0; i < s.Length; i++)
        {
            rows[row].Append(s[i]);
            // prepare for next iteration
            if (row == 0) isDown = true;
            if (row == numRows-1) isDown = false;
            row = isDown ? row+1:row-1;
        }
       
        var res = new StringBuilder();
        foreach (var r in rows) res.Append(r);
        return res.ToString();
    }
    
    
    [Theory]
    [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
    [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]

    private void Test_OK(string s, int numRows, string expectedResult)
    {
        var result = Convert(s, numRows);
        Assert.Equal(expectedResult, result);
    }
}
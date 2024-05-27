namespace LeetCode.Array_and_String.String;

public class LongestCommonPrefix_14
{
    string LongestCommonPrefix(string[] strs) {
        var prefix = strs[0];

        for (var i = 0; i < prefix.Length; i++){
            var c = prefix[i];
            for(var j = 1; j < strs.Length; j++){
                // need to make sure the second and later strs are not shorter than the first one.
                if(i == strs[j].Length || strs[j][i] != c) // easy to make mistake here and get index out of bound.
                {
                    return prefix.Substring(0,i);
                } 
            }
        }
        return prefix;
    }
    
    [Theory]
    //[InlineData(new string[]{"flower","flow","flight"}, "fl")]
    [InlineData(new string[]{"ab", "a"}, "a")]
    private void Test_OK(string[] strs, string expectedResult)
    {
        var result = LongestCommonPrefix(strs);
        Assert.Equal(expectedResult, result);
    }
    
}
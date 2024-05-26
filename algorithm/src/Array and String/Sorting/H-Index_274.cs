namespace LeetCode.Array_and_String.Sorting;

public class H_Index_274
{
    int HIndex(int[] citations) {
        citations = citations.OrderByDescending(c => c).ToArray();
        var hIndex = 0;
        for (var i = 0; i < citations.Length; i++) {
            if (citations[i] >= i + 1) {
                hIndex ++;
            } else {
                break;
            }
        }
        return hIndex;
    }
    
    [Theory]
    [InlineData(new[] { 100},  1)]
    [InlineData(new[] { 1,3,1 },  1)]
    [InlineData(new[] { 33, 30, 20, 15, 8, 8, 8, 7 },  7)]
    private void Test_OK(int[] citations, int expectedResult)
    {
        var res = HIndex(citations);
        Assert.Equal(expectedResult, res);
    }
}
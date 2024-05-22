namespace LeetCode.Array_and_String.Sorting;

public class H_Index_274
{
    // TODO: come back later
    int HIndex(int[] citations) {
        citations = citations.OrderByDescending(c => c).ToArray();
        int hIndex = 0;
        for (int i = 0; i < citations.Length; i++) {
            if (citations[i] >= i + 1) {
                hIndex = i + 1;
            } else {
                break;
            }
        }
        return hIndex;
    }
    
    [Theory]
    [InlineData(new[] { 100},  1)]
    [InlineData(new[] { 1,3,1 },  1)]
    private void Test_OK(int[] citations, int expectedResult)
    {
        var res = HIndex(citations);
        Assert.Equal(expectedResult, res);
    }
}
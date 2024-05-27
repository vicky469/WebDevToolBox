namespace LeetCode.Data_Structure;

public class TreeNodeTests
{
    public int[] ExpectedResult { get; set; }
    public int?[] Vals { get; set; }
    public static IEnumerable<object[]> TestCases()
    {
        yield return new object[] 
        { 
            //     1
            //    /  \
            //    2   3
            //   / \    \
            //  4   5    7
            
            new TreeNodeTests
            {
                Vals = new int?[] { 1, 2, 3, 4, 5, null, 7 }, 
                ExpectedResult = new int[] { 1, 2, 3, 4, 5, 7 }
            } };
    }
   
}
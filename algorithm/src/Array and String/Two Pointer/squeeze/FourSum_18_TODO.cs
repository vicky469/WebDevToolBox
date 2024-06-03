namespace LeetCode.Array_and_String.Two_Pointer.squeeze;

public class FourSum_18_TODO {
    IList<IList<int>> FourSum(int[] nums, int target) {
        var res = new List<IList<int>>();
        return res;
    }
    [Theory]
    [MemberData(nameof(TestFourSumDataOk))]
    private void Test_1(int[] nums, int target, IList<IList<int>>  expected){
        IList<IList<int>> expectedData = expected.Select(n => (IList<int>)n.ToList()).ToList();
        var res = FourSum(nums, target);
        var actualData = res
            .Select(n => n.OrderBy(i => i).ToList() as IList<int>)
            .ToList();
        Assert.Equal(expected, actualData);
    }
    
    public static IEnumerable<object[]> TestFourSumDataOk =>
        new List<object[]>
        {
            new object[] 
            { 
                new[] { 2,2,2,2,2}, 
                8,
                new List<IList<int>>
                { 
                    new List<int> { 2,2,2,2 }
                }
            },
            new object[] 
            { 
                new[] { 1,0,-1,0,-2,2 }, 
                0,
                new List<IList<int>>
                { 
                    new List<int> {-2,-1,1,2},
                    new List<int> { -2,0,0,2 },
                    new List<int> { -1,0,0,1 }
                }
            }
        };
}
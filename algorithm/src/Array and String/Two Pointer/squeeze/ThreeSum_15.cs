namespace LeetCode.Array_and_String.Two_Pointer;

public class ThreeSum_15: TestBase {
    IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var res = new List<IList<int>>();
        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i == 0 || nums[i] == nums[i - 1])
            {
                TwoSum(nums, i, res);
            }
        }
        return res;
    }

    private static void TwoSum(int[] nums, int i, List<IList<int>> res)
    {
        var j = i + 1;
        var k = nums.Length - 1;
        while (j < k) {
            int sum = nums[j] + nums[k];
            if (sum == -nums[i]) {
                res.Add(new List<int> { nums[i], nums[j], nums[k] });
                while (j < k && nums[j] == nums[j + 1]) j++; // Skip duplicate numbers
                while (j < k && nums[k] == nums[k - 1]) k--; // Skip duplicate numbers
                j++; k--;
            } else if (sum < -nums[i]) {
                j++;
            } else {
                k--;
            }
        }
    }

    // wrong solution
    void Two(int[] nums, int i,List<IList<int>> res)
    {
        var j = i + 1;
        var k = nums.Length - 1;
        while (j < k)
        {
            var complement = -nums[i] - nums[j];
            if (complement == nums[k])
            {
                res.Add(new List<int> { nums[i], nums[j], nums[k] });
                while (j < k && nums[j] == nums[j + 1]) j++; // Skip duplicate numbers
                while (j < k && nums[k] == nums[k - 1]) k--; // Skip duplicate numbers
                j++; 
                k--;
            }
            else if (complement < nums[k])
            {
                j++;
            }
            else
            {
                k--;
            }
        }
    }
    
    // [Theory]
    // [MemberData(nameof(TestThreeSumData))]
    // private void Test_1(int[] nums, IList<IList<int>>  expected)
    // {
    //     IList<IList<int>> expectedData = expected.Select(n => (IList<int>)n.ToList()).ToList();
    //     var res = ThreeSum(nums);
    //     Assert.Equal(expectedData, res);
    // }
    
    [Theory]
    [MemberData(nameof(TestThreeSumDataOk))]
    private void Test_2(int[] nums, IList<IList<int>>  expected)
    {
        IList<IList<int>> expectedData = expected
            .Select(n => n.OrderBy(i => i).ToList() as IList<int>)
            .ToList();
        var res = ThreeSum(nums);
        var actualData = res
            .Select(n => n.OrderBy(i => i).ToList() as IList<int>)
            .ToList();
        Assert.Equal(expectedData, actualData);
    }
    
    [Theory]
    [MemberData(nameof(TestThreeSumData500))]
    private void Test_Experiment(int[] nums, IList<IList<int>>  expected)
    {
        IList<IList<int>> expectedData = expected
            .Select(n => n.OrderBy(i => i).ToList() as IList<int>)
            .ToList();
        var res = ThreeSum(nums);
        var actualData = res
            .Select(n => n.OrderBy(i => i).ToList() as IList<int>)
            .ToList();
        Assert.Equal(expectedData, actualData);
    }

    public static IEnumerable<object[]> TestThreeSumDataOk =>
        new List<object[]>
        {
            new object[] 
            { 
                new[] { 1,-1,-1,0}, 
                new List<IList<int>>
                { 
                    new List<int> { -1, 0, 1 }
                }
            },
            new object[] 
            { 
                new[] { -1, 0, 1, 2, -1, -4 }, 
                new List<IList<int>>
                { 
                    new List<int> {-1, -1, 2},
                    new List<int> { -1, 0, 1 }
                }
            },
            new object[] 
            { 
                new[] { 0, 1, 1}, 
                new List<IList<int>>
                { 
                }
            },
            new object[] 
            { 
                new[] { -2,0,1,1,2}, 
                new List<IList<int>>
                { 
                    new List<int> {-2,0,2},
                    new List<int> {-2,1,1}
                }
            },
            new object[] 
            { 
                new[] { -1,0,1,2,-1,-4,-2,-3,3,0,4}, 
                new List<IList<int>>
                { 
                    new List<int> {-4,0,4},
                    new List<int> {-4,1,3},
                    new List<int> {-3,-1,4},
                    new List<int> {-3,0,3},
                    new List<int> {-3,1,2},
                    new List<int> {-2,-1,3},
                    new List<int> {-2,0,2},
                    new List<int> {-1,-1,2},
                    new List<int> {-1,0,1}
                }
            }
        };
    
    public static IEnumerable<object[]> TestThreeSumData500 =>
        new List<object[]>
        {
            new object[] 
            { 
                new[] { 1,-1,-1,0}, 
                new List<IList<int>>
                { 
                    new List<int> { -1, 0, 1 }
                }
            },
        };
    class ListEqualityComparer : IEqualityComparer<List<int>>
    {
        public bool Equals(List<int> x, List<int> y)
        {
            return x.OrderBy(i => i).SequenceEqual(y.OrderBy(i => i));
        }

        public int GetHashCode(List<int> obj)
        {
            int hash = 19;
            foreach (var item in obj.OrderBy(i => i))
            {
                hash = hash * 31 + item.GetHashCode();
            }
            return hash;
        }
    }
    public ThreeSum_15(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }
}
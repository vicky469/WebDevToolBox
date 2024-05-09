using System.Collections.Generic;
using System.Linq;

namespace LeetCode.array_and_string.Frequency_Counter_Pattern;

public class UniqueNumberofOccurrences_1207
{
    static bool UniqueOccurrences(int[] arr)
    {
        var dict = new Dictionary<int, int>();
        for (var i = 0; i < arr.Length; i++)
        {
            if (!dict.ContainsKey(arr[i]))
            {
                dict.Add(arr[i], 1);
            }
            else
            {
                dict[arr[i]]++;
            }
        }

        var set = new HashSet<int>(dict.Values);

        return set.Count() == dict.Count();
    }
    
    [Theory]
    [InlineData( new int[]{1,2,2,1,1,3}, true)]
    private void Test_OK(int[] arr, bool expectedResult)
    {
        var result = UniqueOccurrences(arr);
        Assert.Equal(expectedResult, result);
    }
}
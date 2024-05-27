namespace LeetCode.Array_and_String.Frequency_Counter_Pattern;

public class GroupAnagrams_49 : TestBase
{
    public GroupAnagrams_49(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }

    private static IList<IList<string>> Solution(string[] strs)
    {
        var hashTable = new Dictionary<string, List<string>>();
        foreach (var word in strs)
        {
            var arr = new int[26];
            foreach (var c in word) arr[c - 'a']++;

            var hash = string.Join(",", arr);
            if (hashTable.ContainsKey(hash))
                hashTable[hash].Add(word);
            else
                hashTable[hash] = new List<string> { word };
        }

        return new List<IList<string>>(hashTable.Values);

        #region answer

        // var hashTable = new Dictionary<string, List<string>>();
        // foreach (var word in strs)
        // {
        //     var hash = GenerateHash(word);
        //     if (hashTable.ContainsKey(hash))
        //     {
        //         hashTable[hash].Add(word); // Add word to existing group
        //     }
        //     else
        //     {
        //         hashTable[hash] = new List<string> { word }; // Create new group
        //     }
        // }
        // return new List<IList<string>>(hashTable.Values);

        #endregion
    }

    private static string GenerateHash(string word)
    {
        var charCount = new int[26];
        foreach (var c in word) charCount[c - 'a']++;

        var hash = string.Join(',', charCount);
        return hash;
    }


    [Theory]
    [MemberData(nameof(AnagramTestData))]
    public void Test_OK(string[] input, List<IList<string>> expectedResult)
    {
        var res = Solution(input);
        Assert.Equal(expectedResult, res);
    }

    public static IEnumerable<object[]> AnagramTestData()
    {
        yield return new object[]
        {
            new[] { "eat", "tea", "tan", "ate", "nat", "bat" },
            new List<IList<string>>
            {
                new List<string> { "eat", "tea", "ate" },
                new List<string> { "tan", "nat" },
                new List<string> { "bat" }
            }
        };

        yield return new object[]
        {
            new[] { "" },
            new List<IList<string>> { new List<string> { "" } }
        };

        yield return new object[]
        {
            new[] { "a" },
            new List<IList<string>> { new List<string> { "a" } }
        };
    }
}
namespace LeetCode.Array_and_String.HashTable;

public class GroupAnagrams_49: TestBase
{
    //Rules:
    //1. Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, 
    //2. All the characters in one string from string arr is used only once
    
    IList<IList<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string,List<string>>();
        foreach(var str in strs){
            // create key
            var cnt = new int[26];
            foreach(var c in str){
                cnt[c-'a']++;
            }
            var key = string.Join(',', cnt);
            if(map.ContainsKey(key)){
                map[key].Add(str);
            }else{
                var list = new List<string>();
                list.Add(str);
                map[key] = list;
            }

        }

        return map.Values.Select(x=> (IList<string>)x).ToList();
    }
    
    [Theory]
    [InlineData (new string[] { "eat", "tea", "tan", "ate", "nat", "bat" }, new string[] { "eat", "tea", "ate" }, new string[] { "tan", "nat" }, new string[] { "bat" })]
    public void TestMethod(string[] strs, params string[][] expected)
    {
        var result = GroupAnagrams(strs);
        Assert.Equal(expected.Length, result.Count);
        for (int i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expected[i].Length, result[i].Count);
            for (int j = 0; j < expected[i].Length; j++)
            {
                Assert.Contains(expected[i][j], result[i]);
            }
        }
    }

    public GroupAnagrams_49(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }
}
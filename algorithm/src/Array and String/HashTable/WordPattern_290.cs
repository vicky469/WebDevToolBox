namespace LeetCode.Array_and_String.HashTable;

public class WordPattern_290
{
    // Rules:
    // 1. The length of pattern and s is equal.
    // 2. Map each character in pattern to a word in s.
    bool WordPattern(string pattern, string s)
    {
        var words = s.Split(" ");
        if(pattern.Length != words.Length) return false;
        var map = new Dictionary<char, string>();
        for (var i = 0; i < pattern.Length; i++)
        {
            var key = pattern[i];
            // add to map when the key is not exist and the value is not exist
            if(!map.ContainsKey(key))
            {
                if (map.ContainsValue(words[i])) return false;
                map.Add(key,words[i]);
            }
            else if(map[key]!= words[i]) return false;
        }
        
        return true;
    }
    [Theory]
    [InlineData("abba", "dog cat cat dog", true)]
    [InlineData("abba", "dog cat cat fish", false)]
    [InlineData("aaaa", "dog cat cat dog", false)]
    [InlineData("abba", "dog dog dog dog", false)]
    public void Test(string pattern, string s, bool expected)
    {
        Assert.Equal(expected, WordPattern(pattern, s));
    }
}
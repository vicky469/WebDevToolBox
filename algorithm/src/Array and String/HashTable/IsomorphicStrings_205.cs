namespace LeetCode.Array_and_String.HashTable;

public class IsomorphicStrings_205
{
    // Isomorphic: similar structure or shape, the characters in s can be replaced to get t.
    // Rules:
    //        1. The length of s and t is equal.
    //        2. All occurrences of a character in s must be replaced with the same character in t.
    //        3. No two characters may map to the same character.
    //        4. A character can either map to itself or to another character.
    bool IsIsomorphic(string s, string t) {
        if(s.Length != t.Length) return false;
        var map = new Dictionary<char, char>();
        // map(char in s, char in t)
        // f:b
        // o:a
        // o
        var start = 0;
        while (start <= s.Length - 1)
        {
            if (!map.ContainsKey(s[start]))
            {
                var isExist = map.ContainsValue(t[start]);
                if (isExist) return false;
                map.Add(s[start],t[start]);
            }
            else
            {
                map.TryGetValue(s[start], out var c);
                if (c != t[start]) return false;
            }

            start++;
        }

        return true;
    }
    
    [Theory]
    [InlineData("egg", "add", true)]
    [InlineData("foo", "bar", false)]
    [InlineData("paper", "title", true)]
    [InlineData("badc", "baba", false)]
    public void Test(string s, string t, bool expected)
    {
        Assert.Equal(expected, IsIsomorphic(s, t));
    }
    
}
namespace LeetCode.Array_and_String.HashTable;

public class ValidAnagram_242
{
    // Rules:
    // 1. The length of s and t is equal.
    // 2. The characters in s have exactly the same count as the characters in t.
    bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        var map = new Dictionary<char,int>();
        foreach(var c in s){
            if(!map.ContainsKey(c)) map[c] = 1;
            else map[c] += 1;
        }

        foreach(var c in t){
            if(!map.ContainsKey(c)) return false;
            if(map[c] == 0) return false;
            map[c]-=1;
        }
        return true;
    }

    [Theory]
    [InlineData("anagram", "nagaram", true)]
    [InlineData(" ", " ", true)]
    [InlineData("ac", "a", false)]
    [InlineData("rat", "car", false)]
    private void Test_OK(string s1, string s2, bool expectedResult)
    {
        var result = IsAnagram(s1, s2);
        Assert.Equal(expectedResult, result);
    }
}
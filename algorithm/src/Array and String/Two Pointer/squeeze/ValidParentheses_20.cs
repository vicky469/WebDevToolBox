using LeetCode.Util;

namespace LeetCode.Array_and_String.Two_Pointer;

public class ValidParentheses_20
{
    // An input string is valid if:
    //     1. Open brackets must be closed by the same type of brackets.
    //     2. Open brackets must be closed in the correct order.
    //     3. Every close bracket has a corresponding open bracket of the same type.
    // Constraints: s consists of parentheses only '()[]{}'.
    public bool IsValid(string s)
    {
        if (s.Length % 2 != 0) return false;
        var parts = s.Select(c => c).ToArray();
        var partsMapping = new Dictionary<char, char>
        {
            { '(', ')' },
            { '[', ']' },
            { '{', '}' }
        };
        var start = 0;
        var end = 1;
        while (end < partsMapping.Count)
            if (partsMapping.ContainsKey(parts[end]))
            {
                start++;
                end++;
            }
            else
            {
                var startVal = partsMapping.TryGetValueByKey(parts[start]);
                if (startVal != parts[end]) return false;
                if (start == 0 && startVal == parts[end]) return true;
                start--;
                end++;
            }

        return true;
    }

    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("([)]", false)]
    [InlineData("{[]}", true)]
    public void IsValidTest(string input, bool expected)
    {
        var result = IsValid(input);
        Assert.Equal(expected, result);
    }
}
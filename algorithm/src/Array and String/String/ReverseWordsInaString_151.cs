using System.Text;

namespace LeetCode.Array_and_String.String;

public class ReverseWordsInaString_151
{
    string ReverseWords(string s) {
        s = s.Trim();
        var words = s.Split(' ');
        var res = new StringBuilder();
        for (var i = words.Length - 1; i >= 0; i--)
        {
            // skip empty string in case of multiple spaces between words
            if (words[i] != "")
            {
                // "blue " => "blue is " => "blue is sky " => "blue is sky the"
                res.Append(words[i]);
                if (i != 0)
                {
                    res.Append(" ");
                }
            }
            
        }

        return words.Length == 0 ? "" : res.ToString();
    }
}
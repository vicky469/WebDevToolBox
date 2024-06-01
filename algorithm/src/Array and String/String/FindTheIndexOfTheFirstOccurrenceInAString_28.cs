namespace LeetCode.Array_and_String.Two_Pointer;

public class FindTheIndexOfTheFirstOccurrenceInAString_28
{
    int StrStr(string haystack, string needle) {
        var startIndex = haystack.IndexOf(needle);
        return startIndex;
    }
}
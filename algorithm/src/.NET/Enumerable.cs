namespace LeetCode.Net;

public static class Enumerable
{
    public static IEnumerable<T> MyIntersect<T>(this IEnumerable<T> first, IEnumerable<T> second)
    {
        var hashSet = new HashSet<T>(second);

        foreach (T item in first)
        {
            if (hashSet.Contains(item))
            {
                yield return item;
                hashSet.Remove(item);
            }
        }
    }
}
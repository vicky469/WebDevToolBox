namespace LeetCode.Util;

public static class DictionaryExtensions
{
    public static TKey? TryGetKeyByValue<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TValue value)
    {
        foreach (var pair in dictionary)
        {
            if (EqualityComparer<TValue>.Default.Equals(pair.Value, value))
            {
                return pair.Key;
            }
        }

        return default(TKey);
    }
    public static TValue? TryGetValueByKey<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key)
    {
        if (dictionary.TryGetValue(key, out TValue value))
        {
            return value;
        }
        else
        {
            return default(TValue);
        }
    }
    public static bool SafeContainsKey<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key)
    {
        try
        {
            return dictionary.ContainsKey(key);
        }
        catch
        {
            return false;
        }
    }
}
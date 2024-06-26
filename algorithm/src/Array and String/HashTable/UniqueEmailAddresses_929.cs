namespace LeetCode.Array_and_String.HashTable;

public class UniqueEmailAddresses_929
{
    int NumUniqueEmails(string[] emails)
    {
        if (emails.Length == 0) return 0;
        // key: localName     => becasue we want to find unique localName, so using localName as key
        // value: domainName
        var dic = new Dictionary<string, List<string>>();
        foreach (var email in emails)
        {
            var parts = email.Split('@');
            var localName = parts[0];
            var domainName = parts[1];
            // clean localName
            localName = localName.Replace(".", "");
            var localNameParts = localName.Split('+');
            localName = localNameParts[0];
            
            if (dic.ContainsKey(localName) && dic[localName].Contains(domainName)) continue;
            // Add to dictionary
            
            if (!dic.ContainsKey(localName))
            {
                dic[localName] = new List<string> { domainName };
            }
            else
            {
                var value = dic[localName];
                value.Add(domainName);
                dic[localName] = value;
            }
        }
        var totalCount = 0;
        foreach (var list in dic.Values)
        {
            totalCount += list.Count;
        }
        return totalCount;
    }

    [Theory]
    [MemberData(nameof(NumUniqueEmailsTestData))]
    public void TestForNumUniqueEmails(string[] emails, int expected)
    {
        var result = NumUniqueEmails(emails);
        Assert.Equal(expected, result);
    }

    public static IEnumerable<object[]> NumUniqueEmailsTestData
    {
        get => new[]
        {
            new object[]
            {
                new string[]
                {
                    "test.email+alex@leetcode.com",
                    "test.e.mail+bob.cathy@leetcode.com",
                    "testemail+david@lee.tcode.com"
                },
                2
            },
            // new object[]
            // {
            //     new string[]
            //     {
            //         "a@leetcode.com",
            //         "b@leetcode.com",
            //         "c@leetcode.com"
            //     },
            //     3
            // }
        };
    }

}
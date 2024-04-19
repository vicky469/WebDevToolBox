using LeetCode.Util;

namespace LeetCode;

public class TestBase
{
    protected readonly ITestOutputHelper TestOutputHelper;

    public TestBase(ITestOutputHelper testOutputHelper)
    {
        TestOutputHelper = testOutputHelper;
        Extensions.UseTestOutputHelper(testOutputHelper);
    }
}
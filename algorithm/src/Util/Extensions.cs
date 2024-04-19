namespace LeetCode.Util;

public static class Extensions
{
    private static ITestOutputHelper _testOutputHelper;

    public static void UseTestOutputHelper(this ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
        Console.SetOut(new TestOutputHelperStreamWriter(testOutputHelper));
    }

    private class TestOutputHelperStreamWriter : System.IO.TextWriter
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public TestOutputHelperStreamWriter(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        public override void WriteLine(string value)
        {
            _testOutputHelper.WriteLine(value);
        }

        public override System.Text.Encoding Encoding => System.Text.Encoding.UTF8;
    }
}
namespace LeetCode.Tree.Recursion___DFS;

public class MaximumDepthOfBinaryTree_104: TestBase
{
    public int MaxDepth(TreeNode? root)
    {
        if (root == null) {
            return 0;
        }
        
        TestOutputHelper.WriteLine(root?.left != null ? $"Left: { root.left.val.ToString() }" : "Left is null");
        var leftDepth = MaxDepth(root.left);

        #region print
        TestOutputHelper.WriteLine($"left depth: {leftDepth}");
        TestOutputHelper.WriteLine("============   left is done    ============");
        #endregion
        TestOutputHelper.WriteLine(root?.right != null ? $"Right: { root.right.val.ToString() }" : "Right is null");
        var rightDepth = MaxDepth(root.right);

        #region print
        TestOutputHelper.WriteLine($"right depth: {rightDepth}");
        TestOutputHelper.WriteLine("============   right is done   ============");
        #endregion
        return Math.Max(leftDepth, rightDepth) + 1;
    }
    
    [Theory]
    [InlineData(1)]
    public void Test_OK(int testCaseId)
    {
        int?[] nums = null;
        int expectedResult = 0;

        switch (testCaseId)
        {
            case 1:
                nums = new int?[]{3,9,20,null,null,15,7};
                expectedResult = 3;
                break;
            // Add more cases as needed
        }

        var root = TreeNode.BuildTree(nums);
        var result = MaxDepth(root);
        Assert.Equal(expectedResult, result);
    }

    public MaximumDepthOfBinaryTree_104(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }
}
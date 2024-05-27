using LeetCode.Data_Structure;

namespace LeetCode.Tree;
// https://leetcode.com/problems/binary-tree-preorder-traversal/description/
public class PreOrder_144: TestBase
{
    public List<int> PreOrderTraversal(TreeNode? node)
    {
        var list = new List<int>();
        PreOrder(node, list);
        return list;
    }

    void PreOrder(TreeNode? node, List<int> list)
    {
        if (node == null) return;
        // Add root to the list
        list.Add(node.val);

        // Then recur on left subtree
        PreOrder(node.left, list);

        // Now recur on right subtree
        PreOrder(node.right, list);
    }

    [Theory]
    [InlineData(1)]
    public void Test_OK(int testCaseId)
    {
        int?[] nums = null;
        int[] expectedResult = null;

        switch (testCaseId)
        {
            case 1:
                nums = new int?[]{1,2,3,4,5,null,6};
                    //        1
                    //    /       \
                    //   2         3 
                    // /   \        \
                    // 4    5        6 
                expectedResult = new[] { 1,2,4,5,3,6};
                break;
        }

        var root = TreeNode.BuildTree(nums);
        var res = PreOrderTraversal(root);
        Assert.Equal(expectedResult,res);
    }

    public PreOrder_144(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }
}
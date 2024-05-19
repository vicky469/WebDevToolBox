namespace LeetCode.Tree;
// https://leetcode.com/problems/binary-tree-postorder-traversal/description/
public class PostOrder_145
{
    public List<int> PostOrderTraversal(TreeNode? node)
    {
        var list = new List<int>();
        PostOrder(node, list);
        return list;
    }

    void PostOrder(TreeNode? node, List<int> list)
    {
        if (node == null) return;
        PostOrder(node.left, list);
        PostOrder(node.right, list);
        list.Add(node.val);
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
                expectedResult = new[] {4, 5, 2, 6, 3, 1};
                break;
        }

        var root = TreeNode.BuildTree(nums);
        var res = PostOrderTraversal(root);
        Assert.Equal( expectedResult,res);
    }
    
}
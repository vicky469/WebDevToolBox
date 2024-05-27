// https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/description/

using LeetCode.Data_Structure;

namespace LeetCode.Tree.Recursion___DFS;

//preorder and inorder consist of unique values.
public class ConstructBinaryTreeFromPreorderAndInorderTraversal_105: TestBase
{
    TreeNode? BuildTree(int[] preorder, int[] inorder)
    {
        if(preorder.Length == 0 || inorder.Length == 0) return null;
        var rootVal = preorder[0];
        var root = new TreeNode(rootVal);
        var mid = Array.IndexOf(inorder, rootVal);
        root.left = BuildTree(preorder.Skip(1).Take(mid).ToArray(), inorder.Take(mid).ToArray());
        root.right = BuildTree(preorder.Skip(mid + 1).ToArray(), inorder.Skip(mid + 1).ToArray());
        return root;
    }
    
    TreeNode? BuildTreeWithLogs(int[] preorder, int[] inorder)
    {
        if(preorder.Length == 0 || inorder.Length == 0) return null;
        var rootVal = preorder[0];
        TestOutputHelper.WriteLine($"INPUT: preorder: {string.Join(",",preorder)}; inorder: {string.Join(",",inorder)}");
        TestOutputHelper.WriteLine($"rootVal: {rootVal}");
        var root = new TreeNode(rootVal);
        var mid = Array.IndexOf(inorder, rootVal);
        TestOutputHelper.WriteLine($"mid: {mid}");
        
        root.left = BuildTree(preorder.Skip(1).Take(mid).ToArray(), inorder.Take(mid).ToArray());
        TestOutputHelper.WriteLine($"Finished root.left: {root?.left?.Size}");
        
        root.right = BuildTree(preorder.Skip(mid + 1).ToArray(), inorder.Skip(mid + 1).ToArray());
        TestOutputHelper.WriteLine($"Finished root.right: {root?.right?.Size}");
        return root;
    }

    [Theory]
    [InlineData(1)]
    public void Test_OK(int testCaseId)
    {
        int[] preorder = null;
        int[] inorder = null;
        int?[] expectedResult = null;

        switch (testCaseId)
        {
            case 1:
                preorder = new int[]{3,9,20,15,7}; // preorder: root, left, right
                inorder = new int[]{9,3,15,20,7};  // inorder: left, root, right
                //        3
                //    /       \
                //   9         20 
                //            /   \
                //           15    7 
                expectedResult = new int?[] {3,9,20,null,null,15,7};
                break;
        }
        var expected = TreeNode.BuildTree(expectedResult);
        var res = BuildTree(preorder,inorder);
        Assert.Equal( expected,res);
    }

    public ConstructBinaryTreeFromPreorderAndInorderTraversal_105(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }
}


using LeetCode.Data_Structure;

namespace LeetCode.Tree.Recursion___DFS;

public class ConstructBinaryTreeFromInorderAndPostorderTraversal_106
{
    TreeNode? BuildTree(int[] inorder, int[] postorder) {
        if(inorder.Length == 0 || postorder.Length == 0) return null;
        var mid = postorder[postorder.Length-1];
        var tree = new TreeNode(mid);
        var midIndex = Array.IndexOf(inorder,mid); //1
        
        tree.left = BuildTree(inorder.Take(midIndex).ToArray(),
            postorder.Take(midIndex).ToArray());

        tree.right = BuildTree(inorder.Skip(midIndex+1).ToArray(),
            postorder.Skip(midIndex).Take(postorder.Length - 1 - midIndex).ToArray());
        return tree;
    }
    
    [Theory]
    [InlineData(1)]
    public void Test_OK(int testCaseId)
    {
        int[] postorder = null;
        int[] inorder = null;
        int?[] expectedResult = null;

        switch (testCaseId)
        {
            case 1:
                inorder = new int[]{9,3,15,20,7};  // inorder: left, root, right
                postorder = new int[]{9,15,7,20,3}; // postorder: left, right, root
                //        3
                //    /       \
                //   9         20 
                //            /   \
                //           15    7 
                expectedResult = new int?[] {3,9,20,null,null,15,7};
                break;
        }
        var expected = TreeNode.BuildTree(expectedResult);
        var res = BuildTree(postorder,inorder);
        Assert.Equal( expected,res);
    }
}
namespace LeetCode.Tree.Recursion___DFS;

public class InvertBinaryTree_226
{
    TreeNode InvertTree(TreeNode root) {
        if(root == null) return null;
        var tmp  = root.left;
        root.left = InvertTree(root.right);
        root.right = InvertTree(tmp);
        return root;
    }
}
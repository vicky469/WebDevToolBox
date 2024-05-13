namespace LeetCode.Stack;

public class MaximumDepthOfBinaryTree_104
{
    public int MaxDepth(TreeNode root)
    {
        var maxDepth = 0;
        if (root == null) return 0;
        var stack  = new System.Collections.Generic.Stack<(TreeNode node, int depth)>(); // node and its depth
        stack.Push((root,1));
        while (stack.Count > 0)
        {
            // pop the node from the top of the stack
            var (node, depth) = stack.Pop();
            // get the max depth of the current node
            // When a node is popped from the stack, its depth is known and can be compared with the current maxDepth.
            maxDepth = Math.Max(maxDepth, depth);
            if (node.left != null)
            {
                stack.Push((node.left, depth + 1));
            }
            if (node.right != null)
            {
                stack.Push((node.right, depth + 1));
            }
        }
        return maxDepth;
    }
}
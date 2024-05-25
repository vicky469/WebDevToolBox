// https://leetcode.com/problems/symmetric-tree/description/?envType=study-plan-v2&envId=top-interview-150

namespace LeetCode.Tree;

public class SymmetricTree_101
{
    public bool IsSymmetric_BFS(TreeNode? root)
    {
        var queue = new Queue<TreeNode?>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            var size = queue.Count;
            var level = new List<int?>();
            for (var i = 0; i < size; i++)
            {
                var node = queue.Dequeue();
                if (node != null)
                {
                    queue.Enqueue(node.left); 
                    queue.Enqueue(node.right);
                    level.Add(node.left?.val); 
                    level.Add(node.right?.val);   
                }
            }
            var r = level.Count - 1;
            for (var l = 0; l < level.Count / 2; l++)
            {
                if (level[l] != level[r--]) return false;
            }
        }
        return true;
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public void Test_OK(int testCaseId)
    {
        int?[] nums = null;
        bool expectedResult = false;

        switch (testCaseId)
        {
            case 1:
                nums = new int?[] { 1, 2, 2, null, 3, null, 3 };
                expectedResult = false;
                break;
            case 2:
                nums = new int?[] { 1, 2, 2, 3, 4, 4, 3 };
                expectedResult = true;
                break;
        }

        var root = TreeNode.BuildTree(nums);
        var result = IsSymmetric_BFS(root);
        Assert.Equal(expectedResult, result);
    }
}
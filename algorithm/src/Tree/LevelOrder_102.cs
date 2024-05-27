using LeetCode.Data_Structure;

namespace LeetCode.Tree;
// https://leetcode.com/problems/binary-tree-level-order-traversal/description/
public class LevelOrder_102
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        var queue = new Queue<TreeNode>();
        var res = new List<IList<int>>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            var size = queue.Count;
            var level = new List<int>();
            for (var i = 0; i < size; i++)
            {
                var node = queue.Dequeue();
                if (node != null)
                {
                    level.Add(node.val);
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
            }
            if(level.Count > 0)res.Add(level);
            
        }
        return res;
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public void Test_OK(int testCaseId)
    {
        int?[] nums = null;
        List<IList<int>> expectedResult = null;

        switch (testCaseId)
        {
            case 1:
                nums = new int?[]{1,2,3,4,5,null,6};
                //        1
                //    /       \
                //   2         3 
                // /   \        \
                // 4    5        6 
                expectedResult = new List<IList<int>>
                {
                    new List<int> {1},
                    new List<int> {2, 3},
                    new List<int> {4, 5, 6}
                };
                break;
            case 2:
                nums = new int?[] {  };
                //        1
                //    /       \
                //   2         3 
                // /   \        \
                // 4    5        6 
                expectedResult = new List<IList<int>>
                {
                };
                break;
        }

        var root = TreeNode.BuildTree(nums);
        var res = LevelOrder(root);
        Assert.Equal( expectedResult,res);
    }
}
namespace LeetCode.Tree;

// either zero or two children for each node
public class FullBinaryTree
{ 
  //      1                       1
  //    /    \                  /    \            
  //   2      3                2      3
  //  /  \                    /   
  // 4    5    (Y)           4          (N)
    public bool IsFullBinaryTree(TreeNode? root)
    {
       if(root==null) return true;
       var queue = new Queue<TreeNode?>();
       queue.Enqueue(root);
       while (queue.Count > 0)
       {
           var node = queue.Dequeue();
           if(node?.left == null && node?.right == null) continue;
           if((node?.left == null && node?.right != null)
              || (node?.left != null && node?.right == null)) 
               return false;
           queue.Enqueue(node.left);
           queue.Enqueue(node.right);
       }

       return true;
    }
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public void Test_OK(int testCaseId)
    {
        int?[] nums = null;
        bool expectedResult = default;

        switch (testCaseId)
        {
            case 1:
                nums = new int?[]{1,2,3,4,5};
                expectedResult = true;
                break;
            case 2:
                nums = new int?[] { 1,2,3,4 };
                expectedResult = false;
                break;
        }

        var root = TreeNode.BuildTree(nums);
        var result = IsFullBinaryTree(root);
        Assert.Equal(expectedResult, result);
    }
}
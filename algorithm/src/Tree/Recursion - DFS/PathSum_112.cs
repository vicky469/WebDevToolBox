using LeetCode.Data_Structure;

namespace LeetCode.Tree.Recursion___DFS;

public class PathSum_112: TestBase
{
    // ASK: check if the tree has a root-to-leaf path 
    bool HasPathSum(TreeNode root, int targetSum) {
        var sumList = new List<int>();
        Dfs(root, 0);
        void Dfs(TreeNode node, int sum) {
            if (node == null) return;
            
            sum += node.val;
            if (node.left == null && node.right == null) {
                sumList.Add(sum);
                return;
            }
            Dfs(node.left, sum);
            Dfs(node.right, sum);
        }
        return sumList.Contains(targetSum);
    }
    
    bool HasPathSum_Print(TreeNode root, int targetSum) {
        var sumList = new List<int>();
        TestOutputHelper.WriteLine($"INPUT: root.val: {root.val}, targetSum: {targetSum}");
        Dfs_Print(root, 0, sumList);
        
        return sumList.Contains(targetSum);
    }
    
    void Dfs_Print(TreeNode node, int sum, List<int> sumList) {
        if (node == null) return;
        TestOutputHelper.WriteLine($"node.val: {node.val}, sum: {sum}");
        sum += node.val;
        TestOutputHelper.WriteLine($"sum: {sum}");
        if (node.left == null && node.right == null) {
            sumList.Add(sum); 
            TestOutputHelper.WriteLine($"sumList: {string.Join(",", sumList)}");
            return;
        }
        TestOutputHelper.WriteLine($"dfs node.left: {node.left?.val}, node.right: {node.right?.val}");
        Dfs_Print(node.left, sum, sumList);
        TestOutputHelper.WriteLine($"dfs node.right: {node.right?.val}");
        Dfs_Print(node.right, sum,sumList);
    }
    
    
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public void Test_OK(int testCaseId)
    {
        // Arrange
        int?[] nums = null;
        var targetSum = 0;
        var expectedResult = false;
        switch (testCaseId)
        {
            case 1:
                nums = new int?[]{1,2,3};
                targetSum = 5;
                expectedResult = false;
                break;
            case 2:
                nums = new int?[]{5,4,8,11,null,13,4,7,2,null,null,null,1};
                targetSum = 22;
                expectedResult = true;
                break;
        }
        
        var root = TreeNode.BuildTree(nums);
        
        // Act
        var res = HasPathSum_Print(root, targetSum);
        
        // Assert
        Assert.Equal(expectedResult, res);
    }

    public PathSum_112(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }
}
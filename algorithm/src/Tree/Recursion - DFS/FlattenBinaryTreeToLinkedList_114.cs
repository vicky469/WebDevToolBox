using LeetCode.Data_Structure;

namespace LeetCode.Tree.Recursion___DFS;

public class FlattenBinaryTreeToLinkedList_114: TestBase
{
    // Time complexity: O(n)
    // Space complexity: O(h) the height of the tree
    
    void Flatten(TreeNode root)
    {
        if (root == null)return;
        
        Flatten(root.left);
        Flatten(root.right);

        // Move left child to the right
        if (root.left != null)
        {
            // Store the original right child
            var temp = root.right;
            root.right = root.left;
            root.left = null;
            
            // Move to the end of the new right child and connect it to the original right child
            while (root.right != null)
            {
                root = root.right;
            }
            root.right = temp;
        }
    }
    
    void Flatten_Print(TreeNode root)
    {
        if (root == null)
        {
            TestOutputHelper.WriteLine("return");
            return;
        }
        TestOutputHelper.WriteLine($"==========   Processing root: {root.val}    ==========");
        // Flatten left and right subtrees
        TestOutputHelper.WriteLine($"start to flatten {root?.val}.left = {root.left?.val}");
        Flatten_Print(root.left);
        TestOutputHelper.WriteLine($"start to flatten {root?.val}.right = {root.right?.val}");
        Flatten_Print(root.right);

        // Move left child to the right
        if (root.left != null)
        {
            // Store the original right child
            TestOutputHelper.WriteLine("store `root.right` as temp: " + root.right?.val);
            var temp = root.right;
            TestOutputHelper.WriteLine("root.right = root.left: " + root.left?.val);
            root.right = root.left;
            root.left = null;
            
            // Move to the end of the new right child and connect it to the original right child
            while (root.right != null)
            {
                root = root.right;
            }
            root.right = temp;
            TestOutputHelper.WriteLine("root.right = temp: " + temp?.val);
        }
    }
    
    [Theory]
    [InlineData(1)]
    public void Test_OK(int testCaseId)
    {
        // Arrange
        int?[] nums = null;
        int?[] expected = null;
        switch (testCaseId)
        {
            case 1:
                nums = new int?[]{1,2,5,3,4,null,6};
                expected = new int?[]{1,null,2,null,3,null,4,null,5,null,6};
                break;
        }
        
        var root = TreeNode.BuildTree(nums);
        var expectedResult = TreeNode.BuildTree(expected);
        
        // Act
        Flatten_Print(root);
        
        // Assert
        Assert.Equal(expectedResult, root);
    }
    
    
    public FlattenBinaryTreeToLinkedList_114(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }

}
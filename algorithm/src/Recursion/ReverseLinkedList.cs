using LeetCode.Data_Structure;
using static LeetCode.Data_Structure.LinkedList;

namespace LeetCode.Recursion;
public class ReverseLinkedList:TestBase
{
    static Node ReverselistRecursion(Node head)
    {
        if (head == null || head.Next == null)
            return head;
 
        // Reverse the rest list and put
        // the first element at the end
        Node rest = ReverselistRecursion(head.Next);
        head.Next.Next = head;
 
        // Tricky step --
        // see the diagram
        head.Next = null;
 
        // Fix the head pointer
        return rest;
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 3, 2, 1 })]
    [InlineData(new[] { -4, -6, -10 }, new[] { -10, -6, -4 })]
    private void Test_OK(int[] input, int[] expectedOutput)
    {
        // Arrange
        var linkedList = new LinkedList();
        foreach (var value in input)
        {
            linkedList.AddNode(new Node(value));
        }

        //Act
        var reversedHead = ReverselistRecursion(linkedList.Head);

        var actualOutput = new List<int>();
        var temp = reversedHead;
        while (temp != null)
        {
            actualOutput.Add(temp.Data);
            temp = temp.Next;
        }
        
        //Assert
        Assert.Equal(expectedOutput, actualOutput);
    }
    
    public ReverseLinkedList(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
        
    }
}
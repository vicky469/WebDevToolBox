namespace LeetCode.Data_Structure;

public class LinkedList
{
    public Node Head;
 
    public class Node {
        public int Data;
        public Node Next;
 
        public Node(int d)
        {
            Data = d;
            Next = null;
        }
    }
    public void AddNode(Node node)
    {
        if (Head == null)
            Head = node;
        else {
            Node temp = Head;
            while (temp.Next != null) {
                temp = temp.Next;
            }
            temp.Next = node;
        }
    }
    
    public void ReverseList()
    {
        Node prev = null, current = Head, next = null;
        while (current != null) {
            next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }
        Head = prev;
    }
    
    public Node Reverse(Node head)
    {
        if (head == null || head.Next == null)
            return head;
        
        Node rest = Reverse(head.Next);
        head.Next.Next = head;
        
        head.Next = null;
        
        return rest;
    }
}
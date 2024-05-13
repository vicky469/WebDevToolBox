namespace LeetCode.Data_Structure;

public class LinkedList<T>
{
    public Node<T> Head;
 
    public class Node<T> {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
 
        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }
    public void AddNode(Node<T> node)
    {
        if (Head == null)
            Head = node;
        else {
            Node<T> temp = Head;
            while (temp.Next != null) {
                temp = temp.Next;
            }
            temp.Next = node;
        }
    }
    
    public void ReverseList()
    {
        Node<T> prev = null, current = Head, next = null;
        while (current != null) {
            next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }
        Head = prev;
    }
    
    public Node<T> Reverse(Node<T> head)
    {
        if (head == null || head.Next == null)
            return head;
        
        Node<T> rest = Reverse(head.Next);
        head.Next.Next = head;
        
        head.Next = null;
        
        return rest;
    }
}
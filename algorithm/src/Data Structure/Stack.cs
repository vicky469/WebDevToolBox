namespace LeetCode.Data_Structure;

public class Stack<T>
{
    public Data_Structure.LinkedList<T>.Node<T> Top;

    public Stack()
    {
        Top = null;
    }

    public void Push(T item)
    {
        var node = new Data_Structure.LinkedList<T>.Node<T>(item)
        {
            Next = Top
        };
        Top = node;
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty");
        }

        Top = Top.Next; // remove the top node
        T item = Top.Data; // save the top node data to return
        return item;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty");
        }

        return Top.Data;
    }

    public bool IsEmpty() => Top == null;

}
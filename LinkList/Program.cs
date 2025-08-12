
class Node<T>
{
    public T Value { get; set; }
    public Node<T> Next {  get; set; }
    public Node(T value)
    {
        Value = value;
        Next = null;
    }   
}

class MyLinkedList<T>
{
    private Node<T> head;
    public void AddFirst(T value)
    {
        var newNode = new Node<T>(value);
        newNode.Next = head;
        head = newNode;

    }

    public void AddLast(T value)
    {
        var newNode = new Node<T>(value);
        if (head == null)
        {
            head = newNode;
            return;
        }

        var current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }

        current.Next = newNode;

    }

    public void Add(int position, T value)
    {
        var newNode = new Node<T>(value);
        if (head == null)
        {
            head = newNode;
            return;
        }

        var current = head;
        int i = 0;
        while (i < position - 1 && current.Next != null)
        {
            current = current.Next;
            i++;
        }

        newNode.Next = current.Next;
        current.Next = newNode;
    }

    public void pop_front()
    {
        if (head != null)
        {
            head = head.Next;
        }
    }

    public void Erase(int position)
    {
        if (head == null)
            return;

        if (position == 0)
        {
            pop_front();
            return;
        }

        var current = head;
        int index = 0;

        
        while (current != null && index < position - 1)
        {
            current = current.Next;
            index++;
        }

        if (current == null || current.Next == null)
            return;  

        current.Next = current.Next.Next;
    }

    public void PrintList()
    {
        var current = head;
        while (current != null)
        {
            Console.Write($"{current.Value} -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }

    public int Count
    {
        get
        {
            int count = 0;
            var current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }
    }

    public void Clear()
    {
        head = null;
    }

}
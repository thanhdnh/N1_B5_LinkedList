public class Node
{
    public object element;
    public Node link;
    public Node() { element = null; link = null; }
    public Node(object element) { this.element = element; link = null; }
}
public class LinkedList
{
    public Node header;
    public LinkedList() { header = new Node("header"); }
    public Node FindNode(object input)
    {
        Node current = header;
        while (current.element != input)
            current = current.link;
        return current;
    }
    public void Insert(object newelement, object afterelement)
    {
        Node newnode = new Node(newelement);
        Node current = FindNode(afterelement);
        newnode.link = current.link;
        current.link = newnode;
    }
    public Node FindPrevNode(object input)
    {
        Node current = header;
        while (current.link.element != input)
            current = current.link;
        return current;
    }
    public void Remove(object removedelement)
    {
        Node current = FindPrevNode(removedelement);
        current.link = current.link.link;
    }
    public void Swap(object nodeA, object nodeB)
    {
        object prevA = FindPrevNode(nodeA).element;
        object prevB = FindPrevNode(nodeB).element;
        Remove(nodeB);
        Insert(nodeA, prevB);
        Remove(nodeA);
        Insert(nodeB, prevA);
    }
    public void Sort(){
        
    }
}
public class Node2
{
    public object element;
    public Node2 flink, blink;
    public Node2(){
        element = null;
        flink = blink = null;
    }
    public Node2(object element){
        this.element = element;
        flink = blink = null;
    }
}
public class DoubleLinkedList{
    public Node2 header;
    public DoubleLinkedList()
    {
        header = new Node2("header");
    }
    private Node2 Find(object element)
    {
        Node2 current = new Node2();
        current = header;
        while (current.element != element)
            current = current.flink;
        return current;
    }
    private Node2 FindPrevNode(object element)
    {
        Node2 current = header;
        while (current.flink!=null && current.flink.element != element)
            current = current.flink;
        return current;
    }
    public void Insert(object newelement, object afterelement)
    {
        Node2 current = Find(afterelement);
        Node2 newnode = new Node2(newelement);
        newnode.flink = current.flink;
        newnode.blink = current;
        current.flink = newnode;
    }
    public void Remove(object element)
    {
        Node2 current = Find(element);
        if (current.flink != null)
        {
            current.blink.flink = current.flink;
            current.flink.blink = current.blink;
            current.flink = null;
            current.blink = null;
        }
    }
    public void Swap(object nodeA, object nodeB)
    {
        object prevA = FindPrevNode(nodeA).element;
        object prevB = FindPrevNode(nodeB).element;
        Remove(nodeB);
        Insert(nodeA, prevB);
        Remove(nodeA);
        Insert(nodeB, prevA);
    }
    public void Sort(){

    }
}

public class Program
{
    public static void Main(string[] args)
    {
        /*LinkedList linkedlist = new LinkedList();
        linkedlist.Insert("bread", "header");
        linkedlist.Insert("milk", "bread");
        linkedlist.Insert("bacon", "milk");
        ;
        //linkedlist.Remove("milk");
        ;
        linkedlist.Insert("egg", "bacon");
        linkedlist.Insert("cheese", "egg");
        linkedlist.Swap("milk", "egg");
        ;*/
        DoubleLinkedList dlinkedlist = new DoubleLinkedList();
        dlinkedlist.Insert("Raymond", "header");
        dlinkedlist.Insert("Fred", "Raymond");
        dlinkedlist.Insert("Taddy", "Fred");
        dlinkedlist.Insert("Marry", "Taddy");
        ;
        //dlinkedlist.Remove("Fred");
        dlinkedlist.Swap("Raymond", "Taddy");
    }
}
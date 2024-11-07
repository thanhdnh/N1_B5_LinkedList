public class Node{
    public object element;
    public Node link;
    public Node(){element = null; link = null;}
    public Node(object element){this.element = element;link = null;}
}
public class LinkedList{
    public Node header;
    public LinkedList(){header = new Node("header");}
    public Node FindNode(object input){
        Node current = header;
        while(current.element != input)
            current = current.link;
        return current;
    }
    public void Insert(object newelement, object afterelement){
        Node newnode = new Node(newelement);
        Node current = FindNode(afterelement);
        newnode.link = current.link;
        current.link = newnode;
    }
    public Node FindPrevNode(object input){
        Node current = header;
        while(current.link.element != input)
            current = current.link;
        return current;
    }
    public void Remove(object removedelement){
        Node current = FindPrevNode(removedelement);
        current.link = current.link.link;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        LinkedList linkedlist = new LinkedList();
        linkedlist.Insert("bread", "header");
        linkedlist.Insert("milk", "bread");
        linkedlist.Insert("bacon", "milk");
        ;
        linkedlist.Remove("milk");
        ;
    }
}
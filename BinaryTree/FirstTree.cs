
public class FirstTree
{
    public static void DrivingCode()
    {
        //      15
        //  10       30
        //5    12  20    40
        // Node root = new Node(15);
        // root.left = new Node(10);
        // root.right = new Node(30);
        // root.left.left = new Node(5);
        // root.left.right = new Node(12);
        // root.right.left = new Node(20);
        // root.right.right = new Node(40);

        Node root = new Node(2);
        root.left = new Node(4);
        root.right = new Node(1);
        root.left.left = new Node(7);
        //root.left.right = new Node(12);
        root.right.left = new Node(8);
        root.right.right = new Node(3);


        //PreOrder   Node Left Right
        Console.WriteLine();
        Console.WriteLine("PreOrder");
        PreOrder(root);
        //InOrder    Left Node Right
        Console.WriteLine();
        Console.WriteLine("InOrder");
        InOrder(root);
        //PostOrder  Left Right Node
        Console.WriteLine();
        Console.WriteLine("PostOrder");
        PostOrder(root);

        Console.WriteLine();
    }

    static void PreOrder(Node root)
    {
        if(root == null)
        {
            return;
        }

        Console.Write(" " + root.data);
        PreOrder(root.left);
        PreOrder(root.right);
    }

    static void InOrder(Node root)
    {
        if(root == null)
        {
            return;
        }
        
        InOrder(root.left);
        Console.Write(" " + root.data);
        InOrder(root.right);
    }

    static void PostOrder(Node root)
    {
        if(root == null)
        {
            return;
        }
        
        PostOrder(root.left);
        PostOrder(root.right);
        Console.Write(" " + root.data);
    }
}
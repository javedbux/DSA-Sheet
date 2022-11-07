public class TreeHeight
{
    public static void DrivingCode()
    {
        Node root = new Node(2);
        root.left = new Node(4);
        root.right = new Node(1);
        root.left.left = new Node(7);
        //root.left.right = new Node(12);
        root.right.left = new Node(8);
        root.right.right = new Node(3);


        //PreOrder   Node Left Right
        Console.WriteLine();
        Console.WriteLine("Height");
        int height = HeigthOfTree(root);
        Console.WriteLine(height);

        Console.WriteLine();
        Console.WriteLine("Size of tree");
        int Size = SizeOfTree(root);
        Console.WriteLine(Size);


        Console.WriteLine();
        Console.WriteLine("max number in tree");
        int maxNo = MaxNoInTree(root);
        Console.WriteLine(maxNo);
    }

    static int MaxNoInTree(Node root)
    {
        if(root == null)
            return 0;
        
        return Math.Max(root.data, Math.Max(MaxNoInTree(root.left), MaxNoInTree(root.right)));
    }

    static int SizeOfTree(Node root)
    {
        if(root == null)
            return 0;

        return SizeOfTree(root.left) + SizeOfTree(root.right) +1;
        
    }

    static int HeigthOfTree(Node root)
    {
        if(root == null)
        {
            return 0;
        }

        return Math.Max(HeigthOfTree(root.left), HeigthOfTree(root.right)) + 1;

    }
}
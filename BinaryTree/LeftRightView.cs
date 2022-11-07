
//using System.Collections;

public class LeftRightView
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
        Console.WriteLine("left View");
        LeftViewOfTree(root);
        //Console.WriteLine(left);


        Console.WriteLine("Left View 2");
        var list = LeftView(root);
        foreach (var item in list)
        {
            Console.Write(" " + item);
        }
    }

    static void LeftViewOfTree(Node root)
    {
        //List<Node> list = new List<Node>();

        LeftViewOfTreeUtils(root, 0);

        //InOrder(root);
        //Console.WriteLine();

        
    }

    static List<int> LeftView(Node root)
    {   
        var list = new List<int>();
        LeftViewList(root, 0, list);

        return list;

    }
    static void LeftViewList(Node root, int level, List<int> visited)
    {
        if(root == null)
        {
            return;
        }
        if(level >= visited.Count)
        {
            visited.Add(root.data);
        }

        LeftViewList(root.left, level + 1, visited);
        LeftViewList(root.right, level + 1, visited);

    }

    public static int max_level = 0;
    static void LeftViewOfTreeUtils(Node root, int level)
    {
        if(root == null)
        {
            return;
        }

        if (max_level < level) {
            Console.Write(root.data + " ");
            max_level = level;
        }

        LeftViewOfTreeUtils(root.left, level+1);
        LeftViewOfTreeUtils(root.right, level+1);
    }

    static void InOrder(Node root)
    {
        if(root == null)
            return;

        InOrder(root.left);
        Console.Write(" " + root.data);
        InOrder(root.right);
    }


}

public class LevelOrder
{
    public static void DrivingCode()
    {
        Node root = new Node(10);
        root.left = new Node(2);
        root.right = new Node(3);
        root.left.left = new Node(7);
        root.left.right = new Node(8);
        root.right.right = new Node(15);
        root.right.left = new Node(12);
        root.right.right.left = new Node(14);

        var list = LeftRiView(root);

        foreach (var item in list)
        {
            Console.Write(" " + item);
        }
        Console.WriteLine();

        Console.WriteLine("Level order");
        LevelOrderPrint(root);

    }
    static List<int> LeftRiView(Node root)
    {
        List<int> list = new List<int>();

        LeftView(root, 0, list);

        return list;

    }
    static void LeftView(Node root, int level, List<int> list)
    {
        if(root == null)
            return;
        
        if(level >= list.Count)
            list.Add(root.data);

        LeftView(root.left, level +1 , list);
        LeftView(root.right, level +1 , list);
      

    }
    static void LevelOrderPrint(Node root)
    {

        Queue<Node> qu = new Queue<Node>();
        qu.Enqueue(root);
        qu.Enqueue(null);

        while(qu.Count != 0)
        {
            Node curr = qu.Dequeue();
            if(curr == null)
            {
                Console.WriteLine();
                if(qu.Count == 0)
                    break;
                else
                    qu.Enqueue(null);
            }
            else
            {
                Console.Write(" " + curr.data);
                if(curr.left != null)
                    qu.Enqueue(curr.left);
                if(curr.right != null)
                    qu.Enqueue(curr.right);
            }
        }
    }
}
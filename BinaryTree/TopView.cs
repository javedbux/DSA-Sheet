


using System.Collections;

public class TopView
{
     public static void DrivingCode()
    {
        // Node root = new Node(10);
        // root.left = new Node(2);
        // root.right = new Node(3);
        // root.left.left = new Node(7);
        // root.left.right = new Node(8);
        // root.right.right = new Node(15);
        // root.right.left = new Node(12);
        // root.right.right.left = new Node(14);


        Node root = new Node(1);
        root.left = new Node(2);
        root.right = new Node(3);
        root.left.right = new Node(4);
        root.left.right.right = new Node(5);
        root.left.right.right.right = new Node(6);


        var list = TopViewPrint(root);

        foreach (var item in list)
        {
            Console.Write(" " + item);
        }
        Console.WriteLine();

        //Console.WriteLine("Level order");
        //LevelOrderPrint(root);

    }

    static List<int> TopViewPrint(Node root)
    //static void TopViewPrint(Node root)
    {
        List<int> list = new List<int>();
        //Your code here
        Queue qu = new Queue();
        SortedDictionary<int, Node> topMap = new SortedDictionary<int, Node>();

        if(root == null)
            return list;
        else
            qu.Enqueue(new QueueObj(root,0));

        while(!qu.Count.Equals(0))
        {
            QueueObj curr = (QueueObj) qu.Dequeue();

            if(!topMap.ContainsKey(curr.hd))
                topMap[curr.hd] = curr.node;
            
            if(curr.node.left != null)
                qu.Enqueue(new QueueObj(curr.node.left, curr.hd - 1));

            if(curr.node.right != null)
                qu.Enqueue(new QueueObj(curr.node.right, curr.hd + 1));

        }

        foreach(var val in topMap.Values)
        {
            //Console.Write(" " + val.data);
            list.Add(val.data);
        }
        
        return list;

    }
}

class QueueObj
{
    public Node node;
    public int hd;

    public QueueObj(Node node, int hd)
    {
        this.node = node;
        this.hd = hd;

    }
}
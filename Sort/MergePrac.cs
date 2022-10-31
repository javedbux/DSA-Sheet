public class MergePrac
{
    public static void DrivingCode()
    {
        int[] arr = {2,3,1,5,9,4,11,34,22};

        DivideSort(arr, 0 , arr.Length -1);

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("  " + arr[i]);
        }        
    }

    static void DivideSort(int[] arr, int si, int ei)
    {
        if(si >= ei)
        {
            return;
        }
        int mid = (si+ei) / 2;
        DivideSort(arr, si, mid);
        DivideSort(arr, mid+1, ei);
        Conquere(arr, mid, si, ei);
    }

    static void Conquere(int[] arr, int mid, int si, int ei)
    {
        int[] merge = new int[ei - si + 1];

        int index1 = si;
        int index2 = mid + 1;
        int x = 0;

        while(index1 <= mid && index2 <= ei)
        {
            if(arr[index1] >= arr[index2])
            {
                merge[x++] = arr[index1++];
            }
            else
            {
                merge[x++] = arr[index2++];
            }
        }

        while(index1 <= mid)
        {
            merge[x++] = arr[index1++];
        }

        while(index2 <= ei)
        {
            merge[x++] = arr[index2++];
        }

        for (int i = 0, j = si; i < merge.Length; i++, j++)
        {
            arr[j] = merge[i];
        }
    }
}
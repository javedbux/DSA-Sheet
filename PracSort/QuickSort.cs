
public class QuickSort
{
    public static void DrivingCode()
    {
        int[] arr = {7,6,9,8,4,3,111,2};
        int n = arr.Length;

        //MergeSort
        Divide(arr, 0 , n -1);

        for (int i = 0; i < n; i++)
        {
            Console.Write(" " + arr[i]);

        }


        Console.WriteLine("Quick Sort");
        Console.WriteLine();
        //QuickSort
        int[] arr1 = {12,7,6,9,8,4,3,124,222,2};
        int n1 = arr1.Length;

        SortQuick(arr1, 0, arr1.Length - 1);

        for (int i = 0; i < arr1.Length; i++)
        {
            Console.Write(" " + arr1[i]);
        }
    }
    static void SortQuick(int[] arr, int low, int high)
    {
        if(low < high)
        {
            int pivot = Partition(arr, low, high);

            SortQuick(arr, low, pivot - 1);
            SortQuick(arr, pivot +1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];        
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if(arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                
            }
        }
        
        i++;
        int temp1 = arr[i];
        arr[i] = arr[high];
        arr[high] = temp1;

        return i;

    }

    static void Divide(int[] arr, int si, int ei)
    {
        if(si >= ei)
        {
            return;
        }

        int mid = (si + ei) /2;

        Divide(arr, si, mid);
        Divide(arr, mid + 1, ei);
        Conqur(arr, mid, si, ei);
    }
    static void Conqur(int[] arr, int mid, int si, int ei)
    {
        int[] mergeArray = new int[ei - si + 1];

        int index1 = si;
        int index2 = mid +1;
        int x =0;

        while(index1 <= mid && index2 <= ei)
        {            
            if(arr[index1] < arr[index2])
            {
                mergeArray[x++] = arr[index1++];
            }
            else
            {
                mergeArray[x++] = arr[index2++];
            }
        }

        while(index1 <= mid)
        {
            mergeArray[x++] = arr[index1++];
        }

        while(index2 <= ei)
        {
            mergeArray[x++] = arr[index2++];
        }

        for (int i = 0, j = si; i < mergeArray.Length; i++, j++)
        {
            //Console.WriteLine(arr[j] + " " + mergeArray[i]);
            arr[j] = mergeArray[i];
        }

    }
}
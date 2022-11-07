
public class Sort
{
    public static void DrivingCode()
    {
        int[] arr = {54,6,3,44,2,1,66,5};

        QuickSort(arr, 0, arr.Length -1);

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(" "+ arr[i]);
        }
        Console.WriteLine();
    }

    static void QuickSort(int[] arr, int low, int high)
    {
        if(low < high)
        {
            int pivot = Partition(arr, low, high);

            QuickSort(arr, low, pivot -1);
            QuickSort(arr, pivot +1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low -1;

        for (int j = low; j < high; j++)
        {
            if(arr[j] < pivot)
            {
                i++;
                //swap
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
}

public class Sorting
{
    public static void DrivingCode()
    {
        int[] arr = {23,12,3,45,6,7,99,5};


        //<erge
        Console.WriteLine("MergeSort");  
        MergeSort(arr, 0, arr.Length -1);

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(" " + arr[i]);
        }

        Console.WriteLine();
    }

    static void MergeSort(int[] arr, int si, int ei)
    {
        if(si >= ei)
        {
            return;
        }

        int mid =  (si +ei) / 2;

        MergeSort(arr, si, mid);
        MergeSort(arr, mid+1, ei);
        Conqure(arr, mid, si, ei);

        
    }

    static void Conqure(int[] arr, int mid, int si, int ei)
    {
        int[] merged = new int[ei -si +1];
        int index1 = si;
        int index2 = mid +1;
        int x =0;

        while(index1 <= mid && index2 <= ei)
        {
            if(arr[index1] < arr[index2])
            {
               merged[x++] = arr[index1++];
            }
            else
            {
                merged[x++] = arr[index2++];
            }
        }

        while(index1 <= mid)
        {
            merged[x++] = arr[index1++];
        }

        while (index2 <= ei)
        {
            merged[x++] = arr[index2++];
        }

        //merge arr to arr
        for (int i = 0, j =si; i < merged.Length; i++, j++)
        {
            arr[j] = merged[i];
        }

    }
}
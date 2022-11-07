

public class MergeSort
{
    public static void DrivingCode()
    {
        int[] arr = {4,7,25,5,36,8,9,255,99};

        Divide(arr, 0, arr.Length-1);

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(" " + arr[i]);   
        }
        Console.WriteLine();


        Console.WriteLine("QuickSort");

        int[] arr1 = {4,7,25,5,36,8,9,255,99,786,123};

        QuickSort(arr1, 0, arr1.Length-1);
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.Write(" " + arr1[i]);   
        }
        Console.WriteLine();


    }

    static void QuickSort(int[] arr, int low, int high)
    {
        if(low < high)
        {
            int pivot = Partition(arr, low, high);
            //Console.WriteLine(pivot);

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
            //Console.WriteLine("s");
            return;
        }

        int mid = (si+ei)/2; 
        //Console.WriteLine(mid +" " +ei);
        Divide(arr, si, mid);
        Divide(arr, mid+1, ei);
        Conqure(arr, mid, si, ei);

        
    }

    static  void Conqure(int[] arr, int mid, int si, int ei)
    {
        //Console.WriteLine(mid +" " +ei);
        //Console.WriteLine((si + ei -1) + " " + (ei - si +1));
        int[] merge = new int[ei - si +1];

        int index1 = si;
        int index2 = mid+1;
        int x = 0;

        while(index1 <= mid && index2 <= ei)
        {
            //Console.WriteLine(index1 +" " + mid);
            if(arr[index1] < arr[index2])
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


        for (int i = 0, j =si; i < merge.Length; i++, j++)
        {
            arr[j] = merge[i];
        }
    }
}
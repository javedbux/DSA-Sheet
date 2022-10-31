

public class QuickSort
{
    public static void DrivingCode()
    {
        int[] arr = { 9,2,5,1,8,6,122,11};
        QuickSorting(arr, 0 , arr.Length -1);

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(" "+ arr[i]);
        }
    }

    static void QuickSorting(int[] arr, int low, int high)
    {
        if(low < high)
        {
            int pivot =  Partition(arr, low, high);

            QuickSorting(arr, low, pivot -1);
            QuickSorting(arr, pivot +1 , high);
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
                int temp1 = arr[i];
                arr[i] = arr[j];
                arr[j] = temp1;
            }
        }
        i++;
        int temp = arr[i];
        arr[i] = arr[high];
        arr[high] = temp;

        return i;
    }

}
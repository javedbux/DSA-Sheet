
public class QuickSortPrac
{
    public static void DrivingCode()
    {
        int[] arr =  {2,1,55,4,78,99,3};
        int n = arr.Length;
        SortedArray(arr, 0, n-1);

        for (int i = 0; i < n; i++)
        {
            Console.Write(" " + arr[i]);
        }

    }
    static void SortedArray(int[] arr, int low, int high)
    {
        if(low < high)
        {
            int pivot = Partition(arr, low, high);

            SortedArray(arr, low, pivot -1);
            SortedArray(arr, pivot +1, high);
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
        arr[i] = pivot;
        arr[high] = temp1;

        return i;
    }
}
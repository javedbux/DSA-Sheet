
public class Prac
{
    public static void DrivingCode()
    {
        int[] arr= {1,7,5,8,6,9};
        SelectionSort(arr);
    }
    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n; i++)
        {
            int selection = i;
            for (int j = 0; j < n-1; j++)
            {
                if(arr[selection] < arr[j])
                {
                    int temp = arr[selection];
                    arr[selection] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(" "+ arr[i]);
        }
        Console.WriteLine();
    }
}

public class Prac
{
    public static void DrivingCode()
    {
        int[] arr= {1,7,5,8,6,9};
        SelectionSort(arr);

        int[] arr1 = {7,8,3,2,4, 1};
        Console.WriteLine("Insert Sort");
        //InsertSort(arr1);


        int[] arr2 = {1,4,2,9,7,6,45,10};
        //int[] arr = {6,3,9,5,2,8};

        DivideArray(arr2, 0, arr2.Length -1);

        for (int i = 0; i < arr2.Length; i++)
        {
            Console.Write(" " + arr2[i]);
        }
        Console.WriteLine();
    }
    static void DivideArray(int[] arr, int si, int ei)
    {
        if(si >= ei)
        {
            return;
        }

        int mid =  si + (ei -si) /2; //(si + ei) /2 ;

        DivideArray(arr, si, mid);
        DivideArray(arr, mid+1, ei);
        Conquere(arr, mid, si, ei);
    }
    static void Conquere(int[] arr, int mid, int si, int ei)
    {
        //Console.WriteLine(ei -si + 1);
        int[] merge = new int[ei -si + 1];
        int index1 = si;
        int index2 = mid+1;
        int x =0;

        while(index1 <= mid && index2 <= ei)
        {
            if(arr[index1] <= arr[index2])
            {
                merge[x++] = arr[index1++];
            }
            else{
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

    static void InsertSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n; i++)
        {
            int current = arr[i] ;
            int j = i-1;

            while(j >= 0 && current < arr[i])
            {
                arr[j+1] = arr[j];
                j--;
            }

            arr[j+1] = current;
        }
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
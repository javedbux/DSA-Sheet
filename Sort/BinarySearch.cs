
public class BinarySearch
{
    public static void DrivingCode()
    {
        int[] arr = {-4, -1, 3, 7, 10 ,11};

        //iterative
        Console.WriteLine("Iteratibe type");
        int ans = SearchInArray(arr, 10);
        Console.WriteLine(ans);

        //recursive
        Console.WriteLine("Recursive type");
        int ans1 = SearchInArrayRe(arr, 11, 0, arr.Length);
        Console.WriteLine(ans1);

    }
    static int SearchInArrayRe(int[] arr, int key, int low, int high)
    {
        if(low > high)
        {
            return -1;
        }       

        int mid = (low + high) /2;
        if(arr[mid] == key)
        {
            return mid;
        }
        if(key < arr[mid])
            return SearchInArrayRe(arr, key, low, mid);

       return  SearchInArrayRe(arr, key, mid+1, high);
    }


    static int  SearchInArray(int[] arr, int key)
    {
        int low = 0;
        int high = arr.Length ;
        

        while(low < high)
        {
            int mid = (low+high)/2;
            //Console.WriteLine(arr[mid]);
            //Console.WriteLine(low + " " + high);
            if(arr[mid] < key)
            {
                low = mid +1;
                //low++;
                //high--;
            }
            else
            {
                high = mid;
                //high--;
                //low++;
            }

            if(arr[mid] == key)
            {
                return mid;
            }
        }

        return -1;

    }
}
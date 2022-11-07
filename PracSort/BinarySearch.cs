
public class BinarySearch
{
    public static void DrivingCode()
    {
        Console.WriteLine("Binary Search");
        int[] arr = {12,23,45,66,77,89,99,100,299, 345, 455, 552,677,765,899,987,1000,1256,1345,1455,1544,1655,1735,4521,6542,5243};
        int ans = Search(arr, 99, 0, arr.Length -1);
        Console.WriteLine(ans);

        int key =987;
        int ans1 = FindAnumber(arr, key);
        Console.WriteLine("Index is " +  ans1);
        //Find a number in infinite sorted array

        int ansFind = FinnumberInfiniteSortedArray(arr, key);
        Console.WriteLine("Practice Sorted array is " +  ansFind);


        int key1 =5;
        int[] arr1 = {12,23,45,66,77,89,99,100,299, 1,2,3,5,6};
        //int[] arr1 = {20,30,40,50,60,5,10};
        int ans2 = FindNumberInRotateArray(arr1, key1);
        Console.WriteLine("Index at Rotate Array " +  ans2);
        
    }

    static int FinnumberInfiniteSortedArray(int[] arr, int key)
    {
        int low = 0;
        int high = 1;

        while(key > arr[high])
        {
            low = high;
            high = 2* high;
        }

        return Search(arr, key, low, high);
    }

    static int FindNumberInRotateArray(int[] arr, int key)
    {
        //int[] arr1 = {12,23,45,66,77,89,99,100,299, 1,2,3,5,6};
        int low = 0;
        int high = arr.Length -1;

        while(low <= high)
        {
            int mid = (low + high)/2;

            //Console.WriteLine(arr[mid]);
            if(arr[mid] == key)
            {
                return mid;
            }
            // if(arr[mid] < key)
            // {
            //     low = mid+1;
            // }
            // else
            // {
            //     high = mid;
            // }

            if(arr[low] < arr[mid])
            {
                Console.WriteLine("Left");
                //Console.WriteLine(arr[mid]);
                if(key < arr[mid] && key >= arr[low])
                {
                    
                    
                    high = mid -1;                
                    //Console.WriteLine("Low = " + arr[low] + " high = " + arr[high]);
                }else
                {
                    
                    low = mid+1;
                    Console.WriteLine(arr[low]);
                    Console.WriteLine(arr[high]);
                }
            }
            else
            {
                Console.WriteLine("Right");
                if(key > arr[mid] && key <= arr[high])
                {
                    low = mid +1;
                }
                else
                {
                    high = mid -1;
                }                
            }            
        }

        return -1;
    }

    static int FindAnumber(int[] arr, int key)
    {
        int low = 0;
        int high = 1;

        while(arr[high] < key)
        {
            low = high;
            high = 2* high;            
        }
        //Console.WriteLine(arr[high] + " " + high);

        return Search(arr, key, low, high);
    }
    static int Search(int[] arr,int key, int low, int high)
    {        
        Console.WriteLine("In search");
        while(low < high)
        {
            int mid = (low + high) /2;
            //Console.WriteLine(arr[mid]);
            if(arr[mid] == key)
            {
                return mid;
            }

            if(arr[mid] < key)
            {
                low = mid +1;
                //low++;

            }
            else
            {
                high = mid;
                //high--;
            }

        }

        return -1;
    }
}
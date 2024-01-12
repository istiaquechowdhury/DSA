using System;


public class Program
{
    public static void Main()
    {
        string[] s = Console.ReadLine().Split();

        int[] arr = Array.ConvertAll(s, int.Parse);

        int X = int.Parse(Console.ReadLine());  

        bool x = Binary_Search(arr, X);  
        Console.WriteLine(x);
    }

    public static bool Binary_Search(int[] arr, int X)
    {
        int left, right, mid;

        left = 0;
        right = arr.Length-1;

        while (left <= right)
        {
            mid = (left+right)/2;

            if (arr[mid] == X)
            {
                return true;    
            }

            if (arr[mid] < X)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return false;
    }
}
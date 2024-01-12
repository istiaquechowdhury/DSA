using System;

public class Program
{
    public static void Main()
    {
        string[] S = Console.ReadLine().Split();
        int[] arr = Array.ConvertAll(S, int.Parse);

        int X = int.Parse(Console.ReadLine());

        int linear = Linear_Search(arr,X);

        Console.WriteLine(linear);
        
    }

    public static int Linear_Search(int[] arr,int X)
    {
        for(int i  = 0; i < arr.Length; i++)
        {
            if (arr[i] == X)
            {
                return i;
            }
        }
        return -1;
    }
}
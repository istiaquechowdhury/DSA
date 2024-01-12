using System;
using System.ComponentModel.Design;

public class Program
{
    public static void Main()
    {
       

        

        string[] s = Console.ReadLine().Split();
        int[] arr = Array.ConvertAll(s, int.Parse);
        int X = int.Parse(Console.ReadLine());

        int Result =  Linear_Search(arr, X);
        Console.WriteLine(Result);

        
       
    }

    public static int Linear_Search(int[]arr,int X)
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
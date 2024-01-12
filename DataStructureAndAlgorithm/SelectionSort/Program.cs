using System;


public class Program
{
    public static void Main()
    {
        string[] s = Console.ReadLine().Split();

        int[] arr = Array.ConvertAll(s, int.Parse); 

        
        for(int i = 0; i < arr.Length -1; i++)
        {
            int MinIndex = i;
            for(int j = i+1; j  < arr.Length; j++)
            {
                if (arr[j] < arr[MinIndex])
                {
                    MinIndex = j;

                }
            }
            int temp = arr[MinIndex];

            arr[MinIndex] = arr[i];
            arr[i] = temp;
        }

        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);  
        }
        
        

    }

}

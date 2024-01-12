using System;


public class Program
{
    public static void Main()
    {
        string[] s = Console.ReadLine().Split();

        int[] arr = Array.ConvertAll(s, int.Parse);

        Selection_Sort(arr);

        for(int i  = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }


    }

    public static void Selection_Sort(int[] arr)
    {
        for(int i = 0; i < arr.Length-1; i++)
        {
            int MinIndex = i;
            for(int j = i + 1; j < arr.Length; j++)
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
    }
}



﻿using System;

class Program
{
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n-1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j+1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine("Original array:");
        PrintArray(arr);

        BubbleSort(arr);

        Console.WriteLine("Sorted array:");
        PrintArray(arr);
    }
}

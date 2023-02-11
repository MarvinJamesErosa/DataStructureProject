using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionSort : MonoBehaviour
{
    static void Main(string[] args)
    {
        int[] a = new int[] { 10, 6, 8, 4, 2 };
        SelectionSort(a);
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write($"{a[i]} ");
        }
        Console.ReadLine();
    }

    private static void SelectionSort(int[] a)
    {
        int index = 0, minPos = 0, count = a.Length;
        while (index < count)
        {
            minPos = index;
            for (int i = index + 1; i < count; i++)
            {
                if (a[i] < a[minPos])
                {
                    minPos = i;
                }
            }
            int t = a[index];
            a[index] = a[minPos];
            a[minPos] = t;
            index++;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

class BubbleSortExample
{
    // Metode for å utføre Bubble Sort
    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Bytte 2 elementer
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    static void Main()
    {
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Unsorted array:");
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        BubbleSort(array);//kalle på metoden bubblesort, og sender med den usorterte arrayen

        Console.WriteLine("Sorted array:");
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

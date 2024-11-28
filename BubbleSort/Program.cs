using System;

class BubbleSortExample
{
    // Metode for å utføre Bubble Sort med tidlig avslutning
    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Bytte to elementer
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    swapped = true;
                }
            }

            // Slutter å loope hvis alt er sortert
            if (!swapped)
            {
                break;
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

        BubbleSort(array); // Kalle på metoden BubbleSort, og sende med den usorterte arrayen

        Console.WriteLine("Sorted array:");
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        Console.ReadLine();
    }
}

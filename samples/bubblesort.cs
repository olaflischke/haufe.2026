using System;

class Program
{
    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            bool getauscht = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    getauscht = true;
                }
            }
            if (!getauscht) break; // Bereits sortiert
        }
    }

    static void Main()
    {
        int[] zahlen = { 64, 34, 25, 12, 22, 11, 90 };
        BubbleSort(zahlen);
        Console.WriteLine(string.Join(", ", zahlen));
        // Ausgabe: 11, 12, 22, 25, 34, 64, 90
    }
}

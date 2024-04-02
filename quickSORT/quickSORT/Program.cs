using System;

class QuickSort
{
    public static void QuickSortAlgorithm(int[] array, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(array, left, right);
            QuickSortAlgorithm(array, left, pivotIndex - 1);
            QuickSortAlgorithm(array, pivotIndex + 1, right);
        }
    }

    public static int Partition(int[] array, int left, int right)
    {
        int pivot = array[right]; // zapamietaj pivot ostatni eleemnt!
        int index = left - 1;

        for (int i = left; i < right; i++)
        {
            if (array[i] <= pivot)
            {
                index++;
                Swap(ref array[index], ref array[i]);
            }
        }

        Swap(ref array[index + 1], ref array[right]);
        return index + 1;
    }

    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public static void Main(string[] args)
    {
        int[] array = new int[100];

        Random r = new Random();
        int kc;
        for (int i = 0; i < 100 ;i++)
        {
            kc = r.Next(0, 1000);
            array[i] = kc;
        }


        Console.WriteLine("Tablica przed sortowaniem:");
        foreach (var okej in array)
        {
            Console.Write(okej + " ");
        }
        Console.WriteLine();

        QuickSortAlgorithm(array, 0, array.Length - 1);

        Console.WriteLine("Tablica po sortowaniu:");
        foreach (var okej in array)
        {
            Console.Write(okej + " ");
        }
        Console.WriteLine();
    }
}

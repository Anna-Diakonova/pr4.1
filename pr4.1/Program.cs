using System;

class Program
{
    static int SumPositiveRecursive(int[] array, int index = 0)
    {
        if (index >= array.Length)
        {
            return 0;
        }

        int current = array[index] > 0 ? array[index] : 0;

        return current + SumPositiveRecursive(array, index + 1);
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int[] A = new int[20];
        Random rand = new Random();

        Console.WriteLine("Масив А (20 елементів):");
        for (int i = 0; i < A.Length; i++)
        {
            A[i] = rand.Next(-10, 21);
            Console.Write($"{A[i]} ");
        }
        Console.WriteLine("\n");

        int positiveSum = SumPositiveRecursive(A);

        Console.WriteLine($"Сума додатних елементів масиву А (рекурсивно): {positiveSum}");
        Console.ReadLine();
    }
}
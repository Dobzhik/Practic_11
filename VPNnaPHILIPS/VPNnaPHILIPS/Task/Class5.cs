using System;

class Task5
{
    public void Execute()
    {
        int[] array = new int[9];
        Console.WriteLine("Введите 9 целых чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int maxIndex = FindMaxIndex(array);
        int minIndex = FindMinIndex(array);
        SwapElements(array, maxIndex, minIndex);

        Console.WriteLine("Массив после замены максимального и минимального элементов:");
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
    }

    private int FindMaxIndex(int[] array)
    {
        int maxIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }
        return maxIndex;
    }

    private int FindMinIndex(int[] array)
    {
        int minIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[minIndex])
            {
                minIndex = i;
            }
        }
        return minIndex;
    }

    private void SwapElements(int[] array, int index1, int index2)
    {
        int temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }
}
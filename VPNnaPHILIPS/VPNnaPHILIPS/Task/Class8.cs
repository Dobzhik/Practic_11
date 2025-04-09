using System;

class Task8
{
    public void Execute()
    {
        double[] array = new double[16];
        Console.WriteLine("Введите 16 вещественных чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = double.Parse(Console.ReadLine());
        }

        int maxIndex = FindMaxIndex(array);
        int minIndex = FindMinIndex(array);

        Console.WriteLine($"Индекс максимального элемента: {maxIndex}");
        Console.WriteLine($"Индекс минимального элемента: {minIndex}");
    }

    private int FindMaxIndex(double[] array)
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

    private int FindMinIndex(double[] array)
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
}
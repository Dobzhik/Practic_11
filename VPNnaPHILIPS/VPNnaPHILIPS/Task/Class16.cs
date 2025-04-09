using System;

class Task16
{
    public void Execute()
    {
        double[] array = new double[12];
        Console.WriteLine("Введите 12 действительных чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = double.Parse(Console.ReadLine());
        }

        int maxIndex = FindMaxIndex(array);
        int minIndex = FindMinIndex(array);

        int count = Math.Abs(maxIndex - minIndex) - 1;

        Console.WriteLine($"Количество чисел между максимальным и минимальным элементами: {count}");
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

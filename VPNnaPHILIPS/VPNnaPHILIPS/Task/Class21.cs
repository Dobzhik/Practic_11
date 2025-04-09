using System;

class Task21
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

        int minIndex = FindMinIndex(array);
        array[minIndex] *= 3;

        double temp = array[minIndex];
        array[minIndex] = array[array.Length - 1];
        array[array.Length - 1] = temp;

        Console.WriteLine("Массив после изменений:");
        foreach (double number in array)
        {
            Console.Write(number + " ");
        }
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
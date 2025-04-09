using System;

class Task3
{
    public void Execute()
    {
        int[] array = new int[11];
        Console.WriteLine("Введите 11 целых чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        double average = CalculateAverage(array);
        int count = CountElementsGreaterThanAverage(array, average);

        Console.WriteLine($"Количество элементов, абсолютное значение которых больше среднего арифметического: {count}");
    }

    private double CalculateAverage(int[] array)
    {
        int sum = 0;
        foreach (int number in array)
        {
            sum += number;
        }
        return (double)sum / array.Length;
    }

    private int CountElementsGreaterThanAverage(int[] array, double average)
    {
        int count = 0;
        foreach (int number in array)
        {
            if (Math.Abs(number) > average)
            {
                count++;
            }
        }
        return count;
    }
}
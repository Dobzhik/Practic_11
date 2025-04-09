using System;

class Task28
{
    public void Execute()
    {
        int[] array = new int[17];
        Console.WriteLine("Введите 17 целых чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        double average = CalculateAverageOfPositives(array);
        int sum = 0;
        int count = 0;

        foreach (int number in array)
        {
            if (Math.Abs(number) > average)
            {
                sum += number;
                count++;
            }
        }

        Console.WriteLine($"Сумма элементов, абсолютное значение которых больше среднего арифметического положительных элементов: {sum}");
        Console.WriteLine($"Количество таких элементов: {count}");
    }

    private double CalculateAverageOfPositives(int[] array)
    {
        int sum = 0;
        int count = 0;

        foreach (int number in array)
        {
            if (number > 0)
            {
                sum += number;
                count++;
            }
        }

        return count > 0 ? (double)sum / count : 0;
    }
}
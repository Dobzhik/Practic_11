using System;

class Task10
{
    public void Execute()
    {
        int[] array = new int[17];
        Console.WriteLine("Введите 17 целых чисел (положительных и отрицательных):");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        double average = CalculateAverageOfNegativeModules(array);
        int sum = CalculateSumOfElementsGreaterThanAverage(array, average);

        Console.WriteLine($"Сумма элементов, абсолютное значение которых больше среднего арифметического модулей отрицательных элементов: {sum}");
    }

    private double CalculateAverageOfNegativeModules(int[] array)
    {
        int sumOfModules = 0;
        int countOfNegatives = 0;

        foreach (int number in array)
        {
            if (number < 0)
            {
                sumOfModules += Math.Abs(number);
                countOfNegatives++;
            }
        }

        return countOfNegatives > 0 ? (double)sumOfModules / countOfNegatives : 0;
    }

    private int CalculateSumOfElementsGreaterThanAverage(int[] array, double average)
    {
        int sum = 0;
        foreach (int number in array)
        {
            if (Math.Abs(number) > average)
            {
                sum += number;
            }
        }
        return sum;
    }
}
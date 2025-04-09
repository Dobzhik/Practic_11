using System;

class Task7
{
    public void Execute()
    {
        double[] array = new double[15];
        Console.WriteLine("Введите 15 вещественных чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = double.Parse(Console.ReadLine());
        }

        int count = CountElementsGreaterThanFirst(array);

        Console.WriteLine($"Количество элементов, значения которых больше первого элемента: {count}");
    }

    private int CountElementsGreaterThanFirst(double[] array)
    {
        int count = 0;
        double firstElement = array[0];
        foreach (double number in array)
        {
            if (number > firstElement)
            {
                count++;
            }
        }
        return count;
    }
}
using System;

class Task18
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

        double min = array[0];
        double max = array[0];

        foreach (double number in array)
        {
            if (number < min) min = number;
            if (number > max) max = number;
        }

        Console.WriteLine($"Границы интервала: [{min}, {max}]");
    }
}
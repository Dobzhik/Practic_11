using System;

class Task15
{
    public void Execute()
    {
        double[] array = new double[14];
        Console.WriteLine("Введите 14 действительных чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = double.Parse(Console.ReadLine());
        }

        Array.Sort(array, 0, 7);
        Array.Sort(array, 7, 7);
        Array.Reverse(array, 7, 7);

        Console.WriteLine("Массив после сортировки:");
        foreach (double number in array)
        {
            Console.Write(number + " ");
        }
    }
}
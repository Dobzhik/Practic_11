using System;
using System.Linq;

class Task12
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

        
        Array.Sort(array);
        Array.Reverse(array);

        double max = array.Max();
        double min = array.Min();
        double sum = max + min;

        Console.WriteLine("Массив после сортировки в порядке убывания:");
        foreach (double number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine($"\nСумма максимального и минимального элементов: {sum}");
    }
}
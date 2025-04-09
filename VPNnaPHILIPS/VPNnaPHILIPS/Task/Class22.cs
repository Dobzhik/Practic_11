using System;

class Task22
{
    public void Execute()
    {
        double[] array = new double[15];
        Console.WriteLine("Введите 15 действительных чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = double.Parse(Console.ReadLine());
        }

        Array.Reverse(array);

        Console.WriteLine("Массив в обратном порядке:");
        foreach (double number in array)
        {
            Console.Write(number + " ");
        }
    }
}
using System;

class Task27
{
    public void Execute()
    {
        int[] array = new int[19];
        Console.WriteLine("Введите 19 целых чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int max = array[0];
        foreach (int number in array)
        {
            if (number > max) max = number;
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                array[i] = max;
            }
        }

        Console.WriteLine("Массив после замены четных элементов на максимальное число:");
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
    }
}
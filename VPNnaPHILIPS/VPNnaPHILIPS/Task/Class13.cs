using System;

class Task13
{
    public void Execute()
    {
        int[] array = new int[15];
        Console.WriteLine("Введите 15 целых чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int max = array[0];
        int min = array[0];

        foreach (int number in array)
        {
            if (number > max) max = number;
            if (number < min) min = number;
        }

        int sum = max + min;
        int difference = max - min;

        Console.WriteLine($"Сумма максимального и минимального элементов: {sum}");
        Console.WriteLine($"Разность максимального и минимального элементов: {difference}");
    }
}
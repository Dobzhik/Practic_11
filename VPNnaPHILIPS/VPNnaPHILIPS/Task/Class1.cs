using System;

class Task1
{
    public void Execute()
    {
        int[] array = new int[14];
        Console.WriteLine("Введите 14 целых чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int evenCount = 0;
        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }

        Console.WriteLine($"Количество четных элементов в массиве: {evenCount}");
    }
}
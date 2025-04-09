using System;

class Task20
{
    public void Execute()
    {
        int[] array = new int[16];
        Console.WriteLine("Введите 16 целых чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int replaceCount = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 3 == 0)
            {
                array[i] = 0;
                replaceCount++;
            }
        }

        Console.WriteLine("Массив после замены:");
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine($"\nКоличество замен: {replaceCount}");
    }
}
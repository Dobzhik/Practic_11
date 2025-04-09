using System;

class Task17
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

        int negativeCount = 0;
        int zeroCount = 0;
        long productOfPositives = 1;

        foreach (int number in array)
        {
            if (number < 0)
            {
                negativeCount++;
            }
            else if (number == 0)
            {
                zeroCount++;
            }
            else
            {
                productOfPositives *= number;
            }
        }

        Console.WriteLine($"Количество отрицательных элементов: {negativeCount}");
        Console.WriteLine($"Произведение положительных элементов: {productOfPositives}");
        Console.WriteLine($"Количество нулевых элементов: {zeroCount}");
    }
}
using System;

class Task23
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

        int sumEvenIndex = 0;
        long productOddValue = 1;

        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                sumEvenIndex += array[i];
            }
            if (array[i] % 2 != 0)
            {
                productOddValue *= array[i];
            }
        }

        Console.WriteLine($"Сумма элементов с четными индексами: {sumEvenIndex}");
        Console.WriteLine($"Произведение нечетных по значению элементов: {productOddValue}");
    }
}
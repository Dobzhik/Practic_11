using System;

class Task6
{
    public void Execute()
    {
        int[] array = new int[20];
        Console.WriteLine("Введите 20 целых чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int evenCount = CountEvenNumbers(array);
        int oddCount = array.Length - evenCount;

        if (evenCount > oddCount)
        {
            Console.WriteLine("Четных элементов больше.");
        }
        else if (oddCount > evenCount)
        {
            Console.WriteLine("Нечетных элементов больше.");
        }
        else
        {
            Console.WriteLine("Количество четных и нечетных элементов одинаково.");
        }
    }

    private int CountEvenNumbers(int[] array)
    {
        int evenCount = 0;
        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }
        return evenCount;
    }
}
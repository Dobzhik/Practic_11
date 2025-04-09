using System;

class Task19
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

        int sum = 0;
        bool negativeFound = false;

        foreach (int number in array)
        {
            if (number < 0)
            {
                negativeFound = true;
                break;
            }
            sum += number;
        }

        if (negativeFound)
        {
            Console.WriteLine($"Сумма элементов до первого отрицательного: {sum}");
        }
        else
        {
            Console.WriteLine("Отрицательных элементов нет.");
        }
    }
}
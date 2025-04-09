using System;

class Task24
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

        double lastElement = array[array.Length - 1];
        int count = 0;
        double sum = 0;

        foreach (double number in array)
        {
            if (number < lastElement)
            {
                count++;
                sum += number;
            }
        }

        Console.WriteLine($"Количество чисел меньше последнего элемента: {count}");
        Console.WriteLine($"Сумма чисел меньше последнего элемента: {sum}");
    }
}
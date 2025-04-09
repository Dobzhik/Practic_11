using System;

class Task29
{
    public void Execute()
    {
        double[] array = new double[18];
        Console.WriteLine("Введите 18 действительных чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = double.Parse(Console.ReadLine());
        }

        double productOfPositives = 1;
        double sumOfNegatives = 0;

        foreach (double number in array)
        {
            if (number > 0)
            {
                productOfPositives *= number;
            }
            else if (number < 0)
            {
                sumOfNegatives += Math.Abs(number);
            }
        }

        double quotient = productOfPositives / sumOfNegatives;

        Console.WriteLine($"Частное от деления произведения положительных элементов на сумму модулей отрицательных: {quotient}");
    }
}
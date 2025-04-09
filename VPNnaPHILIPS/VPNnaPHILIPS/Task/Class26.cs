using System;

class Task26
{
    public void Execute()
    {
        double[] array = new double[15];
        Console.WriteLine("Введите 15 действительных чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = double.Parse(Console.ReadLine());
        }

        double productOfPositives = 1;
        double productOfNegatives = 1;

        foreach (double number in array)
        {
            if (number > 0)
            {
                productOfPositives *= number;
            }
            else if (number < 0)
            {
                productOfNegatives *= Math.Abs(number);
            }
        }

        double difference = productOfPositives - productOfNegatives;

        Console.WriteLine($"Разность между произведением положительных и модулей отрицательных элементов: {difference}");
    }
}
using System;

class Task2
{
    public void Execute()
    {
        int[] array = new int[12];
        Console.WriteLine("Введите 12 целых чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        double average = CalculateAverage(array);
        int[] newArray = ReplaceFifthElement(array, average);

        Console.WriteLine("Новый массив:");
        foreach (int number in newArray)
        {
            Console.Write(number + " ");
        }
    }

    private double CalculateAverage(int[] array)
    {
        int sum = 0;
        foreach (int number in array)
        {
            sum += number;
        }
        return (double)sum / array.Length;
    }

    private int[] ReplaceFifthElement(int[] array, double average)
    {
        int[] newArray = (int[])array.Clone();
        newArray[4] = (int)average;
        return newArray;
    }
}
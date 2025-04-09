using System;

class Task9
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

        double average = CalculateAverage(array);
        int[] newArray = CreateDifferenceArray(array, average);

        Console.WriteLine("Новый массив (разность между элементами исходного массива и его среднего арифметического):");
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

    private int[] CreateDifferenceArray(int[] array, double average)
    {
        int[] newArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i] - (int)average;
        }
        return newArray;
    }
}
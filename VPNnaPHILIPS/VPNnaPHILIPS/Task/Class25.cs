using System;

class Task25
{
    public void Execute()
    {
        int[] array = new int[15];
        Console.WriteLine("Введите 15 целых чисел (положительных и отрицательных):");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int sumOfPositives = CalculateSumOfPositives(array);
        int[] newArray = CreateDifferenceArray(array, sumOfPositives);

        Console.WriteLine("Новый массив (разность между элементами исходного массива и суммой положительных элементов):");
        foreach (int number in newArray)
        {
            Console.Write(number + " ");
        }
    }

    private int CalculateSumOfPositives(int[] array)
    {
        int sum = 0;
        foreach (int number in array)
        {
            if (number > 0)
            {
                sum += number;
            }
        }
        return sum;
    }

    private int[] CreateDifferenceArray(int[] array, int sumOfPositives)
    {
        int[] newArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i] - sumOfPositives;
        }
        return newArray;
    }
}
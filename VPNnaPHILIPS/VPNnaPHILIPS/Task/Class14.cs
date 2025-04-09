using System;

class Task14
{
    public void Execute()
    {
        int[] array = new int[17];
        Console.WriteLine("Введите 17 целых чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int sumOfOdd = CalculateSumOfOddNumbers(array);
        ReplaceMultiplesOfThree(array, sumOfOdd);

        Console.WriteLine("Массив после замены элементов, кратных трем:");
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
    }

    private int CalculateSumOfOddNumbers(int[] array)
    {
        int sum = 0;
        foreach (int number in array)
        {
            if (number % 2 != 0)
            {
                sum += number;
            }
        }
        return sum;
    }

    private void ReplaceMultiplesOfThree(int[] array, int sumOfOdd)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 3 == 0)
            {
                array[i] = sumOfOdd;
            }
        }
    }
}
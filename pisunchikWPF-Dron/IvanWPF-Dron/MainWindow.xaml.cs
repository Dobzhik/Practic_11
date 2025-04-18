﻿using System;
using System.Collections.Generic;
using System.Windows;
using Practical11.Tasks;

// pisunchik 3000

namespace Practical11
{
    public partial class MainWindow : Window
    {
        private int _currentTaskNumber;
        private readonly Dictionary<int, string> _taskDescriptions = new Dictionary<int, string>()
        {
            {1, "Ввести массив из 14 целых чисел. Найти количество четных элементов."},
            {2, "Ввести массив из 12 целых чисел. Заменить 5-й элемент на среднее арифметическое."},
            {3, "Ввести массив из 11 целых чисел. Найти количество элементов, абсолютное значение которых больше среднего арифметического."},
            {4, "Ввести массив из 10 целых чисел. Поменять местами максимальный и первый элементы."},
            {5, "Ввести массив из 9 целых чисел. Поменять местами максимальный и минимальный элементы."},
            {6, "Ввести массив из 20 целых чисел. Определить, каких элементов больше: четных или нечетных."},
            {7, "Ввести массив из 15 вещественных чисел. Найти количество элементов больше первого."},
            {8, "Ввести массив из 16 вещественных чисел. Найти индексы max и min элементов."},
            {9, "Ввести массив из 15 целых чисел. Получить новый массив как разность с средним арифметическим."},
            {10, "Ввести массив из 17 целых чисел. Найти сумму элементов, модуль которых больше среднего модулей отрицательных элементов."},
            {11, "Ввести массив из 14 целых чисел. Найти сумму и количество четных положительных элементов."},
            {12, "Ввести массив из 12 вещественных чисел. Отсортировать по убыванию. Найти сумму max и min."},
            {13, "Ввести массив из 15 целых чисел. Найти сумму и разность max и min элементов."},
            {14, "Ввести массив из 17 целых чисел. Заменить элементы, кратные 3, на сумму нечетных элементов."},
            {15, "Ввести массив из 14 вещественных чисел. Сортировать 1-7 по возрастанию, 8-14 по убыванию."},
            {16, "Ввести массив из 12 вещественных чисел. Найти количество элементов между max и min."},
            {17, "Ввести массив из 15 целых чисел. Найти количество отрицательных, произведение положительных и нулей."},
            {18, "Ввести массив из 12 вещественных чисел. Определить интервал значений массива."},
            {19, "Ввести массив из 19 целых чисел. Найти сумму до первого отрицательного элемента."},
            {20, "Ввести массив из 16 целых чисел. Заменить кратные 3 на 0. Посчитать замены."},
            {21, "Ввести массив из 12 вещественных чисел. Увеличить min в 3 раза и поменять с последним."},
            {22, "Ввести массив из 15 вещественных чисел. Расположить элементы в обратном порядке."},
            {23, "Ввести массив из 14 целых чисел. Найти сумму четных индексов и произведение нечетных значений."},
            {24, "Ввести массив из 12 вещественных чисел. Найти сумму элементов меньше последнего."},
            {25, "Ввести массив из 15 целых чисел. Получить новый массив как разность с суммой положительных."},
            {26, "Ввести массив из 15 вещественных чисел. Найти разность произведения положительных и отрицательных."},
            {27, "Ввести массив из 19 целых чисел. Заменить четные элементы на max."},
            {28, "Ввести массив из 17 целых чисел. Найти сумму элементов, модуль которых больше среднего положительных."},
            {29, "Ввести массив из 18 вещественных чисел. Найти частное произведения положительных и суммы модулей отрицательных."}
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SolveButton_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(TaskNumberBox.Text, out int taskNumber) || taskNumber < 1 || taskNumber > 29)
            {
                MessageBox.Show("Введите число от 1 до 29!");
                return;
            }

            _currentTaskNumber = taskNumber;
            InputPanel.Visibility = Visibility.Visible;
            ResultText.Text = "";
            TaskDescriptionText.Text = _taskDescriptions.GetValueOrDefault(taskNumber, "Описание задачи отсутствует");
            InputDescription.Text = GetInputDescription(taskNumber);
        }

        private void AnswerButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string result = ProcessTask(_currentTaskNumber, InputDataBox.Text);
                InputPanel.Visibility = Visibility.Collapsed;
                ResultText.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private string GetInputDescription(int taskNumber)
        {
            return taskNumber switch
            {
                1 => "Введите 14 целых чисел через пробел:",
                2 => "Введите 12 целых чисел через пробел:",
                3 => "Введите 11 целых чисел через пробел:",
                4 => "Введите 10 целых чисел через пробел:",
                5 => "Введите 9 целых чисел через пробел:",
                6 => "Введите 20 целых чисел через пробел:",
                7 => "Введите 15 чисел через пробел:",
                8 => "Введите 16 чисел через пробел:",
                9 => "Введите 15 целых чисел через пробел:",
                10 => "Введите 17 целых чисел через пробел:",
                11 => "Введите 14 целых чисел через пробел:",
                12 => "Введите 12 чисел через пробел:",
                13 => "Введите 15 целых чисел через пробел:",
                14 => "Введите 17 целых чисел через пробел:",
                15 => "Введите 14 чисел через пробел:",
                16 => "Введите 12 чисел через пробел:",
                17 => "Введите 15 целых чисел через пробел:",
                18 => "Введите 12 чисел через пробел:",
                19 => "Введите 19 целых чисел через пробел:",
                20 => "Введите 16 целых чисел через пробел:",
                21 => "Введите 12 чисел через пробел:",
                22 => "Введите 15 чисел через пробел:",
                23 => "Введите 14 целых чисел через пробел:",
                24 => "Введите 12 чисел через пробел:",
                25 => "Введите 15 целых чисел через пробел:",
                26 => "Введите 15 чисел через пробел:",
                27 => "Введите 19 целых чисел через пробел:",
                28 => "Введите 17 целых чисел через пробел:",
                29 => "Введите 18 чисел через пробел:",
                _ => "Введите данные согласно заданию"
            };
        }

        private string ProcessTask(int taskNumber, string input)
        {
            ITask task = taskNumber switch
            {
                1 => new Task1(),
                2 => new Task2(),
                3 => new Task3(),
                4 => new Task4(),
                5 => new Task5(),
                6 => new Task6(),
                7 => new Task7(),
                8 => new Task8(),
                9 => new Task9(),
                10 => new Task10(),
                11 => new Task11(),
                12 => new Task12(),
                13 => new Task13(),
                14 => new Task14(),
                15 => new Task15(),
                16 => new Task16(),
                17 => new Task17(),
                18 => new Task18(),
                19 => new Task19(),
                20 => new Task20(),
                21 => new Task21(),
                22 => new Task22(),
                23 => new Task23(),
                24 => new Task24(),
                25 => new Task25(),
                26 => new Task26(),
                27 => new Task27(),
                28 => new Task28(),
                29 => new Task29(),
                _ => throw new ArgumentException("Неверный номер задачи")
            };

            return task.Solve(input);
        }
    }
}
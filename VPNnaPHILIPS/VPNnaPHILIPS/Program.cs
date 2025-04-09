using System;

// сделанно при поддерже Lipstik я наношу на себя Lipstik
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Практическая №11");
            Console.WriteLine("Выберите задачу 1-29:");
            int taskNumber;
            if (!int.TryParse(Console.ReadLine(), out taskNumber))
            {
                Console.WriteLine("Неверный ввод. Пожалуйста, введите число от 1 до 29.");
                continue;
            }

            if (taskNumber == 0)
            {
                Console.WriteLine("Выход из программы.");
                break;
            }

            switch (taskNumber)
            {
                case 1:
                    new Task1().Execute();
                    break;
                case 2:
                    new Task2().Execute();
                    break;
                case 3:
                    new Task3().Execute();
                    break;
                case 4:
                    new Task4().Execute();
                    break;
                case 5:
                    new Task5().Execute();
                    break;
                case 6:
                    new Task6().Execute();
                    break;
                case 7:
                    new Task7().Execute();
                    break;
                case 8:
                    new Task8().Execute();
                    break;
                case 9:
                    new Task9().Execute();
                    break;
                case 10:
                    new Task10().Execute();
                    break;
                case 11:
                    new Task11().Execute();
                    break;
                case 12:
                    new Task12().Execute();
                    break;
                case 13:
                    new Task13().Execute();
                    break;
                case 14:
                    new Task14().Execute();
                    break;
                case 15:
                    new Task15().Execute();
                    break;
                case 16:
                    new Task16().Execute();
                    break;
                case 17:
                    new Task17().Execute();
                    break;
                case 18:
                    new Task18().Execute();
                    break;
                case 19:
                    new Task19().Execute();
                    break;
                case 20:
                    new Task20().Execute();
                    break;
                case 21:
                    new Task21().Execute();
                    break;
                case 22:
                    new Task22().Execute();
                    break;
                case 23:
                    new Task23().Execute();
                    break;
                case 24:
                    new Task24().Execute();
                    break;
                case 25:
                    new Task25().Execute();
                    break;
                case 26:
                    new Task26().Execute();
                    break;
                case 27:
                    new Task27().Execute();
                    break;
                case 28:
                    new Task28().Execute();
                    break;
                case 29:
                    new Task29().Execute();
                    break;
                default:
                    Console.WriteLine("Неверный номер задачи. Пожалуйста, введите число от 1 до 29.");
                    break;
            }

            Console.WriteLine("\nНажмите Enter, чтобы продолжить...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
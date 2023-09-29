using System;
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Выберите программу:");
            Console.WriteLine("1. Игра 'Угадай число'");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Выход");
            Console.Write("Введите номер программы: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Ygadaika();
                    break;
                case 2:
                    Tableymnoj();
                    break;
                case 3:
                    Deliteli();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Некорректный выбор. Попробуйте ещё раз.");
                    break;
            }
        }
    }
    static void Ygadaika()
    {
        while (true)
        {
            Console.WriteLine("Выберите действие: ");
            Console.WriteLine("1 - Играть");
            Console.WriteLine("2 - Выход из программы");
            string chY = Console.ReadLine();
            if (chY == "1")
            {
                Random random = new Random();
                int numberToGuess = random.Next(1, 101);
                int attempts = 0;
                Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
                Console.WriteLine("Я загадал число от 1 до 100. Попробуйте угадать.");
                while (true)
                {
                    Console.Write("Введите вашу догадку: ");
                    int guess = int.Parse(Console.ReadLine());
                    attempts++;
                    if (guess < numberToGuess)
                        Console.WriteLine("Загаданное число больше.");
                    else if (guess > numberToGuess)
                        Console.WriteLine("Загаданное число меньше.");
                    else
                    {
                        Console.WriteLine($"Поздравляю! Вы угадали число {numberToGuess} за {attempts} попыток.");
                        break;
                    }
                }
            }
            if (chY == "2")
            {
                break;
            }
            if (chY != "1" &&  chY != "2")
            {
                Console.WriteLine("Ошибка: введите корректную операцию");
                continue;
            }
        }
    }
    static void Tableymnoj()
    {
        Console.WriteLine("Таблица умножения:");

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i * j}\t");
            }
            Console.WriteLine();
        }
    }
    static void Deliteli()
    {
        while (true)
        {
            Console.WriteLine("Выберите действие");
            Console.WriteLine("1 - Определить делители числа");
            Console.WriteLine("2 - Выход из программы");
            string chD = Console.ReadLine();
            if (chD == "1")
            {
                Console.Write("Введите число: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine($"Делители числа {number}:");
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                        Console.WriteLine(i);
                }
            }
            if (chD == "2")
            {
                break;
            }
            if (chD != "1" && chD != "2")
            {
                Console.WriteLine("Ошибка: введите корректную операцию");
                continue;
            }
        }
    }
}      
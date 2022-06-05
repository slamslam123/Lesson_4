using System;
namespace Work3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Игра угадай число от 0 до N . \nВведите число N: ");
            int dlinna = int.Parse(Console.ReadLine());
            Random random = new Random();
            int x = random.Next(0, dlinna);
            while (true)
            {
                Console.Write("\nВведите число: ");
                string num = Console.ReadLine();
                switch (num)
                {
                    case " ":
                        Console.WriteLine($"Вы досрочно закончили игру , загаданное число = {x}");
                        break;
                    default:
                        int number = Convert.ToInt32(num);
                        if (number == x)
                        {
                            Console.WriteLine("\nПобеда!!! Победа!!! Победа!!!");
                            break;
                        }
                        if (number > x)
                        {
                            Console.WriteLine("Введенное число больше загаданного");
                            continue;
                        }
                        if (number < x)
                        {
                            Console.WriteLine("Введенное число меньше загаданного");
                            continue;
                        }
                        break;
                }
                Console.ReadKey();
                break;
            }
        }
    }
}

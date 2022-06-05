using System;
namespace Work2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите (цифру) длинну последовательности: ");
            int dlinna = int.Parse(Console.ReadLine());
            int[] massiv = new int[dlinna];
            int max = int.MaxValue;
            for (int i = 0; i < dlinna; i++)
            {
                Console.Write("Введите целые числа: ");
                int number = int.Parse(Console.ReadLine());
                massiv[i] = number;
                if (massiv[i] < max)
                {
                    max = massiv[i];
                }
            }
            Console.WriteLine($"Самое маленькое число которое вы ввели = ({max})");
            Console.ReadKey();
        }
    }
}

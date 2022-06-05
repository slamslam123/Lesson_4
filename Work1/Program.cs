using System;
namespace Work1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int yyy = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int zzz = int.Parse(Console.ReadLine());
            
            int sum = 0;
            int[,] matrix = new int[yyy, zzz];   
            Random random = new Random();
           
            Console.WriteLine();
           
            for (int i = 0; i < yyy; i++)
            {
                for (int j = 0; j < zzz; j++)
                {
                    matrix[i, j] = random.Next(10);
                    Console.Write($"{matrix[i, j]} ");
                    sum += matrix[i, j];
                }
                Console.WriteLine();                
            }
            Console.WriteLine($"\nОбщая сумма всех цифр = {sum}");
            Console.ReadKey();
        }
    }
}

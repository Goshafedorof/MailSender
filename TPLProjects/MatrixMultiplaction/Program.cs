using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Даны две двумерных матрицы размерностью 100х100 каждая.Задача: написать приложение,
// производящее их параллельное умножение. Матрицы заполняются случайными целыми
// числами от 0 до 10.
namespace MatrixMultiplaction
{
    class Program
    {
        static Random _random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность квадратной матрицы:");
            Console.Write("N = ");

            // считывание параметров
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Matrix a = Matrix.GetRandom(n, n);
            Matrix b = Matrix.GetRandom(n, n);

            Matrix c = Matrix.Multiply(a, b);

            Console.WriteLine();
            Console.Write("Для завершения работы нажмите любую клавишу...");
            Console.ReadKey();
        }

    }
}

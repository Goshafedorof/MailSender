using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            Stopwatch timer = new Stopwatch();

            timer.Start();
            Matrix c = Matrix.Multiply(a, b);
            timer.Stop();
            Console.WriteLine($"Последовательный метод вычисления, с: {timer.Elapsed.TotalSeconds}");

            timer.Reset();

            timer.Start();
            Matrix c1 = Matrix.MultiplyAsync(a, b).Result;
            //var c1 = Matrix.MultiplyAsync(a, b);
            timer.Stop();

            Console.WriteLine($"Асинхронный метод вычисления, с: {timer.Elapsed.TotalSeconds}");

            Console.WriteLine();
            Console.Write("Для завершения работы нажмите любую клавишу...");
            Console.ReadKey();
        }

    }
}

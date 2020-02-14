using System;
using System.Threading;

// Написать приложение, считающее в раздельных потоках:
//     a.факториал числа N, которое вводится с клавиатуры;
//     b.сумму целых чисел до N

namespace Calculation
{
    class Program
    {
        public static EventWaitHandle _waitSumEnd = new EventWaitHandle(false, EventResetMode.AutoReset);
        public static EventWaitHandle _waitFactorialEnd = new EventWaitHandle(false, EventResetMode.AutoReset);

        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число для подсчета факториала и суммы целых чисел");
            Console.Write("N = ");

            // считывание параметров
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            
            Thread[] threads = new Thread[]
            {
                new Thread(()=> Factorial(n)),
                new Thread(()=> Sum(n))
            };

            // запуск потоков
            foreach (var thread in threads)
                thread.Start();

            // ожидание заврешение выполнения потоков
            foreach (var thread in threads)
                // если поток не выполняется за определенное время, то гасим его самостоятельно
                if (!thread.Join(100))
                    thread.Abort();

            // ожидаем, что все потоки завершены, чтобы финальная надпись была действительно последней
            EventWaitHandle.WaitAll(new WaitHandle[] { _waitSumEnd, _waitFactorialEnd });

            Console.WriteLine();
            Console.Write("Для завершения работы нажмите любую клавишу...");
            Console.ReadKey();
        }


        public static void Factorial(int n)
        {
            try
            {
                uint result = 1;

                for (int i = 1; i < n + 1; i++)
                    result *= (uint)i;

                //Thread.Sleep(100); - тестирование

                Console.WriteLine($"{n}! = {result.ToString("N")}");
            }
            catch (ThreadAbortException)
            {
                Console.ForegroundColor = ConsoleColor.Red;                
                Console.WriteLine($"Расчет значения \"{n}!\" - прерван (длительное ожидание заврешения операции)");
                Console.ForegroundColor = ConsoleColor.White;
            }
            finally
            {
                _waitFactorialEnd.Set();
            }
        }

        public static void Sum(int n)
        {
            try
            {
                ulong result = 0;

                for (int i = 0; i < n; i++)
                    result += (ulong)i;

                Console.WriteLine($"Sum({n}) = {result}");
            }
            catch (ThreadAbortException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Расчет значения \"Sum({n})\" - прерван (длительное ожидание заврешения операции)");
                Console.ForegroundColor = ConsoleColor.White;
            }
            finally
            {
                _waitSumEnd.Set();
            }
        }
    }
}

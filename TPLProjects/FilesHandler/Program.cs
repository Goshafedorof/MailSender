using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

// * В директории лежат файлы.По структуре они содержат три числа, разделенные пробелами.
// Первое число — целое, обозначает действие: 1- — умножение и 2 — деление.Остальные два
// — числа с плавающей точкой.Задача: написать многопоточное приложение, выполняющее
// эти действия над числами и сохраняющее результат в файл result.dat.Файлов в директории
// заведомо много.

namespace FilesHandler
{
    class Program
    {   
        private const int SIGN_MULTIPLY = 1;
        private const int SIGN_DIVISION = 2;
        private const int COUNT_NUMBERS_IN_FILE = 3;
        private const string FILENAME_RESULT = "result.dat";

        private static readonly string[] SEPARATORS = new string[] { " " };

        private static object _lock = new object();

        private static StreamWriter _streamWriter;

        static void Main(string[] args)
        {
            Console.Write("Введите путь к директории: ");
            string directoryPath = Console.ReadLine();

            StartAsync(directoryPath);

            Console.WriteLine();
            Console.Write("Для завершения работы нажмите любую клавишу...");
            Console.ReadKey();
        }

        private static async void StartAsync(string directoryPath)
        {
            DirectoryInfo directory = new DirectoryInfo(directoryPath);

            FileInfo[] files = directory.GetFiles();

            _streamWriter = new StreamWriter(Path.Combine(directory.FullName, FILENAME_RESULT));

            for (int i = 0; i < files.Length; i++)
            {
                string path = files[i].FullName;

                await OpenFile(path).ConfigureAwait(false);
            }

            _streamWriter.Close();
        }

        private static async Task OpenFile(string path)
        {
            StreamReader streamReader = new StreamReader(path);

            var text = await streamReader.ReadLineAsync().ConfigureAwait(false);

            streamReader.Close();

            string[] numbers = text.Split(SEPARATORS, StringSplitOptions.RemoveEmptyEntries);

            if (numbers.Length != COUNT_NUMBERS_IN_FILE)
                return;

            int sign = 0;

            if (!int.TryParse(numbers[0], out sign))
                return;

            float number_1 = 0;

            if (!float.TryParse(numbers[1], out number_1))
                return;

            float number_2 = 0;

            if (!float.TryParse(numbers[2], out number_2))
                return;

            float result = 0;

            if (sign == SIGN_MULTIPLY)
                result = number_1 * number_2;
            else if (sign == SIGN_DIVISION)
                result = number_1 / number_2;
            else
                return;

            await _streamWriter.WriteLineAsync($"{DateTime.Now.Millisecond} :: {result}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// * В директории лежат файлы.По структуре они содержат три числа, разделенные пробелами.
// Первое число — целое, обозначает действие: 1- — умножение и 2 — деление.Остальные два
// — числа с плавающей точкой.Задача: написать многопоточное приложение, выполняющее
// эти действия над числами и сохраняющее результат в файл result.dat.Файлов в директории
// заведомо много.

namespace FilesHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите путь к директории: ");
            string directoryPath = Console.ReadLine();

            DirectoryInfo directory = new DirectoryInfo(directoryPath);

            FileInfo[] files = directory.GetFiles();

            for (int i = 0; i < files.Length; i++)
            {
                string path = files[i].FullName;

                string text = File.ReadAllText(path);

                string[] numbers = text.Split(' ');
                               
                int sign = 0;

                if (!int.TryParse(numbers[0], out sign))
                    continue;

                float number_1 = 0;

                if (!float.TryParse(numbers[1], out number_1))
                    continue;

                float number_2 = 0;

                if (!float.TryParse(numbers[2], out number_2))
                    continue;

                float result = 0;

                if (sign == 1)
                    result = number_1 * number_2;
                else if (sign == 2)
                    result = number_1 / number_2;
                else
                    continue;

                File.WriteAllText("result.dat", result.ToString());
            }
        }
    }
}

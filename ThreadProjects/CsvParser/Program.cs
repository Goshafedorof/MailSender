using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Написать приложение, выполняющее парсинг CSV-файла произвольной структуры и
// сохраняющего его в обычный txt-файл.Все операции проходят в потоках.CSV-файл заведомо
// имеет большой объем.

// Формат .csv — это файл, в котором данные разделены между собой, используя конркетный символ

namespace CsvParser
{
    class Program
    {
        const string FILENAME = "data.csv";

        static void Main(string[] args)
        {
            // создаем тестовый файл
            ModelCsvFile.GetFile(FILENAME);


        }
    }
}

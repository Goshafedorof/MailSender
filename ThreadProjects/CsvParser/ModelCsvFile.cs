using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

// Написать приложение, выполняющее парсинг CSV-файла произвольной структуры и
// сохраняющего его в обычный txt-файл.Все операции проходят в потоках.CSV-файл заведомо
// имеет большой объем.

// Формат .csv — это файл, в котором данные разделены между собой, используя конркетный символ

namespace CsvParser
{
    public class ModelCsvFile
    {
        /// <summary>
        /// Строки в файле
        /// </summary>
        public List<Entity> Rows { get; set; } = new List<Entity>();




        public static ModelCsvFile ReadFile(string filename)
        {
            _modelCsvFile = new ModelCsvFile();
            _reader = new StreamReader(filename);

            return null;
        }

        private static ModelCsvFile _modelCsvFile;
        private static StreamReader _reader;
        private static object _locker = new object();


        public void ReadLine()
        {
            lock (_locker)
            {
                if (_reader.EndOfStream)
                    _reader.Close();
                _modelCsvFile.Rows.Add(Entity.Parse(_reader.ReadLine()));
            }
        }



        /// <summary>
        /// Возвращает какие-то дефолтные данные
        /// </summary>
        /// <param name="fileName"></param>
        public static void GetFile(string fileName)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 10000; i++)
            {
                sb.AppendLine(
                    $"Data_{i + 1}_1; " +
                    $"Data_{i + 1}_2; " +
                    $"Data_{i + 1}_3; " +
                    $"Data_{i + 1}_4; " +
                    $"Data_{i + 1}_5; " +
                    $"Data_{i + 1}_6; " +
                    $"Data_{i + 1}_7; " +
                    $"Data_{i + 1}_8");
            }

            File.WriteAllText(fileName, sb.ToString());
        }
    }
}

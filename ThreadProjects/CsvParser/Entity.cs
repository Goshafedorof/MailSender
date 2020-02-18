using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvParser
{
    public class Entity
    {
        private readonly static string[] SEPARATORS = new string[] { ",", ".", ";", ":" };

        /// <summary>
        /// Колонки, которые описывают структуру сущности
        /// </summary>
        public List<string> Properties { get; set; } = new List<string>();

        public static Entity Parse(string line) => new Entity() { Properties = new List<string>(line.Split(SEPARATORS, StringSplitOptions.RemoveEmptyEntries).AsEnumerable()) };        
    }
}

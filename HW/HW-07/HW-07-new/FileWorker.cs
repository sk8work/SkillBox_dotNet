using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07_new
{
    struct FileWorker
    {
        /// <summary>
        /// Метод для чтения из файла
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        static void FileReader(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line = String.Empty;
                Console.WriteLine($"{"ID",4} {"Дата создания",18} {"Время создания",18} {"ФИО",20} {"Возраст",8} {"Возраст",8} {"Рост",5} {"Дата рождения",15} {"Место рождения",15}");

                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('#');
                    Console.WriteLine($"{data[0],4} {data[1],18} {data[2],18} {data[3],20} {data[4],8} {data[5],8} {data[6],5} {data[7],15} {data[8],15}");
                }
            }
        }

        /// <summary>
        /// Метод для записи сотрудника в файл
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <param name="note">Строка для записи в файл</param>
        static void FileWriter(string path, string note)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(note);
            }
        }
    }
}

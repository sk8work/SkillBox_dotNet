using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace HW1
{
    class GetNumberFromFile
    {
        string dirName = "Source";
        string fileName = "getnumber.txt";
        public int Number { get; set; }
        public string Path { get; set; }

        public GetNumberFromFile()
        {
            Path = GetPath(dirName, fileName);
            IsFileExist(Path);
            Number = ReadFile(Path);
        }

        /// <summary>
        /// Читаем число из файла
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns>int</returns>
        static int ReadFile(string path)
        {
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                return int.Parse(sr.ReadLine());
            }
        }

        /// <summary>
        /// Проверка файла
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        public void IsFileExist(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine($"Файл getnumber.txt не найден. Файл будет создан автоматически с дефолтным числом = 555");
                Directory.CreateDirectory(dirName);

                using (StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write)))
                {
                    sw.WriteLine("555");
                }
            }
        }

        /// <summary>
        /// Возвращает полную директорию
        /// </summary>
        /// <param name="dirName"></param>
        /// <param name="fileName"></param>
        /// <returns>path</returns>
        public string GetPath(string dirName, string fileName)
        {
            string path = dirName + fileName;
            return path;
        }

    }
}


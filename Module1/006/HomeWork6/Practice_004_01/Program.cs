// Работа с потоками. StreamWriter, StreamReader

using System;
using System.IO;

namespace Practice_004_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var dirs = new DirectoryInfo(@"c:\").GetDirectories(); // dirs хранит все каталоки диска c:\

            StreamWriter streamwriter = new StreamWriter("cDirs.txt"); // Создание потока для работы сфайлом cDirs.txt

            foreach (DirectoryInfo dir in dirs)
            {
                streamwriter.WriteLine(dir.Name);  // Записать текущее имя каталога в файл
            }

            streamwriter.Close();   // Закрывем поток


            using(StreamWriter sw = new StreamWriter("cDirs2.txt"))
            {
                foreach(DirectoryInfo dir in dirs)
                {
                    sw.WriteLine(dir.Name);
                }
            }


            using (StreamReader sr = new StreamReader("cDirs.txt"))
            {
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }

                // Delay
                Console.ReadKey();
        }
    }
}

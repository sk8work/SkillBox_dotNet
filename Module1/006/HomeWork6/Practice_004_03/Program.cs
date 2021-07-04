using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_004_03
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("db.txt"))
            {
                while (!sr.EndOfStream)
                {
                    var c = sr.Read();
                    Console.WriteLine($"{c} - {(char)c}");
                }
            }

            Console.WriteLine();

            using (StreamReader sr = new StreamReader("db.txt"))
            {
                Console.WriteLine(sr.ReadToEnd());
            }

            //#region BinaryWriter BinaryReader
            //Console.WriteLine($"Нажмите Enter для продолжения\n");

            //Console.ReadKey(); Console.Clear();

            //string[] names = { "Юлия", "Ирина", "Светлана", "Екатерина", "Алиса" };

            //string path = @"BinaryNames.dat";

            //using(BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            //{
            //    // Записываеи в файл значение каждого поля структуры
            //    foreach (var name in names)
            //    {
            //        writer.Write(name);
            //    }
            //}
            //Console.WriteLine($"Файл {path} успешно создан. Нажмите Enter для продолжения\n");
            //Console.ReadLine();

            //using(BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            //{
            //    // покане достигнут конец файла
            //    // считываем каждое значение из файла

            //    while (reader.PeekChar() > -1)
            //    {
            //        string name = reader.ReadString();
            //        Console.WriteLine(name);
            //    }
            //}
            //#endregion

            //#region FileStream
            //Console.WriteLine("Нажмите Enter для продолжения\n");

            //Console.ReadKey(); Console.Clear();
            //Console.Write("Введите строку: ");
            //string text = Console.ReadLine();

            //// Запись в файл
            //using (FileStream fstream = new FileStream(@"note.txt", FileMode.Create))
            //{
            //    byte[] array = System.Text.Encoding.Default.GetBytes(text);
            //    fstream.Write(array, 0, array.Length);
            //}

            //// чтение из файла
            //using (FileStream fstream = File.OpenRead(@"note.txt"))
            //{
            //    byte[] array = new byte[fstream.Length];

            //    fstream.Read(array, 0, array.Length);

            //    text = System.Text.Encoding.Default.GetString(array);
            //    Console.WriteLine($"Текст: {text}");
            //}

            //Console.ReadLine();
            //#endregion

            //#region GZipStream
            //Console.WriteLine($"Нажмите Enter для продолжения\n");

            //Console.ReadKey(); Console.Clear();

            string source = "voina-i-mir.txt";
            string compressed = "voina-i-mir.zip";
            using (FileStream ss = new FileStream(source, FileMode.OpenOrCreate))
            {
                using (FileStream ts = File.Create(compressed)) // поток для записи сжатого файла
                {
                    // поток архивации
                    using (GZipStream cs = new GZipStream(ts, CompressionMode.Compress))
                    {
                        ss.CopyTo(cs);
                        Console.WriteLine("Сжатие файла {0} завершено. Было: {1}; Стало: {2}",
                            source,
                            ss.Length,
                            ts.Length);
                    }
                }
            }

            //Console.WriteLine($"нажмите Enter для продолжения");
            //Console.ReadKey();

            //using (FileStream ss = new FileStream(compressed, FileMode.OpenOrCreate))
            //{
            //    using(FileStream ts = File.Create($"_{source}"))
            //    {
            //        // поток разархивации
            //        using (GZipStream ds = new GZipStream(ss, CompressionMode.Decompress))
            //        {
            //            ds.CopyTo(ts);
            //            Console.WriteLine($"{source} восстанвлен");

            //            Console.WriteLine("Восстановление файла {0} заветшено. Было: {1}. Стало: {2}.",
            //                source,
            //                ss.Length,
            //                ts.Length);
            //        }
            //    }
            //}
//#endregion

            // Delay
            Console.ReadKey();
        }
    }
}

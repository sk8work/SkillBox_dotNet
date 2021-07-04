// Требуется создать файл - аналог записной книжки
// В файле хранится
// Имя авторазаписи
// Дата
// Описание заметки

using System;
using System.IO;
using System.Text;

namespace Practice_004_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region Запись в файл StramWriter
            //using (StreamWriter sw = new StreamWriter("db.csv", true, Encoding.Unicode))
            //{
            //    char key = 'д';

            //    do
            //    {
            //        string note = string.Empty;
            //        Console.WriteLine("\nВведите имя автора записи: ");
            //        note += $"{Console.ReadLine()}\t";

            //        string now = DateTime.Now.ToShortTimeString();
            //        Console.WriteLine($"Время заметки {now}");
            //        note += $"{now}\t";

            //        Console.Write("Введите описание заметки: ");
            //        note += $"{Console.ReadLine()}\t";
            //        sw.WriteLine(note);
            //        Console.Write("Продолжить работу н/д: ");
            //        key = Console.ReadKey(true).KeyChar;

            //    } while (char.ToLower(key) == 'д');
            //}
            //#endregion

            #region Чтение из файла StreamReader
            using(StreamReader sr = new StreamReader("db.csv", Encoding.Unicode))
            {
                string line;
                Console.WriteLine($"{"Автор", -15}{"Время", -8}{"Описание"}");

                while((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('\t');
                    Console.WriteLine($"{data[0], -15}{data[1], -8}{data[2]}");
                }
            }
            #endregion


            // Delay
            Console.ReadKey();
        }
    }
}

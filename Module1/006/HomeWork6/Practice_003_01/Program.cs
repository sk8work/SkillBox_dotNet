// Работа с файлами: класс File, FileInfo, Directory, DirectoryInfo

using System;
using System.IO;

namespace Practice_003_01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region File
            // using System.IO
            // предоставляет статические методы для создания, копирования, удаления, перемещения и открытия

            string text = File.ReadAllText(@"D:\SkillBox_dotNet\Lesson6\data.txt"); // открывает текстовый файл, считывает все строки
            Console.WriteLine(text);

            string[] lines = File.ReadAllLines(@"D:\SkillBox_dotNet\Lesson6\data.txt");
            foreach (var line in lines)
            {
                Console.WriteLine($">>{line}<<");
            }

            lines = new string[] { "один", "два", "три" };
            File.WriteAllLines(@"D:\SkillBox_dotNet\Lesson6\data2.txt", lines); //Создает новый файл

            text = "Пример текста";
            File.WriteAllText(@"D:\SkillBox_dotNet\Lesson6\data3.txt", text); // Создает или перезаписывает

            //File.AppendAllLines
            //File.AppendAllText

            File.Copy(@"D:\SkillBox_dotNet\Lesson6\data3.txt", @"D:\SkillBox_dotNet\Lesson6\newdata3.txt");

            Console.WriteLine(File.Exists(@"D:\SkillBox_dotNet\Lesson6\newdata3.txt"));

            File.Delete(@"D:\SkillBox_dotNet\Lesson6\newdata3.txt");

            File.Exists(@"D:\SkillBox_dotNet\Lesson6\newdata3.txt");

            //File.Move(@"D:\SkillBox_dotNet\Lesson6\data3.txt", @"D:\SkillBox_dotNet\data3.txt");

            #endregion

            // Delay
            Console.ReadKey();
        }
    }
}

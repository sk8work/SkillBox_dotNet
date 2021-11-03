// Получение всех файлов и папок выбранного каталога

using System;
using System.IO;

namespace Practice_003_03
{
    class Program
    {
        static void GetDir(string path, string trim = "")
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            foreach (var item in directoryInfo.GetDirectories())
            {
                Console.WriteLine($"{trim}{item.Name}");
                GetDir(item.FullName, trim + "    ");
            }
            foreach (var item in directoryInfo.GetFiles())
            {
                Console.WriteLine($"{trim}{item.Name}");
            }
        }
        static void Main(string[] args)
        {
            #region Directory, DirectoryInfo

            DirectoryInfo directoryInfo = new DirectoryInfo(@"c:\");

            // GetDir(@"D:\");
            GetDir(@"C:\Program Files\Windows Defender");

            #endregion

            //Delay
            Console.ReadKey();
        }
    }
}

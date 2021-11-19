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
        /// Читает из файла построчно. UserInfo.Id++
        /// </summary>
        /// <param name="path"></param>
        public static void Writer(string path)
        {
            if (File.Exists(path))
            {
                UserInfo.Id = 0;
                using (StreamReader sr = new StreamReader(path, Encoding.Unicode))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        UserInfo.Id += 1;
                    }
                }
            }

            UserInfo.GetUserInfo();
            string noteToWrite = UserInfo.GetUserString(UserInfo.Id, UserInfo.Fio, UserInfo.Age, UserInfo.High, UserInfo.BirthDate, UserInfo.BirthPlace);
            WriteStreamToFile(path, noteToWrite);
        }

        /// <summary>
        /// Метод для записи в файл из потока
        /// </summary>
        /// <param name="path"></param>
        /// <param name="note"></param>
        public static void WriteStreamToFile(string path, string note)
        {
            using (StreamWriter ss = new StreamWriter(path, true, Encoding.Unicode))
            {
                ss.WriteLine($"{note}");
            }
        }

        /// <summary>
        /// Читаем из файла
        /// </summary>
        /// <param name="path">FileName (или путь к файлу)</param>
        public static void Reader(string path)
        {
            string noteHeader = string.Empty;
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path, Encoding.Unicode))
                {
                    string line;
                    ConsoleMethods.PrintHeaderNote();

                    while ((line = sr.ReadLine()) != null)
                    {
                        ConsoleMethods.PrintNote(UserInfo.NoteToArr(line));
                    }
                }
            }
            else
            {
                ConsoleMethods.ReadError();
            }
        }
    }
}

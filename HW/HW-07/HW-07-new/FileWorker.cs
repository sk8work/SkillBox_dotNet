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
                UserInfo.id = 0;
                using (StreamReader sr = new StreamReader(path, Encoding.Unicode))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        UserInfo.id += 1;
                    }
                }
            }

            UserInfo.GetUserInfo();
            string noteToWrite = UserInfo.GetUserString(UserInfo.id, UserInfo.Fio, UserInfo.Age, UserInfo.High, UserInfo.BirthDate, UserInfo.BirthPlace);
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
                string[] lines = File.ReadAllLines(path);
                using (StreamReader sr = new StreamReader(path, Encoding.Unicode))
                {
                    ConsoleMethods.PrintHeaderNote();

                    foreach (var i in lines)
                    {
                        ConsoleMethods.PrintNote(UserInfo.NoteToArr(i));
                    }
                }
            }
            else
            {
                ConsoleMethods.FileExistError();
            }
        }

        /// <summary>
        /// Удаляет запись о сотруднике из файла по переданному Id
        /// </summary>
        /// <param name="path"></param>
        /// <param name="id"></param>
        public static void Erazer(string path, string id)
        {
            Sorter.SortedBy(path);
            if (File.Exists(path))
            {
                var lines = File.ReadAllLines(path);
                List<string> ls = new List<string>();
                foreach (var i in lines)
                {
                    if (UserInfo.NoteToArr(i)[0] == id)
                    {
                        continue;
                    }
                    ls.Add(i);
                }

                File.WriteAllLines(path, ls);
            }
            else
            {
                ConsoleMethods.FileExistError();
            }
        }

        /// <summary>
        /// Изменяет запись о сотруднике из файла по переданному Id
        /// </summary>
        /// <param name="path"></param>
        /// <param name="id"></param>
        public static void Renamer(string path, int id)
        {
            if (File.Exists(path))
            {
                var lines = File.ReadAllLines(path);
                List<string> ls = new List<string>();
                foreach (var i in lines)
                {
                    if (Convert.ToInt32(UserInfo.NoteToArr(i)[0]) == id)
                    {
                        UserInfo.GetUserInfo();
                        string noteToWrite = UserInfo.GetUserString(id, UserInfo.Fio, UserInfo.Age, UserInfo.High, UserInfo.BirthDate, UserInfo.BirthPlace);
                        //WriteStreamToFile(path, noteToWrite);
                        ls.Add(noteToWrite);
                        continue;
                    }
                    ls.Add(i);
                }
                File.WriteAllLines(path, ls);
            }
        }
    }
}

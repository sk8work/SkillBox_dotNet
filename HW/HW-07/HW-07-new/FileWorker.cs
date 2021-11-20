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

            UserInfo ui = new UserInfo();
            ui.SetUserInfo();
            string noteToWrite = UserInfo.GetUserString(UserInfo.id, ui.Fio, ui.Age, ui.High, ui.BirthDate, ui.BirthPlace);
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
                        UserInfo ui = new UserInfo();
                        ui.SetUserInfo();
                        string noteToWrite = UserInfo.GetUserString(id, ui.Fio, ui.Age, ui.High, ui.BirthDate, ui.BirthPlace);
                        ls.Add(noteToWrite);
                        continue;
                    }
                    ls.Add(i);
                }
                File.WriteAllLines(path, ls);
            }
        }

        /// <summary>
        /// Формирует массив сотрудников (для дальнейшей сортировки)
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static List<UserInfo> UsersToArr(string path)
        {
            List<UserInfo> uiArr = new List<UserInfo>();
            var lines = File.ReadAllLines(path);

            foreach (var i in lines)
            {
                UserInfo ui = new UserInfo();

                ui.Id = Convert.ToInt32(UserInfo.NoteToArr(i)[0]);
                ui.DT = Convert.ToDateTime(UserInfo.NoteToArr(i)[1]);
                ui.TT = Convert.ToDateTime(UserInfo.NoteToArr(i)[2]);
                ui.Fio = UserInfo.NoteToArr(i)[3];
                ui.Age = Convert.ToInt32(UserInfo.NoteToArr(i)[4]);
                ui.High = Convert.ToInt32(UserInfo.NoteToArr(i)[5]);
                ui.BirthDate = Convert.ToDateTime(UserInfo.NoteToArr(i)[6]);
                ui.BirthPlace = UserInfo.NoteToArr(i)[7];

                uiArr.Add(ui);
            }
            return uiArr;
        }


        /// <summary>
        /// Формирует список сотрудников по диапазону выбранных дат
        /// </summary>
        /// <param name="path"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static List<UserInfo> DateDiapazon(string path)
        {
            List<UserInfo> uiArr = new List<UserInfo>();
            var lines = File.ReadAllLines(path);

            DateTime start = ConsoleMethods.SetStartDate();
            DateTime end = ConsoleMethods.SetEndDate();

            foreach (var i in lines)
            {
                UserInfo ui = new UserInfo();
                if (Convert.ToDateTime(UserInfo.NoteToArr(i)[1]) >= start && Convert.ToDateTime(UserInfo.NoteToArr(i)[1]) <= end)
                {
                    ui.Id = Convert.ToInt32(UserInfo.NoteToArr(i)[0]);
                    ui.DT = Convert.ToDateTime(UserInfo.NoteToArr(i)[1]);
                    ui.TT = Convert.ToDateTime(UserInfo.NoteToArr(i)[2]);
                    ui.Fio = UserInfo.NoteToArr(i)[3];
                    ui.Age = Convert.ToInt32(UserInfo.NoteToArr(i)[4]);
                    ui.High = Convert.ToInt32(UserInfo.NoteToArr(i)[5]);
                    ui.BirthDate = Convert.ToDateTime(UserInfo.NoteToArr(i)[6]);
                    ui.BirthPlace = UserInfo.NoteToArr(i)[7];
                    uiArr.Add(ui);
                }
            }
            return uiArr;
        }
    }
}

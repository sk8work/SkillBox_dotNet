//Создайте справочник «Сотрудники».

//Разработайте для предполагаемой компании программу, которая будет добавлять записи новых сотрудников в файл. Файл должен содержать следующие данные:

//ID
//Дату и время добавления записи
//Ф. И. О.
//Возраст
//Рост
//Дату рождения
//Место рождения
//Для этого необходим ввод данных с клавиатуры. После ввода данных:

//если файла не существует, его необходимо создать;
//если файл существует, то необходимо записать данные сотрудника в конец файла. 
//При запуске программы должен быть выбор:

//введём 1 — вывести данные на экран;
//введём 2 — заполнить данные и добавить новую запись в конец файла.


using System;
using System.IO;
using System.Text;

namespace HW_06_new
{
    class Program
    {

        /// <summary>
        /// Delay
        /// </summary>
        static void Delay()
        {
            Console.ReadKey();
        }

        public static int id = 0;
        static string fio = String.Empty;
        static int age = 0;
        static int high = 0;
        static DateTime birthDate = new DateTime(1990,01,01);
        static string birthPlace = String.Empty;

        /// <summary>
        /// Записываем данные в файл
        /// </summary>
        /// <param name="path">FileName (или путь к файлу)</param>
        static void Writer(string path)
        {
            if (File.Exists(path))
            {
                id = 0;
                using (StreamReader sr = new StreamReader(path, Encoding.Unicode))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        id += 1;
                    }
                }
            }

            GetUserInfo();
            string noteToWrite = GetUserString(id, fio, age, high, birthDate, birthPlace);
            WriteStreamToFile(path, noteToWrite);
        }

        /// <summary>
        /// Формируем строку с данными от пользователя
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fio"></param>
        /// <param name="age"></param>
        /// <param name="high"></param>
        /// <param name="birthDate"></param>
        /// <param name="birthPlace"></param>
        /// <returns></returns>
        public static string GetUserString(int id, string fio, int age, int high, DateTime birthDate, string birthPlace)
        {
            string note = string.Empty;

            note += $"{id}#{DateTime.Now.ToShortDateString()}/{ DateTime.Now.ToShortTimeString()}#{fio}#{age}#{high}#{birthDate}#{birthPlace}";
            return note;
        }

        /// <summary>
        /// Формируем строку с данными от пользователя
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fio"></param>
        /// <param name="age"></param>
        /// <param name="high"></param>
        /// <param name="birthDate"></param>
        /// <param name="birthPlace"></param>
        /// <returns></returns>
        public static void GetUserInfo()
        {
            Console.Write("\nВведите Ф.И.О.: ");
            fio = Console.ReadLine();

            Console.Write("Введите Возраст: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите Рост: ");
            high = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите Дату рождения: ");
            birthDate = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Введите Место рождения: ");
            birthPlace = Console.ReadLine();
        }

        /// <summary>
        /// ПМетод для записи в файл из потока
        /// </summary>
        /// <param name="path"></param>
        /// <param name="note"></param>
        static void WriteStreamToFile(string path, string note)
        {
            using (StreamWriter ss = new StreamWriter(path, true, Encoding.Unicode))
            {
                ss.WriteLine($"{note}");
            }
        }

        /// <summary>
        /// Печать заголовка
        /// </summary>
        static void PrintHeaderNote()
        {
            Console.WriteLine($"\n{"ID",-5}{"Дата и время",-20}{"Ф. И. О.",-25}{"Возраст",-10}{"Рост",-7}{"Дата рождения",-17}{"Место рождения",-17}");
        }

        /// <summary>
        /// Печать информации о сотруднике
        /// </summary>
        /// <param name="note"></param>
        static string[] NoteToArr(string note)
        {
            //string note = String.Empty;
            string[] data = note.Split('#');
            return data;
        }


        /// <summary>
        /// Печатает элементы массива в строку
        /// </summary>
        /// <param name="data"></param>
        static void PrintNote(string[] data)
        {
            Console.WriteLine($"{data[0],-5}{data[1],-20}{data[2],-20}{data[3],-10}{data[4],-7}{data[5],-17}{data[6],-17}");
        }

        /// <summary>
        /// Печатает сообщение об ошибке чтения из файла
        /// </summary>
        static void ReadError()
        {
            Console.WriteLine("\nФайл пуст или не существует. Заполните файл!");
        }

        /// <summary>
        /// Читаем из файла
        /// </summary>
        /// <param name="path">FileName (или путь к файлу)</param>
        static void Reader(string path)
        {
            string noteHeader = string.Empty;
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path, Encoding.Unicode))
                {
                    string line;
                    PrintHeaderNote();

                    while ((line = sr.ReadLine()) != null)
                    {
                        PrintNote(NoteToArr(line));
                    }
                }
            }
            else
            {
                ReadError();
            }
        }

        /// <summary>
        /// Вывод меню программы
        /// </summary>
        /// <param name="path">FileName (или путь к файлу)</param>
        static void Game(string path)
        {
            var game = true;
            while (game)
            {
                Console.WriteLine("Программа учета сотрудников компании");
                Console.WriteLine("Меню программы: ");
                Console.WriteLine("1 - Добавить сотрудника.");
                Console.WriteLine("2 - Вывести список сотрудников.");
                Console.WriteLine("q - Выйти из программы");
                Console.Write(">> ");
                char choice = ' ';
                choice = Console.ReadKey().KeyChar;
                switch (choice)
                {
                    case '1':
                        {
                            Writer(path);
                            break;
                        }
                    case '2':
                        {
                            Reader(path);
                            break;
                        }
                    case 'q':
                        {
                            game = false;
                            break;
                        }
                }
            }
            Console.WriteLine("\nGood bye!!!");
        }

        static void Main(string[] args)
        {
            Game("db.txt");

            // Delay
            Delay();
        }
    }
}

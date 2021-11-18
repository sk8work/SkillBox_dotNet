//Что нужно сделать:
//Улучшите программу, которую разработали в модуле 6. Создайте структуру «Сотрудник» со следующими полями:

//ID
//Дата и время добавления записи
//Ф.И.О.
//Возраст
//Рост
//Дата рождения
//Место рождения


//Для записей реализуйте следующие функции:

//Просмотр записи.Функция должна содержать параметр ID записи, которую необходимо вывести на экран.
//Создание записи.
//Удаление записи.
//Редактирование записи.
//Загрузка записей в выбранном диапазоне дат.
//Сортировка по возрастанию и убыванию даты.


using System;
using System.IO;
using System.Text;

namespace HW_07_new
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



        /// <summary>
        /// Метод для записи в файл из потока
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

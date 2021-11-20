using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07_new
{
    struct GameStart
    {
        /// <summary>
        /// Вывод меню программы
        /// </summary>
        /// <param name="path">FileName (или путь к файлу)</param>
        public static void Game(string path)
        {
            var game = true;
            while (game)
            {
                Console.WriteLine("Программа учета сотрудников компании.");
                Console.WriteLine("Меню программы: ");
                Console.WriteLine("1 - Добавить сотрудника.");
                Console.WriteLine("2 - Вывести список сотрудников.");
                Console.WriteLine("3 - Удалить сотрудника.");
                Console.WriteLine("4 - Изменить запись.");
                Console.WriteLine("5 - Меню сортировки списка сотрудников.");
                Console.WriteLine("6 - Вывести список сотрудников из диапазона дат.");
                Console.WriteLine("q - Выйти из программы.");
                Console.Write(">> ");
                char choice = ' ';
                choice = Console.ReadKey().KeyChar;
                switch (choice)
                {
                    case '1':
                        {
                            FileWorker.Writer(path);
                            break;
                        }
                    case '2':
                        {
                            FileWorker.Reader(path);
                            break;
                        }
                    case '3':
                        {
                            string id = ConsoleMethods.GetUserIdForDelete();
                            FileWorker.Erazer(path, id);
                            break;
                        }
                    case '4':
                        {
                            int id = Int32.Parse(ConsoleMethods.GetUserIdForRename());
                            FileWorker.Renamer(path, id);
                            break;
                        }
                    case '5':
                        {
                            Console.WriteLine();
                            SortMenu(path);
                            break;
                        }
                    case '6':
                        {
                            List<UserInfo> uiArr = FileWorker.DateDiapazon(path);
                            ConsoleMethods.PrintHeaderNote();
                            ConsoleMethods.PrintListToNote(uiArr);
                            break;
                        }
                    case 'q':
                        {
                            game = false;
                            break;
                        }
                }
            }
            ConsoleMethods.PrintGoodbye();
        }

        /// <summary>
        /// вывод меню сортировки
        /// </summary>
        /// <param name="path"></param>
        public static void SortMenu(string path)
        {
            var sort = true;
            while (sort)
            {
                Console.WriteLine(">> Меню сортировки.");
                Console.WriteLine(">> 1 - Сортировка по Id.");
                Console.WriteLine(">> 2 - Сортировка по имени.");
                Console.WriteLine(">> 3 - Сортировка по дате рождения.");
                Console.WriteLine(">> 4 - Сортировка по возрасту.");
                Console.WriteLine(">> 5 - Сортировка по росту.");
                Console.WriteLine(">> 6 - Сортировка по дате создания.");
                Console.WriteLine("q - Выйти в главное меню.");
                Console.Write(">>>> ");
                char choice = ' ';
                choice = Console.ReadKey().KeyChar;
                List<UserInfo> uiArr = FileWorker.UsersToArr(path);
                switch (choice)
                {
                    case '1':
                        {
                            Sorter.SortById(uiArr);
                            ConsoleMethods.PrintHeaderNote();
                            ConsoleMethods.PrintListToNote(uiArr);
                            break;
                        }
                    case '2':
                        {
                            Sorter.SortByName(uiArr);
                            ConsoleMethods.PrintHeaderNote();
                            ConsoleMethods.PrintListToNote(uiArr);
                            break;
                        }
                    case '3':
                        {
                            Sorter.SortByBDate(uiArr);
                            ConsoleMethods.PrintHeaderNote();
                            ConsoleMethods.PrintListToNote(uiArr);
                            break;
                        }
                    case '4':
                        {
                            Sorter.SortByAge(uiArr);
                            ConsoleMethods.PrintHeaderNote();
                            ConsoleMethods.PrintListToNote(uiArr);
                            break;
                        }
                    case '5':
                        {
                            Sorter.SortByHigh(uiArr);
                            ConsoleMethods.PrintHeaderNote();
                            ConsoleMethods.PrintListToNote(uiArr);
                            break;
                        }
                    case '6':
                        {
                            Sorter.SortByDateCreation(uiArr);
                            ConsoleMethods.PrintHeaderNote();
                            ConsoleMethods.PrintListToNote(uiArr);
                            break;
                        }
                    case 'q':
                        {
                            sort = false;
                            break;
                        }
                }
            }
        }
    }
}

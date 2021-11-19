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
                            FileWorker.Writer(path);
                            break;
                        }
                    case '2':
                        {
                            FileWorker.Reader(path);
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
    }
}

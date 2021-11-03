/// Домашнее задание
///
/// Группа начинающих программистов решила поучаствовать в хакатоне с целью демонстрации
/// своих навыков. 
/// 
/// Немного подумав они вспомнили, что не так давно на занятиях по математике
/// они проходили тему "свойства делимости целых чисел". На этом занятии преподаватель показывал
/// пример с использованием фактов делимости. 
/// Пример заключался в следующем: 
/// Написав на доске все числа от 1 до N, N = 50, преподаватель разделил числа на несколько групп
/// так, что если одно число делится на другое, то эти числа попадают в разные руппы. 
/// В результате этого разбиения получилось M групп, для N = 50, M = 6
/// 
/// N = 50
/// Группы получились такими: 
/// 
/// Группа 1: 1
/// Группа 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
/// Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
/// Группа 4: 8 12 18 20 27 28 30 42 44 45 50
/// Группа 5: 16 24 36 40
/// Группа 6: 32 48
/// 
/// M = 6
/// 
/// ===========
/// 
/// N = 10
/// Группы получились такими: 
/// 
/// Группа 1: 1
/// Группа 2: 2 7 9
/// Группа 3: 3 4 10
/// Группа 4: 5 6 8
/// 
/// M = 4
/// 
/// Участники хакатона решили эту задачу, добавив в неё следующие возможности:
/// 1. Программа считыват из файла (путь к которому можно указать) некоторое N, 
///    для которого нужно подсчитать количество групп
///    Программа работает с числами N не превосходящими 1 000 000 000
///   
/// 2. В ней есть два режима работы:
///   2.1. Первый - в консоли показывается только количество групп, т е значение M
///   2.2. Второй - программа получает заполненные группы и записывает их в файл используя один из
///                 вариантов работы с файлами
///            
/// 3. После выполения пунктов 2.1 или 2.2 в консоли отображается время, за которое был выдан результат 
///    в секундах и миллисекундах
/// 
/// 4. После выполнения пунта 2.2 программа предлагает заархивировать данные и если пользователь соглашается -
/// делает это.
/// 
/// Попробуйте составить конкуренцию начинающим программистам и решить предложенную задачу
/// (добавление новых возможностей не возбраняется)
///
/// * При выполнении текущего задания, необходимо документировать код 
///   Как пометками, так и xml документацией
///   В обязательном порядке создать несколько собственных методов

using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace HW6_old_version_
{
    class Program
    {

        static string source = "maxValue.txt";
        static string sourceResult = "resultGroups.txt";
        static string compressed = "resultGroups.zip";

        static int max = 0;
        static int groups = 0;

        /// <summary>
        /// Получаем максимальное число из файла
        /// </summary>
        /// <param name="path">FileName (или путь к файлу)</param>
        static void Reader(string source)
        {
            if (File.Exists(source))
            {
                using (StreamReader sr = new StreamReader(source))
                {
                    max = int.Parse(sr.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("\nФайл пуст или не существует. Заполните файл!");
            }
        }

        /// <summary>
        /// Получаем количество групп
        /// </summary>
        /// <param name="val">Сюда кладем число из файла</param>
        static void GetGroupsCount(int val)
        {
            int groupsCount = 0;
            DateTime before = DateTime.Now;
            while (Math.Pow(2, groupsCount) < val)
            {
                groupsCount++;
            }

            groups = groupsCount + 1;
        }

        /// <summary>
        /// Получаем количество групп и печатаем в консоль
        /// </summary>
        /// <param name="val">Сюда кладем число из файла</param>
        static void GetGroupsCountAndPrint(int val)
        {
            int groupsCount = 0;
            DateTime before = DateTime.Now;
            while (Math.Pow(2, groupsCount) < val)
            {
                groupsCount++;
            }

            groups = groupsCount + 1;
            TimeSpan span = DateTime.Now - before;
            Console.WriteLine();
            Console.WriteLine($"{groups} - групп чисел");
            Console.WriteLine($"{span.TotalMilliseconds} - миллисекунд затрачено на подсчет групп чисел");
            Console.WriteLine($"{span.TotalSeconds} - секунд затрачено на подсчет групп чисел");
        }

        /// <summary>
        /// Архиватор итогового файла
        /// </summary>
        /// <param name="source"></param>
        /// <param name="compressed"></param>
        static void Archivator(string source, string compressed)
        {
            using (FileStream ss = new FileStream(source, FileMode.OpenOrCreate))
            {
                using (FileStream ts = File.Create(compressed))   // поток для записи сжатого файла
                {
                    // поток архивации
                    using (GZipStream cs = new GZipStream(ts, CompressionMode.Compress))
                    {
                        ss.CopyTo(cs); // копируем байты из одного потока в другой
                        Console.WriteLine();
                        Console.WriteLine("Архивация файла {0} завершена. Было: {1}  стало: {2}.",
                                          source,
                                          ss.Length,
                                          ts.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Записываем группы чисел в файл
        /// </summary>
        /// <param name="groups"></param>
        /// <param name="max"></param>
        static void PrintNotes(int groups, int max)
        {
            using (StreamWriter ss = new StreamWriter(sourceResult, true, Encoding.Unicode))
            {
                string note = string.Empty;
                DateTime before = DateTime.Now;
                for (int i = 0; i < groups; i++)
                {
                    note = string.Empty;
                    for (int k = 1; k <= max; k++)
                    {
                        if ((k >= Math.Pow(2, i)) && (k < Math.Pow(2, i + 1)))
                        {
                            ss.Write($"{Convert.ToString(k)}#");
                            continue;
                        }
                        if (k > Math.Pow(2, i + 1))
                        {
                            break;
                        }
                    }
                    ss.WriteLine("");
                }
                TimeSpan span = DateTime.Now - before;
                Console.WriteLine();
                Console.WriteLine("Запись в файл выполнена");
                Console.WriteLine($"{span.TotalMilliseconds} - миллисекунд затрачено на запись групп чисел в файл");
                Console.WriteLine($"{span.TotalSeconds} - секунд затрачено на запись групп чисел в файл");
            }

            Console.Write("Произвести архивацию? (д/н): ");

            char archChoise = Console.ReadKey().KeyChar;
            Console.ReadKey();
            switch (archChoise)
            {
                case 'д':
                case 'y':
                    Archivator(sourceResult, compressed);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Старт программы
        /// </summary>
        static void Game()
        {
            bool isGame = true;
            while (isGame)
            {
                Console.WriteLine("Программа считывает число (N) из файла разбивает множество натуральных чисел от 1 до N на подмножества, каждый элемент которого не делится без остатка на другй из этого же подмножества");
                Console.WriteLine("Меню программы: ");
                Console.WriteLine("1 - Показать количество подмножеств");
                Console.WriteLine("2 - Заполнить файл");
                Console.WriteLine("q - Выйти из программы");

                Reader(source);

                char userChoise;
                userChoise = Console.ReadKey().KeyChar;
                switch (userChoise)
                {
                    case '1':
                        GetGroupsCountAndPrint(max);
                        break;
                    case '2':
                        GetGroupsCount(max);
                        PrintNotes(groups, max);
                        break;
                    case 'q':
                        isGame = false;
                        Console.WriteLine();
                        Console.WriteLine("Пока!!!");
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Неверный выбор!!!");
                        break;
                }
            }
        }

        /// <summary>
            /// Delay
            /// </summary>
        static void Delay()
        {
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Game();

            Delay();
        }
    }
}

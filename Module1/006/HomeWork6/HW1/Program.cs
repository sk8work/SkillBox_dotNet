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


namespace HW1
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

        static int id = 0;

        /// <summary>
        /// Записываем данные в файл
        /// </summary>
        /// <param name="path">FileName (или путь к файлу)</param>
        static void Writer(string path)
        {
            if(File.Exists(path))
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
            

            using (StreamWriter ss = new StreamWriter(path, true, Encoding.Unicode))
            {
                

                string note = string.Empty;

                note += $"{Convert.ToString(id)}#";

                note += $"{DateTime.Now.ToShortDateString()}/{ DateTime.Now.ToShortTimeString()}#";

                Console.WriteLine("\nВведите Ф.И.О.: ");
                note += $"{Console.ReadLine()}#";

                Console.Write("Введите Возраст: ");
                note += $"{Console.ReadLine()}#";

                Console.Write("Введите Рост: ");
                note += $"{Console.ReadLine()}#";

                Console.Write("Введите Дату рождения: ");
                note += $"{Console.ReadLine()}#";

                Console.Write("Введите Место рождения: ");
                note += $"{Console.ReadLine()}#";

                ss.WriteLine($"{note}");
            }
        }

        /// <summary>
        /// Читаем из файла
        /// </summary>
        /// <param name="path">FileName (или путь к файлу)</param>
        static void Reader(string path)
        {
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path, Encoding.Unicode))
                {
                    string line;
                    Console.WriteLine($"\n{"ID",-5}{"Дата и время",-20}{"Ф. И. О.",-20}{"Возраст",-10}{"Рост",-7}{"Дата рождения",-17}{"Место рождения",-17}");

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('#');
                        Console.WriteLine($"{data[0],-5}{data[1],-20}{data[2],-20}{data[3],-10}{data[4],-7}{data[5],-17}{data[6],-17}");
                    }
                }
            } else
            {
                Console.WriteLine("\nФайл пуст или не существует. Заполните файл!");
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

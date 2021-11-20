using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07_new
{
    struct ConsoleMethods
    {
        /// <summary>
        /// Печать заголовка
        /// </summary>
        public static void PrintHeaderNote()
        {
            Console.WriteLine($"\n{"ID",-5}{"Дата записи",-15}{"Время записи",-15}{"Ф. И. О.",-25}{"Возраст",-10}{"Рост",-7}{"Дата рождения",-17}{"Место рождения",-17}");
        }

        /// <summary>
        /// Печатает элементы массива в строку
        /// </summary>
        /// <param name="data"></param>
        public static void PrintNote(string[] data)
        {
            Console.WriteLine($"{data[0],-5}{data[1],-15}{data[2],-15}{data[3],-25}{data[4],-10}{data[5],-7}{data[6],-17}{data[7],-17}");
        }

        /// <summary>
        /// Печатает элементы массива (List) в строку
        /// </summary>
        /// <param name="data"></param>
        public static void PrintListToNote(List<UserInfo> userArr)
        {
            foreach (var item in userArr)
            {
                Console.WriteLine($"{item.Id,-5}{item.DT.ToShortDateString(),-15}{item.TT.ToShortTimeString(),-15}{item.Fio,-25}{item.Age,-10}{item.High,-7}{item.BirthDate.ToShortDateString(),-17}{item.BirthPlace,-17}");
            }
        }

        /// <summary>
        /// Печатает сообщение об ошибке чтения из файла
        /// </summary>
        public static void FileExistError()
        {
            Console.WriteLine("\nФайл пуст или не существует. Заполните файл!");
        }

        /// <summary>
        /// Печатает сообщение об ошибке чтения из файла
        /// </summary>
        public static void IdError()
        {
            Console.WriteLine("\nДанного Id не существует. Введите Id.");
        }

        /// <summary>
        /// Выводит сообщение об успешном удалении записи сотрудника
        /// </summary>
        public static void NoteDeleted()
        {
            Console.WriteLine("\nЗапись удалена.");
        }

        /// <summary>
        /// 
        /// </summary>
        public static string GetUserIdForDelete()
        {
            Console.Write("\nВведите Id сотрудникка для удаления: ");
            return Console.ReadLine();
        }

        /// <summary>
        /// 
        /// </summary>
        public static string GetUserIdForRename()
        {
            Console.Write("\nВведите Id сотрудникка для изменения записи: ");
            return Console.ReadLine();
        }

        /// <summary>
        /// Печатает 'Good bye!!!'
        /// </summary>
        public static void PrintGoodbye()
        {
            Console.WriteLine("\nGood Bye!!!");
        }

        /// <summary>
        /// Печатает Заголовок для сортировки по Id
        /// </summary>
        public static void PrintHeaderListById()
        {
            Console.WriteLine("Список сотрудников, отсортированных по Id: ");
        }

        /// <summary>
        /// Печатает Заголовок для сортировки по Дате рождения
        /// </summary>
        public static void PrintHeaderListByBDate()
        {
            Console.WriteLine("Список сотрудников, отсортированных по Дате рождения: ");
        }

        /// <summary>
        /// Печатает Заголовок для сортировки по Возрасту
        /// </summary>
        public static void PrintHeaderListByAge()
        {
            Console.WriteLine("Список сотрудников, отсортированных по Возрасту: ");
        }

        /// <summary>
        /// Печатает Заголовок для сортировки по Росту
        /// </summary>
        public static void PrintHeaderListByHeight()
        {
            Console.WriteLine("Список сотрудников, отсортированных по Росту: ");
        }

        /// <summary>
        /// Печатает Заголовок для сортировки по Имени
        /// </summary>
        public static void PrintHeaderListByName()
        {
            Console.WriteLine("Список сотрудников, отсортированных по Имени: ");
        }

        /// <summary>
        /// Печатает Заголовок для сортировки по Дате создания
        /// </summary>
        public static void PrintHeaderListByDateCreation()
        {
            Console.WriteLine("Список сотрудников, отсортированных по Дате создания: ");
        }

    } 
}
